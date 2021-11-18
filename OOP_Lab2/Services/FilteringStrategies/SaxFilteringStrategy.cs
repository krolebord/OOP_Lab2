using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using OOP_Lab2.Helpers;
using OOP_Lab2.Models;

namespace OOP_Lab2.Services.FilteringStrategies
{
    public class SaxFilteringStrategy : IAppFilteringStrategy
    {
        public List<App> GetFiltered(string xmlPath, AppsFilter filter)
        {
            using var reader = new XmlTextReader(xmlPath);

            var result = new List<App>();

            while (reader.Read())
            {
                if (reader.LocalName != "App" || reader.NodeType != XmlNodeType.Element)
                    continue;

                var app = AppsConverter.XmlToApp(reader.ReadOuterXml());

                if (!string.IsNullOrWhiteSpace(filter.Name) && !app.Name.Contains(filter.Name, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(filter.Developer) && !app.Developers.Contains(filter.Developer, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(filter.Publisher) && !app.Publishers.Contains(filter.Publisher, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                if (filter.IsFree && app.Price != 0)
                {
                    continue;
                }

                if (filter.MaxConcurrentUsers > 0 && app.ConcurrentUsers > filter.MaxConcurrentUsers)
                {
                    continue;
                }

                if (filter.MinOwners > 0)
                {
                    if (int.TryParse(app.Owners.Split(' ').First().Replace(",", ""), out var owners) && owners < filter.MinOwners)
                        continue;
                }

                if (filter.MinScore > 0 || filter.MaxScore < 100)
                {
                    var score = Math.Round((double)app.PositiveReviews / (app.PositiveReviews + app.NegativeReviews) * 100);

                    if (score < filter.MinScore || score > filter.MaxScore)
                        continue;
                }

                result.Add(app);
            }

            return result;
        }
    }
}
