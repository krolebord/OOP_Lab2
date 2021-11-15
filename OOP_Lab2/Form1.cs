using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using OOP_Lab2.Models;

namespace OOP_Lab2
{
    public partial class Lab2Form : Form
    {
        public Lab2Form()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();

            var json = await client.GetStringAsync("https://steamspy.com/api.php?request=all");


            XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Apps");

            var apps = doc.DocumentElement;
            XmlNodeList appNodes = apps.ChildNodes;

            XDocument xDoc = doc.ToXDocument();

            var elementsToRemove = new string[]
            {
                "median", "score_rank", "userscore", "initialprice", "discount", "average"
            };

            xDoc.Descendants()
                .SelectMany(x => x.Elements())
                .Where(x => elementsToRemove.Any(xx => x.Name.LocalName.Contains(xx)))
                .Remove();

            foreach(var game in xDoc.Elements().SelectMany(x => x.Elements()))
            {
                game.Name = "App";
            }

            var serializer = new XmlSerializer(typeof(App));
            List<App> appss = xDoc.Root?
                .Elements("App")
                .Select(x =>
                {
                    using var reader = x.CreateReader();
                    return (App)serializer.Deserialize(reader);
                })
                .ToList();

            xDoc.Save("data.xml");

            var textBuilder = new StringBuilder();

            foreach (var app in appss)
            {
                textBuilder.AppendLine(app.ToString());
            }

            textBox1.Text = textBuilder.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
