using DataBase;
using Microsoft.AspNetCore.Http;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Services.Dto;
using Microsoft.EntityFrameworkCore.Internal;

namespace Services.Implementation
{
    public class UserService : IUserService
    {
        private xPatreonDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UserService(xPatreonDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        #region User
        public int RegisterUser(UserDto model)
        {
            string default_image = "/imgs/default user.png";
            if (model.UserName != null && model.Email != null && model.Password != null)
            {
                var newUser = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,
                    Image = default_image,
                    Role = model.Role,
                    RegistrationData = DateTime.Now,
                };
                _context.User.Add(newUser);
                return _context.SaveChanges();
            }
            return 0;
        }

        public bool LoginUser(UserDto model)
        {
            try
            {
                var usr = _context.User.Single(u => u.UserName == model.UserName && u.Password == model.Password);
                if (usr != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int EditUser(UserDto model)
        {

            var user = _context.User.Single(u => u.User_ID == model.User_ID);

            user.UserName = model.UserName;
            user.Email = model.Email;
            if (model.Password != null)
            {
                user.Password = model.Password;
                user.ConfirmPassword = model.ConfirmPassword;
            }
            if (model.Image != null)
            {
                user.Image = "/images/" + model.Image;
            }
            user.Role = model.Role;

            _context.Update(user);

            return _context.SaveChanges();
        }
        public bool CheckEmail(string email)
        {
            var userEmail = _context.User.Where(u => u.Email == email).SingleOrDefault();
            if (userEmail != null)
                return true;
            else
                return false;
        }

        public bool CheckUserName(string username)
        {
            var user = _context.User.Where(u => u.UserName == username).SingleOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }

        public int UserId(string Username)
        {
            var usr = _context.User.Single(u => u.UserName == Username);
            return usr.User_ID;
        }

        public UserDto UserInfo(int userid)
        {
            var model = _context.User.Single(c => c.User_ID == userid);

            var user = new UserDto()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword,
                Image = model.Image,
                Role = model.Role


            };
            return user;
        }

        public string UploadedFileUser(UserDto content)
        {
            string uniqueFileName = null;

            if (content.FrontImage != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + content.FrontImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    content.FrontImage.CopyTo(fileStream);
                }
            }

            string PathUniqueFileName = uniqueFileName;

            return PathUniqueFileName;
        }

        public IEnumerable<PageDto> GetListOfFollowedPages(int id)
        {
            var FollowPage = _context.Patrons.Where(u => u.UserID == id).Select(x => x.Page).ToList();

            List<PageDto> p = new List<PageDto>();


            foreach (var item in FollowPage)
            {
                List<CreateContentDto> pts = new List<CreateContentDto>();
                PageDto pagedtoNew = new PageDto
                {
                    Page_ID = item.Page_ID,
                    PageName = item.PageName,
                    CreatingWhat = item.CreatingWhat,
                    IsAreCreating = item.IsAreCreating,
                    AboutPage = item.AboutPage,
                    ProfileImage = item.ProfileImage,
                    posts = pts,
                };

                var dasd = _context.PageContents.Where(p => p.Page_ID == pagedtoNew.Page_ID).ToList();

                foreach (var item2 in dasd)
                {
                    CreateContentDto content = new CreateContentDto
                    {
                        Content_ID = item2.Content_ID,
                        Title = item2.Title,
                        MainContent = item2.MainContent,
                        Image = item2.Image,
                        PublicationData = item2.PublicationData,
                        Active = item2.Active,
                        Page_ID = item.Page_ID
                    };

                    pts.Add(content);
                }

                p.Add(pagedtoNew);

            }

            return p;
        }

        #endregion

        #region page
        public int CreatePage(string username)
        {
            string profileImage = "/imgs/ProfilePage.png";
            string CoverImage = "/imgs/CoverPage.jpeg";

            var user = _context.User.Single(u => u.UserName == username);

            var newPage = new Page()
            {
                PageName = username,
                ProfileImage = profileImage,
                CoverImage = CoverImage,
                active = false,
                PageCreationData = DateTime.Now,
                User_ID = user.User_ID,
            };

            _context.Page.Add(newPage);

            return _context.SaveChanges();
        }

        public int EditPage(PageEditDto model)
        {
            var page = _context.Page.Single(u => u.Page_ID == model.Page_ID);

            page.PageName = model.PageName;
            page.CreatingWhat = model.CreatingWhat;
            page.IsAreCreating = model.IsAreCreating;
            if (model.ProfileImage != null)
            {
                page.ProfileImage = model.ProfileImage;
            }
            if (model.CoverImage != null)
            {
                page.CoverImage = model.CoverImage;
            }
            page.AboutPage = model.AboutPage;



            _context.Update(page);

            return _context.SaveChanges();
        }

        public int LaunchPage(int pageid)
        {
            var page = _context.Page.Single(u => u.Page_ID == pageid);

            page.active = true;

            _context.Update(page);

            return _context.SaveChanges();
        }

        public bool CheckPageName(string pagename, int id)
        {
            var name = _context.Page.Where(n => n.Page_ID == id).SingleOrDefault();
            var user = _context.Page.Where(u => u.PageName == pagename).SingleOrDefault();
            if (user != null)
            {
                if (pagename.ToLower() == name.PageName.ToLower())
                {
                    return false;
                }
                return true;
            }

            else
                return false;
        }

        public int PageIdWithPageName(string pagename)
        {
            var usr = _context.Page.Single(u => u.PageName == pagename);
            return usr.Page_ID;
        }

        public int PageId(int userid)
        {
            var usr = _context.Page.Single(u => u.User_ID == userid);
            return usr.Page_ID;
        }

        public int PatronsCount(int pageid)
        {
            var numberOfFollowers = _context.Patrons.Where(u => u.Page_ID == pageid).Count();

            return numberOfFollowers;
        }

        public PageEditDto PageInfo(int pageid)
        {
            var model = _context.Page.Single(c => c.Page_ID == pageid);

            var page = new PageEditDto()
            {
                PageName = model.PageName,
                CreatingWhat = model.CreatingWhat,
                IsAreCreating = model.IsAreCreating,
                ProfileImage = model.ProfileImage,
                CoverImage = model.CoverImage,
                AboutPage = model.AboutPage
            };
            return page;
        }

        #region Follows
        public int Follow(PatronFollowerDto model)
        {
            var follow = new Patrons()
            {
                UserID = model.UserID,
                Page_ID = model.Page_ID,
            };

            _context.Patrons.Add(follow);

            return _context.SaveChanges();
        }

        public int UnFollow(PatronFollowerDto model)
        {
            var f = _context.Patrons.SingleOrDefault(u => u.UserID == model.UserID && u.Page_ID == model.Page_ID);

            _context.Patrons.Remove(f);

            return _context.SaveChanges();
        }

        public bool IsFollow(int userid, int pageid)
        {
            var f = _context.Patrons.Where(u => u.UserID == userid && u.Page_ID == pageid);
            if (f.Count() > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region file upload
        public string UploadedpageProfilePhoto(PageEditDto content)
        {
            string uniqueFileName = null;

            if (content.FrontImageProfile != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + content.FrontImageProfile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    content.FrontImageProfile.CopyTo(fileStream);
                }

                string PathUniqueFileName = "/images/" + uniqueFileName;

                return PathUniqueFileName;
            }

            return null;
        }

        public string UploadedpageCoverPhoto(PageEditDto content)
        {
            string uniqueFileName = null;

            if (content.FrontImageCover != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + content.FrontImageCover.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    content.FrontImageCover.CopyTo(fileStream);
                }

                string PathUniqueFileName = "/images/" + uniqueFileName;

                return PathUniqueFileName;
            }

            return null;
        }
        #endregion

        #region list of pages
        public IEnumerable<PageDto> GetListOfPages()
        {
            var searchedUser = _context.Page.ToList().Where(u => u.active == true);

            List<PageDto> p = new List<PageDto>();

            foreach (var item in searchedUser)
            {
                List<CreateContentDto> pts = new List<CreateContentDto>();
                PageDto pagedtoNew = new PageDto
                {
                    Page_ID = item.Page_ID,
                    PageName = item.PageName,
                    CreatingWhat = item.CreatingWhat,
                    IsAreCreating = item.IsAreCreating,
                    AboutPage = item.AboutPage,
                    ProfileImage = item.ProfileImage,
                    posts = pts,
                };

                p.Add(pagedtoNew);

            }

            return p.ToList();
        }

        public IEnumerable<PageDto> GetListOfSearchedPages(string search)
        {
            var s = search.ToLower();
            var searchedPage = _context.Page.Where(u => u.PageName.ToLower().Contains(s) && u.active == true).Take(5).ToList();

            List<PageDto> p = new List<PageDto>();


            foreach (var item in searchedPage)
            {
                List<CreateContentDto> pts = new List<CreateContentDto>();
                PageDto pagedtoNew = new PageDto
                {
                    Page_ID = item.Page_ID,
                    PageName = item.PageName,
                    CreatingWhat = item.CreatingWhat,
                    IsAreCreating = item.IsAreCreating,
                    active = item.active,
                    AboutPage = item.AboutPage,
                    ProfileImage = item.ProfileImage,
                    posts = pts,
                };

                p.Add(pagedtoNew);

            }


            return p.ToList();
        }
        #endregion

        #endregion

        #region Content
        public int CreateContent(CreateContentDto model)
        {
            var newContent = new PageContent
            {
                Title = model.Title,
                MainContent = model.MainContent,
                Image = model.Image,
                AutoActive = false,
                Active = true,
                Deleted = false,
                PublicationData = DateTime.Now,
                Page_ID = model.Page_ID,
            };

            _context.PageContents.Add(newContent).Context.SaveChanges();

            var newPostHistory = new PostHistory
            {
                Title = newContent.Title,
                MainContent = newContent.MainContent,
                Image = newContent.Image,
                Active = true,
                Deleted = false,
                PublicationData = DateTime.Now,
                DateOfChange = DateTime.Now,
                page_id = newContent.Page_ID,
                PageContent_ID = newContent.Content_ID,
            };

            _context.PostHistory.Add(newPostHistory);

            return _context.SaveChanges();
        }

        public int EditContent(CreateContentDto model)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == model.Content_ID);

