using System;
using System.Xml.Serialization;

namespace OOP_Lab2.Models
{
    [Serializable, XmlRoot("App", IsNullable = true)]
    public class App
    {
        [XmlElement("appid")]
        public int AppId { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("developer")]
        public string Developers { get; set; }

        [XmlElement("publisher")]
        public string Publishers { get; set; }

        [XmlElement("positive")]
        public int PositiveReviews { get; set; }

        [XmlElement("negative")]
        public int NegativeReviews { get; set; }

        [XmlElement("price")]
        public int Price { get; set; }

        [XmlElement("ccu")]
        public int ConcurrentUsers { get; set; }

        [XmlElement("owners")]
        public string Owners { get; set; }
    }
}
