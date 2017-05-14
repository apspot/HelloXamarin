using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Services
{
    public class SearchService
    {
        private List<Search> _searches = new List<Search>()
        {
            new Search { Id = 0, Location = "Budapest, Hungary", CheckIn = DateTime.Parse("2017-01-01"), CheckOut = DateTime.Parse("2017-01-10") },
            new Search { Id = 1, Location = "Wien, Austria", CheckIn = DateTime.Parse("2017-03-01"), CheckOut = DateTime.Parse("2017-03-07") },
            new Search { Id = 2, Location = "Dunakeszi, Hungary", CheckIn = DateTime.Parse("2017-04-10"), CheckOut = DateTime.Parse("2017-04-20") },
            new Search { Id = 3, Location = "Bucharest, Romania", CheckIn = DateTime.Parse("2017-05-01"), CheckOut = DateTime.Parse("2017-05-03") },
            new Search { Id = 4, Location = "Bratislava, Slovakia", CheckIn = DateTime.Parse("2017-02-09"), CheckOut = DateTime.Parse("2017-02-15") },
            new Search { Id = 5, Location = "Berlin, Germany", CheckIn = DateTime.Parse("2017-04-17"), CheckOut = DateTime.Parse("2017-04-25") },
            new Search { Id = 6, Location = "Beijing, China", CheckIn = DateTime.Parse("2017-04-26"), CheckOut = DateTime.Parse("2017-04-30") },
            new Search { Id = 7, Location = "Belgrade, Serbia", CheckIn = DateTime.Parse("2017-03-24"), CheckOut = DateTime.Parse("2017-03-29") },
            new Search { Id = 8, Location = "Bern, Switzerland", CheckIn = DateTime.Parse("2017-02-11"), CheckOut = DateTime.Parse("2017-02-27") },
            new Search { Id = 9, Location = "Brussels, Belgium", CheckIn = DateTime.Parse("2017-01-20"), CheckOut = DateTime.Parse("2017-01-27") },
        };

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return _searches;
            return _searches.Where(s => s.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        public void DeleteSearch(int searchId)
        {
            _searches.Remove(_searches.Single(s => s.Id == searchId));
        }
    }
}
