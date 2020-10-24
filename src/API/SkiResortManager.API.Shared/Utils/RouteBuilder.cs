using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManager.API.Shared.Utils
{
    public static class RouteBuilder
    {
        public static string Build(string routeBase, string routeAction)
        {
            return (routeBase?.Trim('/', ' ') + '/' + routeAction?.Trim('/', ' ')).Trim('/', ' ');
        }
    }
}
