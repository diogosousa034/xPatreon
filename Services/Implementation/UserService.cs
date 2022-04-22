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
            var newUser = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword,
                Image = model.Image,
                Role = model.Role,
                RegistrationData = DateTime.Now,
            };

            _context.User.Add(newUser);
            return _context.SaveChanges();
        }

        public bool LoginUser(UserDto model)
        {
            var usr = _context.User.Single(u => u.UserName == model.UserName && u.Password == model.Password);
            if (usr != null)
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

        public int UserId(string Username)
        {
            var usr = _context.User.Single(u => u.UserName == Username);
            return usr.User_ID;
        }

        public IEnumerable<UserContent> ContentList(int userid)
        {
            var contentList = _context.UserContents.ToList().Where(c => c.User_ID == userid);
            return contentList;
        }

        public int CreateContent(CreateContentDto model)
        {
            var newContent = new UserContent
            {
                Title = model.Title,
                MainContent = model.MainContent,
                Image = model.Image,
                PublicationData = DateTime.Now,
                User_ID = model.User_ID,
            };

            _context.UserContents.Add(newContent);
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

        public IEnumerable<User> GetListOfSearchedUsers(string search)
        {
            var searchedUser = _context.User.ToList().Where(u => u.UserName.Contains(search)).Take(5);
            return searchedUser;
        }
    }
}
