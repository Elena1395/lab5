using System;
using System.IO;
using System.Collections.Generic;

namespace Лаб5
{
    class Program
    {
        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        /// <remarks>
        /// Читает входной файл input.txt и выводит доступные пользователю сервисы.
        /// </remarks>
        static void Main(string[] args)
        {
            Administrator admin = new Administrator();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null && line.Replace(" ", "") != "")
                    {
                        String[] elem = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (elem.Length == 2)
                        {
                            admin.AddUser(new AuthorizedUser(elem[0], elem[1]));
                        }
                        else if (elem.Length == 1 && elem[0].ToLower() == "guest")
                        {
                            admin.AddUser(new Guest());
                        }
                        else
                        {
                            throw new ArgumentException("Некорректная информация о пользоветеле");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"Файл input.txt не удалось найти");
                Console.ReadKey();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            admin.ShowNumberOfUsers();
            admin.ShowUsersRights();

            Console.ReadKey();
        }
    }
}
