﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPDVIDebugging
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FunkyNameBuilder()
        {
            string output = "";
            for(int i = 0; i<=FirstName.Length; i++)
            {
                if(i%2 == 0)
                {
                    output += FirstName.Substring(i, 1);
                }
                else
                {
                    output += FirstName.Substring(i, 1).ToUpper();
                }
            }
            return output;
        }
    }
}
