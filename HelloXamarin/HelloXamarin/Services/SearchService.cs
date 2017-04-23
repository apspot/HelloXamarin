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
            new Search { Id = 2, Location = "Dunakeszi, Hungary", CheckIn = DateTime.Parse("2017-04-10"), CheckOut = DateTime.Parse("2017-04-20") }
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
