using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using OOP_Lab2.Helpers;
using OOP_Lab2.Models;

namespace OOP_Lab2.Services.FilteringStrategies
{
    public class LinqFilteringStrategy : IAppFilteringStrategy
    {
        public List<App> GetFiltered(string xmlPath, AppsFilter filter)
        {
            var doc = XDocument.Load(xmlPath);

            return doc.Root?
                .Elements("App")
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Name))
                        return true;
                    var propNode = node.Element("name");
                    return propNode is not null
                           && propNode.Value.Contains(filter.Name, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Developer))
                        return true;
                    var propNode = node.Element("developer");
                    return propNode is not null
                           && propNode.Value.Contains(filter.Developer, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Publisher))
                        return true;
                    var propNode = node.Element("publisher");
                    return propNode is not null
                           && propNode.Value.Contains(filter.Publisher, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (!filter.IsFree)
                        return true;
                    var propNode = node.Element("price");
                    return propNode is not null
                           && propNode.Value == "0";
                })
                .Where(node =>
                {
                    if (filter.MinOwners == 0)
                        return true;

                    var propNode = node.Element("owners");
                    if (propNode is null || !int.TryParse(propNode.Value.Split(' ').First().Replace(",", ""), out var owners))
                        return true;

                    return filter.MinOwners <= owners;
                })
                .Where(node =>
                {
                    if (filter.MaxConcurrentUsers == 0)
                        return true;

                    var propNode = node.Element("ccu");
                    if (propNode is null || !int.TryParse(propNode.Value, out var ccu))
                        return true;

                    return filter.MaxConcurrentUsers >= ccu;
                })
                .Where(node =>
                {
                    if (filter.MinScore == 0 && filter.MaxScore == 100)
                        return true;

                    var posNode = node.Element("positive");
                    var negNode = node.Element("negative");
                    if (posNode is null || negNode is null
                                        || !int.TryParse(posNode.Value, out var pos)
                                        || !int.TryParse(negNode.Value, out var neg))
                        return true;

                    var score = Math.Round((double)pos / (pos + neg) * 100);
                    return filter.MinScore <= score && score <= filter.MaxScore;
                })
                .Select(node => AppsConverter.XmlToApp(node.ToString()))
                .ToList();
        }
    }
}
