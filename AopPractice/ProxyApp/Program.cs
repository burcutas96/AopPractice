namespace ProxyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessModuleProxy businessModuleProxy = new(new BusinessModule());
            businessModuleProxy.Method();
        }
    }
}
