using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using OOP_Lab2.Helpers;
using OOP_Lab2.Models;

namespace OOP_Lab2.Services.FilteringStrategies
{
    public class DomFilteringStrategy : IAppFilteringStrategy
    {
        public List<App> GetFiltered(string xmlPath, AppsFilter filter)
        {
            var doc = new XmlDocument();
            doc.Load(xmlPath);

            var result = doc.DocumentElement?.ChildNodes
                .Cast<XmlNode>();

            if (result is null)
            {
                return new List<App>();
            }

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("name");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Name, StringComparison.InvariantCultureIgnoreCase);
                });
            }

            if (!string.IsNullOrWhiteSpace(filter.Developer))
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("developer");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Developer, StringComparison.InvariantCultureIgnoreCase);
                });
            }

            if (!string.IsNullOrWhiteSpace(filter.Publisher))
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("publisher");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Publisher, StringComparison.InvariantCultureIgnoreCase);
                });
            }

            if (filter.IsFree)
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("price");
                    return propNode is not null
                           && propNode.InnerText == "0";
                });
            }

            if (filter.MinOwners != 0)
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("owners");
                    if (propNode is null || !int.TryParse(propNode.InnerText.Split(' ').First().Replace(",", ""), out var owners))
                        return true;

                    return filter.MinOwners <= owners;
                });
            }

            if (filter.MaxConcurrentUsers != 0)
            {
                result = result.Where(node =>
                {
                    var propNode = node.SelectSingleNode("ccu");
                    if (propNode is null || !int.TryParse(propNode.InnerText, out var ccu))
                        return true;

                    return filter.MaxConcurrentUsers >= ccu;
                });
            }

            if (filter.MinScore != 0 || filter.MaxScore != 100)
            {
                result = result.Where(node =>
                {
                    var posNode = node.SelectSingleNode("positive");
                    var negNode = node.SelectSingleNode("negative");
                    if (posNode is null || negNode is null
                                        || !int.TryParse(posNode.InnerText, out var pos)
                                        || !int.TryParse(negNode.InnerText, out var neg))
                        return true;

                    var score = Math.Round((double)pos / (pos + neg) * 100);
                    return filter.MinScore <= score && score <= filter.MaxScore;
                });
            }

            return result
                .Select(node => AppsConverter.XmlToApp(node.OuterXml))
                .ToList();
        }
    }
}
