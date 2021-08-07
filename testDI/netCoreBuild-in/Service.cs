namespace testDI
{
    public interface IService
    {
        void RedisTest();
    }

    public class Service : IService
    {
        private ITestSingle single;
        private ITestScope scope;
        private ITestTrans trans;

        public Service(ITestSingle single,ITestScope scope,ITestTrans trans)
        {
            this.single = single;
            this.scope = scope;
            this.trans = trans;
        }

        public void RedisTest(){ }
    }
}