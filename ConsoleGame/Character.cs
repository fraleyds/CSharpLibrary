﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public abstract class Character
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Marksmanship { get; set; }
        public int Piloting { get; set; }
        public int Energy { get; set; }
        public double Luck { get; set; }
    }
}