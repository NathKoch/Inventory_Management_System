using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class checkPermission
    {
        public string Login { get; set; }
        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Admin" : "User";

        public checkPermission(string login, bool isAdmin) 
        { 
            Login = login.Trim();
            IsAdmin = isAdmin;
        }

    }
}
