using System;
using System.Collections.Generic;

namespace Лаб5
{
    /// <summary>
    /// Класс Administraror, хранит пользоветелей,
    /// может выводить информацию о доступных пользователю сервисах
    /// </summary>
    class Administraror
    {
        List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void ShowUsersRights()
        {
            foreach (User u in users)
            {
                Console.WriteLine(u.Name + ":");
                u.GetMusic();
                u.GetVideo();
                u.AddMusic();
                u.AddVideo();
            }
        }
        public void ShowNumberOfUsers()
        {
            Console.WriteLine("Количество пользователей: " + users.Count);
        }
    }
}
