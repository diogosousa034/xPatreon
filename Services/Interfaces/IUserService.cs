using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public int getNumberofUsers();
        public int RegisterUser(string Username, string email, string password, string confirm, string role);
        public bool LoginUser(string Username, string password);
        public int CreateContent(string Title, string mainContent, string Image, int Userid);
        //public void SaveImage(string Title);
        public int UserId(string Username);
        public IEnumerable<UserContent> ContentList(int userid);
    }
}
