﻿using Signum.Engine.Basics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Signum.React.Translation
{
    public class TranslationServer
    {
        public static CultureInfo GetCultureRequest(HttpRequest request)
        {
            if (request.UserLanguages == null)
                return null;

            foreach (string lang in request.UserLanguages)
            {
                string cleanLang = lang.Contains('-') ? lang.Split('-')[0] : lang;

                var culture = CultureInfoLogic.ApplicationCultures
                    .Where(ci => ci.Name.StartsWith(cleanLang))
                    .FirstOrDefault();

                if (culture != null)
                    return culture;
            }

            return null;
        }
    }
}