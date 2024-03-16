namespace ProxyApp
{
    public class BusinessModuleProxy : IBusinessModule
    {
        readonly IBusinessModule _module;

        public BusinessModuleProxy(IBusinessModule module)
        {
            _module = module;
        }

        public void Method()
        {
            Console.WriteLine("Before method.");
            _module.Method();
            Console.WriteLine("After method.");
        }
    }
}
