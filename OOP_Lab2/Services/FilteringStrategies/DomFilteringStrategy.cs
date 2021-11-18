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

            var result = new List<App>();

            result = doc.DocumentElement?.ChildNodes
                .Cast<XmlNode>()
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Name))
                        return true;
                    var propNode = node.SelectSingleNode("name");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Name, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Developer))
                        return true;
                    var propNode = node.SelectSingleNode("developer");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Developer, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (string.IsNullOrWhiteSpace(filter.Publisher))
                        return true;
                    var propNode = node.SelectSingleNode("publisher");
                    return propNode is not null
                           && propNode.InnerText.Contains(filter.Publisher, StringComparison.InvariantCultureIgnoreCase);
                })
                .Where(node =>
                {
                    if (!filter.IsFree)
                        return true;
                    var propNode = node.SelectSingleNode("price");
                    return propNode is not null
                           && propNode.InnerText == "0";
                })
                .Where(node =>
                {
                    if (filter.MinOwners == 0)
                        return true;

                    var propNode = node.SelectSingleNode("owners");
                    if (propNode is null || !int.TryParse(propNode.InnerText.Split(' ').First().Replace(",", ""), out var owners))
                        return true;

                    return filter.MinOwners <= owners;
                })
                .Where(node =>
                {
                    if (filter.MaxConcurrentUsers == 0)
                        return true;

                    var propNode = node.SelectSingleNode("ccu");
                    if (propNode is null || !int.TryParse(propNode.InnerText, out var ccu))
                        return true;

                    return filter.MaxConcurrentUsers >= ccu;
                })
                .Where(node =>
                {
                    if (filter.MinScore == 0 && filter.MaxScore == 100)
                        return true;

                    var posNode = node.SelectSingleNode("positive");
                    var negNode = node.SelectSingleNode("negative");
                    if (posNode is null || negNode is null
                                        || !int.TryParse(posNode.InnerText, out var pos)
                                        || !int.TryParse(negNode.InnerText, out var neg))
                        return true;

                    var score = Math.Round((double)pos / (pos + neg) * 100);
                    return filter.MinScore <= score && score <= filter.MaxScore;
                })
                .Select(node => AppsConverter.XmlToApp(node.OuterXml))
                .ToList();

            return result;
        }
    }
}