            if (model.Active != null)
            {
                post.Active = (bool)model.Active;
            }
            else
            {
                post.Title = model.Title;
                post.MainContent = model.MainContent;
                if (model.Image != null)
                {
                    post.Image = model.Image;
                }

                var newPostHistory = new PostHistory
                {
                    Title = model.Title,
                    MainContent = model.MainContent,
                    Image = model.Image,
                    //Deleted = post.Deleted,
                    Active = post.Active,
                    PublicationData = post.PublicationData,
                    DateOfChange = DateTime.Now,
                    page_id = post.Page_ID,
                    PageContent_ID = model.Content_ID,
                };

                _context.PostHistory.Add(newPostHistory);

            }

            _context.Update(post);

            return _context.SaveChanges();
        }

        public int DeleteContent(int contentid)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == contentid);

            post.Deleted = true;

            _context.Update(post);

            return _context.SaveChanges();
        }

        public int ActiveDesactiveContent(int contentid, bool active)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == contentid);

            if (active == true)
                post.Active = true;
            else
                post.Active = false;

            _context.Update(post);

            return _context.SaveChanges();
        }

        public string UploadedFile(CreateContentDto content)
        {
            string uniqueFileName = null;

            if (content.FrontImage != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + content.FrontImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    content.FrontImage.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        public CreateContentDto ContentInfo(int Contentid)
        {
            var model = _context.PageContents.Single(c => c.Content_ID == Contentid);

            var post = new CreateContentDto()
            {
                Title = model.Title,
                MainContent = model.MainContent,
                Image = model.Image,
                Active = model.Active

            };
            return post;
        }

        #region content list
        public IEnumerable<CreateContentDto> ContentList(int pageid)
        {
            var contentList = _context.PageContents.ToList().Where(c => c.Page_ID == pageid && c.Deleted == false && c.Active == true).OrderByDescending(u => u.PublicationData);

            List<CreateContentDto> c = new List<CreateContentDto>();

            foreach (var item in contentList)
            {
                CreateContentDto content = new CreateContentDto
                {
                    Content_ID = item.Content_ID,
                    Title = item.Title,
                    MainContent=item.MainContent,
                    Image=item.Image,
                    PublicationData = item.PublicationData,
                    Active = item.Active,
                    AutoActive = item.AutoActive,
                    Page_ID = item.Page_ID,
                };

                c.Add(content);

            }

            return c.ToList();
        }

        public IEnumerable<CreateContentDto> ContentListManage(int pageid)
        {
            var contentList = _context.PageContents.ToList().Where(c => c.Page_ID == pageid && c.Deleted == false).OrderByDescending(u => u.PublicationData);

            List<CreateContentDto> c = new List<CreateContentDto>();

            foreach (var item in contentList)
            {
                CreateContentDto content = new CreateContentDto
                {
                    Content_ID = item.Content_ID,
                    Title = item.Title,
                    MainContent = item.MainContent,
                    Image = item.Image,
                    PublicationData = item.PublicationData,
                    Active = item.Active,
                    AutoActive = item.AutoActive,
                    Page_ID = item.Page_ID,
                };

                c.Add(content);

            }

            return c.ToList();
        }
        #endregion

        #region content history
        public int UpdateHistoryContent(int PostToEdit_id, int PostHistory_id)
        {
            var postToEdit = _context.PageContents.Find(PostToEdit_id);

            var postHistory = _context.PostHistory.Find(PostHistory_id);

            postToEdit.Title = postHistory.Title;
            postToEdit.MainContent = postHistory.MainContent;
            postToEdit.Image = postHistory.Image;
            postToEdit.Active = postHistory.Active;
            postToEdit.PublicationData = postHistory.PublicationData;

            _context.Update(postToEdit);

            return _context.SaveChanges();
        }

        public IEnumerable<PostHistoryDto> GetContentHistoryList(int contend_id)
        {
            var postsHistory = _context.PostHistory.Where(u => u.PageContent_ID == contend_id).OrderBy(u => u.PublicationData);

            List<PostHistoryDto> c = new List<PostHistoryDto>();

            foreach (var item in postsHistory)
            {
                PostHistoryDto ph = new PostHistoryDto
                {
                    PostHistory_ID = item.PostHistory_ID,
                    Title = item.Title,
                    MainContent = item.MainContent,
                    Image = item.Image,
                    Active = item.Active,
                    PublicationData = item.PublicationData,
                    DateOfChange = item.DateOfChange,
                    PageContent_ID = item.PageContent_ID
                };

                c.Add(ph);
            }

            return c.ToList();
        }
        #endregion

        #endregion

        #region timer
        public int PostContentOnTimer(CreateContentDto model)
        {
            var newContent = new PageContent
            {
                Title = model.Title,
                MainContent = model.MainContent,
                Image = model.Image,
                AutoActive = true,
                Active = false,
                Deleted = false,
                PublicationData = model.PublicationData,
                Page_ID = model.Page_ID,
            };

            _context.PageContents.Add(newContent).Context.SaveChanges();

            var newPostHistory = new PostHistory
            {
                Title = newContent.Title,
                MainContent = newContent.MainContent,
                Image = newContent.Image,
                Active = false,
                Deleted = false,
                PublicationData = model.PublicationData,
                DateOfChange = DateTime.Now,
                page_id = newContent.Page_ID,
                PageContent_ID = newContent.Content_ID,
            };

            _context.PostHistory.Add(newPostHistory);

            return _context.SaveChanges();
        }

        public IEnumerable<CreateContentDto> ListOfContentsForTimer()
        {
            var c = _context.PageContents.Where(s => s.AutoActive == true);
            List<CreateContentDto> listOfContents = new List<CreateContentDto>();
            foreach (var item in c)
            {
                CreateContentDto contents = new CreateContentDto
                {
                    Content_ID = item.Content_ID,
                    Title = item.Title,
                    MainContent = item.MainContent,
                    Image = item.Image,
                    Active = item.Active,
                    PublicationData = item.PublicationData,
                    Page_ID = item.Page_ID,
                };
                listOfContents.Add(contents);
            }
            return listOfContents.ToList();
        }

        public int ActiveContentForTimer(int contentid)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == contentid);

            post.Active = true;
            post.AutoActive = false;

            _context.Update(post);

            return _context.SaveChanges();
        }

        #endregion

        #region comments
        public int AddComment(CommentsDto model)
        {
            var newComment = new ContentComments()
            {
                CommentText = model.CommentText,
                User_ID = model.User_id,
                CommentData = DateTime.Now,
                Content_ID = model.Content_ID
            };

            _context.ContentComments.Add(newComment);

            return _context.SaveChanges();
        }
        public IEnumerable<CommentsListDto> CommentsList(int contentid)
        {
            var Comments = _context.ContentComments.Where(u => u.Content_ID == contentid);

            List<CommentsListDto> c = new List<CommentsListDto>();

            foreach (var item in Comments)
            {
                var user = _context.User.SingleOrDefault(u => u.User_ID == item.User_ID);
                CommentsListDto comments = new CommentsListDto
                {
                    CommentText = item.CommentText,
                    CommentData = item.CommentData,
                    UserName = user.UserName,
                    UserImage = user.Image
                };

                c.Add(comments);
            }

            return c.ToList();
        }
        #endregion
                
    }
}
