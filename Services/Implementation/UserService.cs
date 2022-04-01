using DataBase;
using Microsoft.AspNetCore.Http;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Implementation
{
    public class UserService : IUserService
    {
        private xPatreonDbContext _context;

        public UserService(xPatreonDbContext context) {
            _context = context;
        }

        public int RegisterUser(string Username, string email, string password, string confirm, string role)
        {
            User newUser = new User
            {
                UserName = Username,
                Email = email,
                Password = password,
                ConfirmPassword = confirm,
                Role = role
            };

            _context.User.Add(newUser);
            return _context.SaveChanges();
        }

        public bool LoginUser(string Username, string password)
        {
            var usr = _context.User.Single(u => u.UserName == Username && u.Password == password);
            if(usr != null)
                return true;
            else
                return false;

        }

        public int UserId(string Username)
        {
            var usr = _context.User.Single(u => u.UserName == Username);           
            return usr.User_ID;
        }


        public int CreateContent(string Title, string mainContent, string Image, int Userid)
        {
            UserContent newContent = new UserContent
            {
                Title = Title,
                MainContent = mainContent,
                Image = Image,
                User_ID = Userid,
            };

            _context.UserContents.Add(newContent);
            return _context.SaveChanges();
        }

        public int getNumberofUsers()
        {
            return _context.User.Count();
        }
    }
}
