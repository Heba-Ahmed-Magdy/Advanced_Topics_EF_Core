﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Mother
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Child Child { get; set; }
    }
}
