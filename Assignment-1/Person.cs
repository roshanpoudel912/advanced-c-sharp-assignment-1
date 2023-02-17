﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name= name;
            Age= age;
        }

        public Boolean IsAdult()
        {
            if(Age >= 18)
            {
                return true;
            }

            return false;

        }
    }
}
