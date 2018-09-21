﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompAndDel
{
    public abstract class NamedObject
    {
        protected string name;
        public NamedObject(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
        }
        
        public override string ToString()
        {
            return this.name;
        }
    }
}
