using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAds
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(bool IsPremium)
        {
            Console.WriteLine(" Введите свое имя");
            Name = Console.ReadLine();
            Console.WriteLine(" Введите свой логин");
            Login = Console.ReadLine();
            this.IsPremium = IsPremium;
            Console.WriteLine("");
        }
    }
}
