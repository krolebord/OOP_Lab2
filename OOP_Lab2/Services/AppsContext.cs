using System.Collections.Generic;
using OOP_Lab2.Models;

namespace OOP_Lab2.Services
{
    public class AppsContext
    {
        public IAppFilteringStrategy Strategy { get; set; }

        public List<App> GetFilteredApps(string xmlPath, AppsFilter filter)
        {
            return Strategy.GetFiltered(xmlPath, filter);
        }
    }
}
