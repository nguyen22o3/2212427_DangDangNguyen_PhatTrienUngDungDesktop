using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApss.Resources
{
    class Account
    {
        private string tenTK;
        private string matKhau;
        private int role;
        public Account()
        {

        }

        public Account(string accountName, string password, int roleID)
        {
            this.tenTK = accountName;
            this.matKhau = password;
            this.role = roleID;
        }

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Role { get => role; set => role = value; }
    }
}
