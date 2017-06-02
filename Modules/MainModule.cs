using Nancy;
using System;
using HelloWorld.BusinessLogic.Services.Interfaces;


namespace HelloWorld.Modules
{
    public class MainModule : NancyModule
    {
        private readonly IVersionService versionService;

        public MainModule(IVersionService versionServiceSvc)
        {
            versionService = versionServiceSvc;

            Get("/", args =>
            {
                var model = new
                {
                    app = versionService.GetApplicationName(),
                    version = versionService.GetApplicationVersion(),
                    time = DateTime.Now
                };
            
                return Response.AsJson(model);
            });
            
        }
    }
}
