using System;

namespace Лаб5
{
    /// <summary>
    /// Класс AuthorizedUser, наследуется от User
    /// </summary>
    class AuthorizedUser : User
    {
        public string Login;
        public AuthorizedUser(string name, string login)
        {
            Name = name;
            Login = login;
        }
        public override void GetMusic()
        {
            Console.WriteLine("Music enabled");
        }
        public override void GetVideo()
        {
            Console.WriteLine("Video enabled");
        }
        public override void AddMusic()
        {
            Console.WriteLine("Music added");
        }
        public override void AddVideo()
        {
            Console.WriteLine("Video added");
        }
    }
}
