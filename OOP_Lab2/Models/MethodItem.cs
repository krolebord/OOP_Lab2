namespace OOP_Lab2.Models
{
    public class MethodItem
    {
        public Method Method { get; set; }

        public string Text { get; set; }

        public override string ToString() => Text;
    }
}
