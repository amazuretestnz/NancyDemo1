using Nancy;

namespace NancyDemo1.Modules.Api
{
    public class SiteModule : NancyModule
    {
        public SiteModule()
        {
            Get["/"] = _ => "Hello from NancyDemo1";
        }
    }
}