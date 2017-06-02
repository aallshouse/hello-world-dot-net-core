using HelloWorld.BusinessLogic.Services.Interfaces;

namespace HelloWorld.Services
{
    public class AppSettings : IAppSettings
    {
        public string Value1 { get; set; }

        public string Value2 { get; set; }

        public string Value3 { get; set; }
    }
}
