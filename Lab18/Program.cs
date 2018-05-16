﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
          
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddToEnd("Danny");
            list.AddToEnd("Jaide");
            list.RemoveAll("Cat");
            list.PrintAllNodes();
            
        }
    }
}
