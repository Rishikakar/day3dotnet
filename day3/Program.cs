using System;
using System.Collections.Generic;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository ur = new UserRepository();
            List<User> userlist = ur.Users();
            Console.WriteLine("Details of the Users");
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in userlist)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.Isactive);
            }


            Console.WriteLine("Enter a id to find a User");
            int gid = int.Parse(Console.ReadLine());
            User u1 = ur.GetUser(gid);
            if (u1 != null)
            {
                Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
                Console.WriteLine(u1.Id + "\t" + u1.Name + "\t" + u1.Email + "\t" + u1.Location + "\t" + u1.Address + "\t" + u1.Isactive);

            }
            else
            {
                Console.WriteLine("No users found at the entered position");
            }

            Console.WriteLine("Enter a specefic id to Delete a User");
            int did = int.Parse(Console.ReadLine());
            List<User> ul1 = ur.DeleteUser(did);
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in ul1)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.Isactive);
            }

            Console.WriteLine("Enter a specefic id to find the active User");
            List<User> ul2 = ur.ActiveUser();
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in ul2)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.Isactive);

            }

            Console.WriteLine("Enter user details");
            Console.WriteLine("Enter user name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter user email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter user location");
            string location = Console.ReadLine();

            Console.WriteLine("Enter user address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter user isactive status");
            int isactive = int.Parse(Console.ReadLine());

            ur.AddUser(new User()
            {
                Id = ur.userid,
                Name = name,
                Email = email,
                Location = location,
                Address = address,
                Isactive = isactive
            });

        }
    }
    }
