using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class UserManager
    {
        public IDatabaseService Service { get; }

        public UserManager(IDatabaseService service)
        {
            Service = service;
        }
        public bool AddNewUser(UserModel user)
        {
            return this.Service.AddUser(user);
        }
    }
}
