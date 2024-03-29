﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewProblem.DomainModel
{
    public class Person : ITile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", LastName, FirstName);
        }

        public string Title
        {
            get { return LastName; }
        }

        public string Subtitle
        {
            get { return FirstName; }
        }
    }
}
