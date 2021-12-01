using System.Collections.Generic;
using App.Models;


namespace App.Areas.Identity.Models.UserViewModels
{
    public class UserListModel
    {
        public int totalUsers { get; set; }
        public int countPages { get; set; }

        public int ITEMS_PER_PAGE { get; set; } = 10;

        public int currentPage { get; set; }

        public List<UserAndRole> users { get; set; }

    }

    public class UserAndRole : AppUser
    {
        public string RoleNames { get; set; }

        private string id;

        public string GetId()
        {
            return id;
        }

        internal void SetId(string value)
        {
            id = value;
        }

        private string userName;

        public string GetUserName()
        {
            return userName;
        }

        internal void SetUserName(string value)
        {
            userName = value;
        }
    }


}