﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirt
{
    class SCompare:IComparer<Employee>
    {
       

        public int Compare(Employee x, Employee y)
        {
            //throw new NotImplementedException();
            return (x.Salary.CompareTo(y.Salary));
        }
    }
}
