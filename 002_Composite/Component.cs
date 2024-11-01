﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Composite
{
    public abstract class Component
    {
        public string Name { get; set; } = string.Empty;

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);



    }
}
