﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student("Steve", "Aldworth");
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}