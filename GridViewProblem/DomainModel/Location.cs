using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewProblem.DomainModel
{
    public class Location
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
