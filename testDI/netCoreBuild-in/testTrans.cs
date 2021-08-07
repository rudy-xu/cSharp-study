namespace testDI
{
    public interface ITestTrans
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class TestTans : ITestTrans
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}