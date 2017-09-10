using System;
using System.Collections.Generic;

namespace Pwd_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager f1 = new FileManager();
            List<Domain> _list = new List<Domain>();
            _list.Add(new Domain("Google"));
            _list.Add(new Domain("Hotmail"));
            _list.Add(new Domain("Ankama"));

            f1.WriteDomains(_list);
            string patate = f1.ReadDomains();

            Domain d1 = new Domain("Google");
            d1.AddUser("test1", "test2"); d1.AddUser("test3", "test4");
            f1.WritePasswords(d1);
            Domain d2 = new Domain();
            d2 = f1.ReadPasswords("Google");

            Console.ReadKey();
        }
    }
}
