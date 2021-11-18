using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using OOP_Lab2.Models;

namespace OOP_Lab2.Helpers
{
    public static class AppsConverter
    {
        public static XDocument AppsToXml(List<App> apps)
        {
            var doc = new XDocument();

            var appsElement = new XElement("Apps", apps.Select(
                app => new XElement("App", new List<XElement>
                {
                    new("appid", app.AppId),
                    new("name", app.Name),
                    new("developer", app.Developers),
                    new("publisher", app.Publishers),
                    new("positive", app.PositiveReviews),
                    new("negative", app.NegativeReviews),
                    new("owners", app.Owners),
                    new("price", app.Price),
                    new("ccu", app.ConcurrentUsers),
                })));

            doc.Add(appsElement);

            return doc;
        }

        public static App XmlToApp(string xml)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(xml);
            writer.Flush();
            stream.Position = 0;

            var serializer = new XmlSerializer(typeof(App));
            return serializer.Deserialize(stream) as App;
        }
    }
}
