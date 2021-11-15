using System.Collections.Generic;
using System.Xml.Serialization;

namespace OOP_Lab2.Models
{
    [XmlRoot("Apps")]
    public class Apps
    {
        [XmlElement("App")]
        public List<App> AppList { get; set; }
    }
}
