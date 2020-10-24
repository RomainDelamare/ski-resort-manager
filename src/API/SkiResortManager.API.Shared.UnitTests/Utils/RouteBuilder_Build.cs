using SkiResortManager.API.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SkiResortManager.API.Shared.UnitTests.Utils
{
    public class RouteBuilder_Build
    {
        [Theory]
        [InlineData("", "", "")]
        [InlineData(null, null, "")]
        [InlineData("api/test", "action", "api/test/action")]
        [InlineData("/api/test", "action/", "api/test/action")]
        [InlineData("api/test/", "action", "api/test/action")]
        [InlineData("api/test", "/action", "api/test/action")]
        [InlineData("api/test/", "/action", "api/test/action")]
        [InlineData("api/test", "", "api/test")]
        [InlineData("api/test", " ", "api/test")]
        [InlineData("", "action", "action")]
        [InlineData(" ", "action", "action")]
        public void RouteBuilder_Build_ShouldReturnCleanRoute(string routeBase, string routeAction, string result)
        {
            var route = RouteBuilder.Build(routeBase, routeAction);
            Assert.Equal(result, route);
        }
    }
}
