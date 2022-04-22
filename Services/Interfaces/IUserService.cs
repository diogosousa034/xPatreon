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
        public bool LoginUser(UserDto model);
        public int EditUser(UserDto model);
        public int CreateContent(CreateContentDto model);
        public string UploadedFile(CreateContentDto content);
        public string UploadedFileUser(UserDto content);
        public int UserId(string Username);
        public UserDto UserInfo(int userid);
        public IEnumerable<UserContent> ContentList(int userid);
    }
}
