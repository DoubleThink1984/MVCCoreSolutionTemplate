﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Model
{
    public class Category
    {
        public Category()
        {
            DateCreated = DateTime.Now;
        }

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Gadget> Gadgets { get; set; }                
    }
}
