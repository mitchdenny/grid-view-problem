using GridViewProblem.DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewProblem
{
    public class HubPageModel
    {
        public HubPageModel()
        {
            People = new ObservableCollection<Person>()
            {
                new Person() { FirstName = "Montgomery", LastName = "Burns" },
                new Person() { FirstName = "Lisa", LastName = "Simpson" },
                new Person() { FirstName = "Homer", LastName = "Simpson" },
                new Person() { FirstName = "Marg", LastName = "Simpson" },
                new Person() { FirstName = "Bart", LastName = "Simpson" }
            };

            Locations = new ObservableCollection<Location>()
            {
                new Location() { Description = "Nuclear Power Plant" },
                new Location() { Description = "Moe's Tavern" },
                new Location() { Description = "Springfield Elementary" },
                new Location() { Description = "Shelbyville" }
            };
        }

        public ObservableCollection<Person> People { get; set; }
        public ObservableCollection<Location> Locations { get; set; }
    }
}
