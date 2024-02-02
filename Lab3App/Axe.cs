﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description) : base(description) { }

        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }
    }
}