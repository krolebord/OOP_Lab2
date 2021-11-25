using System.Collections.Generic;
using System.Linq;
using OOP_Lab2.Models;
using OOP_Lab2.Services;
using OOP_Lab2.Services.FilteringStrategies;
using Xunit;

namespace OOP_Lab2.Tests
{
    public class FilteringTests
    {
        public static IEnumerable<object[]> Data => new []
        {
            new object[]
            {
                new AppsFilter(),
                _dataPath,
                new List<int> { 1, 2, 3, 4, 5, 6 }
            },
            new object[]
            {
                new AppsFilter { Name = "dota" },
                _dataPath,
                new List<int> { 1 }
            },
            new object[]
            {
                new AppsFilter { Developer = "valve" },
                _dataPath,
                new List<int> { 1, 2}
            },
            new object[]
            {
                new AppsFilter { Publisher = "ubisoft" },
                _dataPath,
                new List<int> { 5 }
            },
            new object[]
            {
                new AppsFilter { IsFree = true },
                _dataPath,
                new List<int> { 1, 2, 3, 6 }
            },
            new object[]
            {
                new AppsFilter { MinOwners = 90000000 },
                _dataPath,
                new List<int> { 1 }
            },
            new object[]
            {
                new AppsFilter { MaxConcurrentUsers = 100_000 },
                _dataPath,
                new List<int> { 3, 4, 5 }
            },
            new object[]
            {
                new AppsFilter
                {
                    Name = "r",
                    Developer = "e",
                    Publisher = "e",
                    IsFree = false
                },
                _dataPath,
                new List<int> { 2, 3, 4 }
            },
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void TestDomApi(AppsFilter filter, string dataPath, List<int> expectedAppsIds)
        {
            var context = new AppsContext
            {
                Strategy = new DomFilteringStrategy()
            };

            var result = context
                .GetFilteredApps(dataPath, filter)
                .Select(x => x.AppId);

            Assert.Equal(expectedAppsIds, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestSaxApi(AppsFilter filter, string dataPath, List<int> expectedAppsIds)
        {
            var context = new AppsContext
            {
                Strategy = new SaxFilteringStrategy()
            };

            var result = context
                .GetFilteredApps(dataPath, filter)
                .Select(x => x.AppId);

            Assert.Equal(expectedAppsIds, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestLinqApi(AppsFilter filter, string dataPath, List<int> expectedAppsIds)
        {
            var context = new AppsContext
            {
                Strategy = new LinqFilteringStrategy()
            };

            var result = context
                .GetFilteredApps(dataPath, filter)
                .Select(x => x.AppId);

            Assert.Equal(expectedAppsIds, result);
        }

        private const string _dataPath = "test_data.xml";
    }
}
