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

        public int AddComment(CommentsDto model)
        {
            //var user = _context.PageContents.Single(u => u.Content_ID == model.Content_ID);

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

        //public IEnumerable<ContentComments> CommentsList(int contentid)
        //{
        //    var Comments = _context.ContentComments.Where(u => u.Content_ID == contentid);

        //    return Comments.ToList();
        //}


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

        public bool CheckUserName(string username)
        {
            var user = _context.User.Where(u => u.UserName == username).SingleOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }

        public bool CheckEmail(string email)
        {
            var userEmail = _context.User.Where(u => u.Email == email).SingleOrDefault();
            if (userEmail != null)
                return true;
            else
                return false;
        }

        public int PatronsCount(int pageid)
        {
            var numberOfFollowers = _context.Patrons.Where(u => u.Page_ID == pageid).Count();

            return numberOfFollowers;
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

        public bool IsFollow(int userid, int pageid)
        {
            var f = _context.Patrons.Where(u => u.UserID == userid && u.Page_ID == pageid);
            if (f.Count() > 0)
                return true;
            else
                return false;
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
            user.Image = model.Image;
            user.Role = model.Role;

            _context.Update(user);

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

        public int UserId(string Username)
        {
            var usr = _context.User.Single(u => u.UserName == Username);
            return usr.User_ID;
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

        public IEnumerable<PageContent> ContentList(int pageid)
        {
            var contentList = _context.PageContents.ToList().Where(c => c.Page_ID == pageid && c.Deleted == false && c.Active == true).OrderByDescending(u => u.PublicationData);
            return contentList;
        }

        public IEnumerable<PageContent> ContentListManage(int pageid)
        {
            var contentList = _context.PageContents.ToList().Where(c => c.Page_ID == pageid && c.Deleted == false).OrderByDescending(u => u.PublicationData);
            return contentList;
        }

        public int CreateContent(CreateContentDto model)
        {
            var newContent = new PageContent
            {
                Title = model.Title,
                MainContent = model.MainContent,
                Image = model.Image,
                Active = true,
                Deleted = false,
                PublicationData = DateTime.Now,
                Page_ID = model.Page_ID,
            };

            _context.PageContents.Add(newContent);
            return _context.SaveChanges();
        }

        public int EditContent(CreateContentDto model)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == model.Content_ID);

            post.Title = model.Title;
            post.MainContent = model.MainContent;
            if (model.Image != null)
            {
                post.Image = model.Image;
            }
            post.Active = model.Active;

            _context.Update(post);

            return _context.SaveChanges();
        }

        public int RemoveContent(int id)
        {
            var post = _context.PageContents.Single(u => u.Content_ID == id);

            post.Deleted = true;

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

            string PathUniqueFileName = "/images/" + uniqueFileName;

            return PathUniqueFileName;
        }

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

        public IEnumerable<Page> GetListOfPages()
        {
            var searchedUser = _context.Page.ToList().Where(u => u.active == true);

            //List<PageDto> p = new List<PageDto>();

            //foreach (var item in searchedUser)
            //{
            //    List<CreateContentDto> pts = new List<CreateContentDto>();
            //    PageDto pagedtoNew = new PageDto
            //    {
            //        Page_ID = item.Page_ID,
            //        PageName = item.PageName,
            //        CreatingWhat = item.CreatingWhat,
            //        IsAreCreating = item.IsAreCreating,
            //        AboutPage = item.AboutPage,
            //        ProfileImage = item.ProfileImage,
            //        posts = pts,
            //    };

            //    p.Add(pagedtoNew);

            //}

            return searchedUser;
        }

        public IEnumerable<Page> GetListOfSearchedPages(string search)
        {
            var s = search.ToLower();
            var searchedPage = _context.Page.Where(u => u.PageName.ToLower().Contains(s) && u.active == true).Take(5).ToList();

            //List<PageDto> p = new List<PageDto>();


            //foreach (var item in searchedPage)
            //{
            //    List<CreateContentDto> pts = new List<CreateContentDto>();
            //    PageDto pagedtoNew = new PageDto
            //    {
            //        Page_ID = item.Page_ID,
            //        PageName = item.PageName,
            //        CreatingWhat = item.CreatingWhat,
            //        IsAreCreating = item.IsAreCreating,
            //        AboutPage = item.AboutPage,
            //        ProfileImage = item.ProfileImage,
            //        posts = pts,
            //    };                

            //    p.Add(pagedtoNew);

            //}


            return searchedPage;
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
    }

    //public class PostDto
    //{

    //}

    //public class PageDto
    //{
    //    public int pageId;

    //    public List<PostDto> posts;
    //}
}
