using System;
using System.Xml.Serialization;

namespace OOP_Lab2.Models
{
    [Serializable, XmlRoot("App", IsNullable = true)]
    public record App
    {
        [XmlElement("appid")]
        public int AppId { get; init; }

        [XmlElement("name")]
        public string Name { get; init; }

        [XmlElement("developer")]
        public string Developers { get; init; }

        [XmlElement("publisher")]
        public string Publishers { get; init; }

        [XmlElement("positive")]
        public int PositiveReviews { get; init; }

        [XmlElement("negative")]
        public int NegativeReviews { get; init; }

        [XmlElement("price")]
        public int Price { get; init; }

        [XmlElement("ccu")]
        public int ConcurrentUsers { get; init; }

        [XmlElement("owners")]
        public string Owners { get; init; }

        public virtual bool Equals(App other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return AppId == other.AppId;
        }

        public override int GetHashCode()
        {
            return AppId;
        }
    }
}
