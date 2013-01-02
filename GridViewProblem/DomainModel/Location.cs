using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewProblem.DomainModel
{
    public class Location : ITile
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }

        public string Title
        {
            get { return Description; }
        }

        public string Subtitle
        {
            get { return Description; }
        }
    }
}
