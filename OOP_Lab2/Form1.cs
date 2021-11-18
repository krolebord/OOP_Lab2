using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml.Xsl;
using OOP_Lab2.Helpers;
using OOP_Lab2.Models;
using OOP_Lab2.Services;
using OOP_Lab2.Services.FilteringStrategies;

namespace OOP_Lab2
{
    public partial class Lab2Form : Form
    {
        private const string _dataPath = "data.xml";
        private const string _stylePath = "style.xslt";
        private const string _outputFolder = "output";

        private readonly AppsContext _context = new();

        private string _currentContent = "";

        public Lab2Form()
        {
            InitializeComponent();

            methodSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            methodSelector.DataSource = new MethodItem[]
            {
                new() { Method = Method.Dom, Text = "DOM API" },
                new() { Method = Method.Sax, Text = "SAX API" },
                new() { Method = Method.Linq, Text = "LINQ to XML API" }
            };

            UpdateMethod();

            ClearFilters();

            Directory.CreateDirectory(_outputFolder);

            _ = DisplayInitialData();
        }

        private async Task DisplayInitialData()
        {
            var transform = GetTransform();

            var results = new StringWriter();
            transform.Transform(_dataPath, null, results);

            await SetViewContent(results.ToString());
        }

        private async Task DisplayData(List<App> apps)
        {
            var appsDoc = AppsConverter.AppsToXml(apps);

            var transform = GetTransform();
            var results = new StringWriter();
            transform.Transform(appsDoc.ToXPathNavigable(), null, results);

            await SetViewContent(results.ToString());
        }

        private void ClearFilters()
        {
            NameBox.Text = "";
            DeveloperBox.Text = "";
            PublisherBox.Text = "";
            MinUserScoreNumeric.Value = 0;
            MaxUserScoreNumeric.Value = 100;
            MinOwnersNumeric.Value = 0;
            FreeCheckbox.Checked = false;
            MaxConcurrentUsersNumeric.Value = 0;
        }

        private void UpdateMethod()
        {
            var selectedItem = (MethodItem)methodSelector.SelectedItem;

            switch (selectedItem.Method)
            {
                case Method.Dom:
                    _context.Strategy = new DomFilteringStrategy();
                    break;
                case Method.Sax:
                    _context.Strategy = new SaxFilteringStrategy();
                    break;
                case Method.Linq:
                    _context.Strategy = new LinqFilteringStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async void FilterData()
        {
            var filter = new AppsFilter
            {
                Name = NameBox.Text,
                Developer = DeveloperBox.Text,
                Publisher = PublisherBox.Text,
                IsFree = FreeCheckbox.Checked,
                MinOwners = (int)MinOwnersNumeric.Value,
                MinScore = (int)MinUserScoreNumeric.Value,
                MaxScore = (int)MaxUserScoreNumeric.Value,
                MaxConcurrentUsers = (int)MaxConcurrentUsersNumeric.Value
            };

            var filteredData = _context.GetFilteredApps(_dataPath, filter);

            await DisplayData(filteredData);
        }

        private async void SaveData()
        {
            if (string.IsNullOrWhiteSpace(_currentContent))
            {
                return;
            }

            var fileName = $"search-result-{DateTime.Now:h-m-s}.html";
            var filePath = Path.Combine(_outputFolder, fileName);

            await File.WriteAllTextAsync(filePath, _currentContent);
        }

        private XslCompiledTransform GetTransform()
        {
            var transform = new XslCompiledTransform();
            transform.Load(_stylePath);

            return transform;
        }

        private async Task SetViewContent(string content)
        {
            _currentContent = content;

            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(content);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void MethodSelectorOnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMethod();
        }

        private void SaveButtonOnClick(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
