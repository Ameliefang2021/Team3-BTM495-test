﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Accountant : Employee
    {

        public Accountant(int eID, string n, DateTime st, double s)
           : base(eID, n, st, s)
        {

        }
    }
}
