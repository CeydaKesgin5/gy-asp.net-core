using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace RouteYapılanması.Constrait
{
    public class CustomConstrait: IRouteConstraint
    {
        public bool Match(HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            var idvalue = values[routeKey];
            return true;
        }
    }
}
