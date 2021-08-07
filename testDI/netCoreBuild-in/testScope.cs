namespace testDI
{
    public interface ITestScope
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class TestScope : ITestScope
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}