using System.Collections.Generic;
using OOP_Lab2.Models;

namespace OOP_Lab2.Services
{
    public interface IAppFilteringStrategy
    {
        public List<App> GetFiltered(string xmlPath, AppsFilter filter);
    }
}
