using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class Staff
    {
        int staffID;

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string account;

        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        bool isManager;

        public bool IsManager
        {
            get { return isManager; }
            set { isManager = value; }
        }
    }
}
