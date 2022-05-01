using DataBase;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<User> GetListOfSearchedUsers(string search);
        public int RegisterUser(UserDto model);
        public int CreatePage(string username);
        public bool LoginUser(UserDto model);
        public int EditUser(UserDto model);
        public int EditPage(PageEditDto model);
        public int CreateContent(CreateContentDto model);
        public string UploadedFile(CreateContentDto content);
        public string UploadedFileUser(UserDto content);
        public string UploadedpageProfilePhoto(PageEditDto content);
        public string UploadedpageCoverPhoto(PageEditDto content);
        public int UserId(string Username);
        public int PageId(int userid);
        public UserDto UserInfo(int userid);
        public PageEditDto PageInfo(int pageid);
        public IEnumerable<PageContent> ContentList(int userid);
    }
}
