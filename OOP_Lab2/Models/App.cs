using System.Text;
using System.Xml.Serialization;

namespace OOP_Lab2.Models
{
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

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}:", Name);
            sb.AppendLine();

            sb.AppendFormat("\tId: {0}", AppId);
            sb.AppendLine();

            sb.AppendFormat("\tDeveloper: {0}", Developers);
            sb.AppendLine();

            sb.AppendFormat("\tPublisher: {0}", Publishers);
            sb.AppendLine();

            sb.AppendFormat("\tPrice: {0:C}", (decimal)Price/100);
            sb.AppendLine();

            sb.AppendFormat("\tUser score: {0:P}", (double)PositiveReviews / (NegativeReviews + PositiveReviews));
            sb.AppendLine();

            sb.AppendFormat("\tOwners: {0}", Owners);
            sb.AppendLine();

            sb.AppendFormat("\tConcurrent users: {0}", ConcurrentUsers);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
