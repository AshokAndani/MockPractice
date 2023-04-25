using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}  Name: {Name}   Email:  {Email}     Location: {Location}";
        }
    }
}
