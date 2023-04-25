namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserModel model = new UserModel()
            {
                Email = "user@gmail.com",
                Id = 1,
                Location = "BNGLR",
                Name = "Test",
            };

            UserManager userManager = new UserManager(new DatabaseService());
            userManager.AddNewUser(model);

            Console.WriteLine("User Added Successfully...!");

            Console.ReadLine();
        }
    }
}