using DataBase;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {        
        public int RegisterUser(UserDto model);
        public int CreatePage(string username);
        public int DeleteContent(int contentid);
        public int ActiveDesactiveContent(int contentid, bool active);
        public int Follow(PatronFollowerDto model);
        public int UnFollow(PatronFollowerDto model);
        public bool CheckUserName(string username);
        public bool CheckPageName(string pagename, int id);
        public bool CheckEmail(string email);
        public int AddComment(CommentsDto model);
        public IEnumerable<CommentsListDto> CommentsList(int contentid);
        public int PatronsCount(int pageid);
        public bool LoginUser(UserDto model);
        public bool IsFollow(int userid, int pageid);
        public int EditUser(UserDto model);
        public int EditPage(PageEditDto model);
        public int LaunchPage(int pageid);
        public int CreateContent(CreateContentDto model);
        public int PostContentOnTimer(CreateContentDto model);
        public IEnumerable<CreateContentDto> ListOfContentsForTimer();
        public int ActiveContentForTimer(int contentid);
        public int EditContent(CreateContentDto model);
        public int UpdateHistoryContent(int PostToEdit_id, int PostHistory_id);
        public IEnumerable<PostHistoryDto> GetContentHistoryList(int contend_id);
        public string UploadedFile(CreateContentDto content);
        public string UploadedFileUser(UserDto content);
        public string UploadedpageProfilePhoto(PageEditDto content);
        public string UploadedpageCoverPhoto(PageEditDto content);
        public int UserId(string Username);
        public int PageId(int userid);
        public int PageIdWithPageName(string pagename);
        public UserDto UserInfo(int userid);
        public PageEditDto PageInfo(int pageid);
        public CreateContentDto ContentInfo(int Contentid);
        public IEnumerable<CreateContentDto> ContentList(int pageid);
        public IEnumerable<CreateContentDto> ContentListManage(int pageid);
        public IEnumerable<PageDto> GetListOfPages();
        public IEnumerable<PageDto> GetListOfSearchedPages(string search);
        public IEnumerable<PageDto> GetListOfFollowedPages(int id);
    }
}
