using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface IDatabaseService
    {
        bool AddUser(UserModel user);
    }
    public class DatabaseService : IDatabaseService
    {
        public bool AddUser(UserModel model)
        {
            if (!File.Exists("D:/Users.txt"))
            {
                var stream = File.Create("D:/Users.txt");
                stream.Close();
            }

            File.AppendAllText("D:/Users.txt", model.ToString());
            return true;
        }
    }
}
