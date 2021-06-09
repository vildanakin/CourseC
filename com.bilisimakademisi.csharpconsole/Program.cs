using com.bilisimakademisi.csharp.console;
using System;

namespace com.bilisimakademisi.csharpconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User _user = new User();

            _user.UserId = 1;
            _user.fullName = "vildan.akin";

            Console.WriteLine(_user.fullName);

        }
    }
     
}
