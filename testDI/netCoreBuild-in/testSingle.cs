namespace testDI
{
    public interface ITestSingle
    {
        int Age { set; get; }
        string Name { set; get; }
    }

    public class TestSingle : ITestSingle
    {
        public int Age { set; get; }
        public string Name { set; get;}
    }
}