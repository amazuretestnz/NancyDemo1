using Nancy;
using Nancy.Testing;
using NancyDemo1.Modules.Api;
using NUnit.Framework;

namespace UnitTests.Of.Modules.Of.Api
{
    [TestFixture]
    public class SiteModuleFixture
    {
        Browser _browser;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            _browser = new Browser(cfg =>
            {
                cfg.Module<SiteModule>();
            });
        }

        [TestCase("/")]
        public void Should_return_status_ok_when_route_exists(string route)
        {
            var result = SendRequest(route);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        private BrowserResponse SendRequest(string route)
        {
            return _browser.Get(route, with =>
            {
                with.HttpRequest();
            });
        }
    }
}