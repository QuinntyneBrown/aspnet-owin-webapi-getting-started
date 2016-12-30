using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace Chloe.Middleware
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public static class MiddlewareExtensions
    {
        public static void UseChloe(this IAppBuilder app) {

        }
    }
}
