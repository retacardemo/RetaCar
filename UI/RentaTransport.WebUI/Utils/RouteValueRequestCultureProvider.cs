﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RentaTransport.AdminUI.Utils
{
    public class RouteValueRequestCultureProvider : RequestCultureProvider
    {
        private readonly CultureInfo[] _cultures;

        public RouteValueRequestCultureProvider(CultureInfo[] cultures)
        {
            _cultures = cultures;
        }

        public int IndexOfCulture;
        public int IndexofUICulture;

        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            var defaultCulture = "en-US";

            var path = httpContext.Request.Path;

            if (string.IsNullOrWhiteSpace(path))
                return Task.FromResult(new ProviderCultureResult(defaultCulture));

            var routeValues = httpContext.Request.Path.Value.Split('/');
            if (routeValues.Count() <= 1)
                return Task.FromResult(new ProviderCultureResult(defaultCulture));

            if (!_cultures.Any(x => x.Name.ToLower() == routeValues[1].ToLower()))
                return Task.FromResult(new ProviderCultureResult(defaultCulture));

            return Task.FromResult(new ProviderCultureResult(routeValues[1]));
        }
    }
}
