namespace OOP_Lab2.Models
{
    public class AppsFilter
    {
        public string Name { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public int MinScore { get; set; } = 0;

        public int MaxScore { get; set; } = 100;

        public int MinOwners { get; set; } = 0;

        public bool IsFree { get; set; } = false;

        public int MaxConcurrentUsers { get; set; } = 0;
    }
}
