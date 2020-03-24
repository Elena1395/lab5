using System;

namespace Лаб5
{
    /// <summary>
    /// Класс Guest, наследуется от User
    /// Играет роль NullObject
    /// </summary>
    class Guest : User
    {
        public Guest()
        {
            Name = "Guest";
        }
        public override void GetMusic()
        {
            Console.WriteLine("Music unavaliable");
        }
        public override void GetVideo()
        {
            Console.WriteLine("Video unavaliable");
        }
        public override void AddMusic()
        {
            Console.WriteLine("Music cannot be added");
        }
        public override void AddVideo()
        {
            Console.WriteLine("Video cannot be added");
        }
    }
}
