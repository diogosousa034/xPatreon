﻿using DataBase;
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
        public int AddComment(CommentsDto model);
        public IEnumerable<ContentComments> CommentsList(int contentid);
        public int PatronsCount(int pageid);
        public bool LoginUser(UserDto model);
        public bool IsFollow(int userid, int pageid);
        public int EditUser(UserDto model);
        public int EditPage(PageEditDto model);
        public int LaunchPage(int pageid);
        public int CreateContent(CreateContentDto model);
        public int EditContent(CreateContentDto model);
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
        public IEnumerable<PageContent> ContentList(int pageid);
        public IEnumerable<PageContent> ContentListManage(int pageid);
        public IEnumerable<Page> GetListOfPages();
        public IEnumerable<Page> GetListOfSearchedPages(string search);
        public IEnumerable<PageDto> GetListOfFollowedPages(int id);
    }
}
