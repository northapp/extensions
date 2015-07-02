﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\Translation\Views\ViewInstance.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 5 "..\..\Translation\Views\ViewInstance.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Translation\Views\ViewInstance.cshtml"
    using Signum.Engine.Translation;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 4 "..\..\Translation\Views\ViewInstance.cshtml"
    using Signum.Entities.Translation;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Translation\Views\ViewInstance.cshtml"
    using Signum.Utilities;
    
    #line default
    #line hidden
    using Signum.Web;
    
    #line 7 "..\..\Translation\Views\ViewInstance.cshtml"
    using Signum.Web.Translation.Controllers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Translation/Views/ViewInstance.cshtml")]
    public partial class _Translation_Views_ViewInstance_cshtml : System.Web.Mvc.WebViewPage<Dictionary<CultureInfo, Dictionary<LocalizedInstanceKey, TranslatedInstanceEntity>>>
    {
        public _Translation_Views_ViewInstance_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 8 "..\..\Translation\Views\ViewInstance.cshtml"
  
    CultureInfo culture = ViewBag.Culture;
    Type type = ViewBag.Type;

    ViewBag.Title = TranslationMessage.View0In1.NiceToString().FormatWith(type.NiceName(), culture == null ? TranslationMessage.AllLanguages.NiceToString() : culture.DisplayName);

    Dictionary<LocalizedInstanceKey, string> master = ViewBag.Master;

    var cultures = TranslationLogic.CurrentCultureInfos(TranslatedInstanceLogic.DefaultCulture);

    Func<CultureInfo, bool> editCulture = c => culture == null || culture.Name == c.Name;

    var filter = (string)ViewBag.Filter;

    var all = string.IsNullOrEmpty(filter);

    Func<LocalizedInstanceKey, bool> filtered = li => all ||
        li.RowId.ToString() == filter ||
        li.Instance.Id.ToString() == filter ||
        li.Route.PropertyString().Contains(filter, StringComparison.InvariantCultureIgnoreCase) ||
        master.GetOrThrow(li).Contains(filter, StringComparison.InvariantCultureIgnoreCase) ||
        cultures.Any(ci => (Model.TryGetC(ci).TryGetC(li)?.TranslatedText).DefaultText("").Contains(filter, StringComparison.InvariantCultureIgnoreCase));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 31 "..\..\Translation\Views\ViewInstance.cshtml"
Write(Html.ScriptCss("~/Translation/Content/Translation.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n<h2>");

            
            #line 35 "..\..\Translation\Views\ViewInstance.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n<div>\r\n");

            
            #line 38 "..\..\Translation\Views\ViewInstance.cshtml"
    
            
            #line default
            #line hidden
            
            #line 38 "..\..\Translation\Views\ViewInstance.cshtml"
     using (Html.BeginForm("View", "TranslatedInstance", FormMethod.Get))
    {
        
            
            #line default
            #line hidden
            
            #line 40 "..\..\Translation\Views\ViewInstance.cshtml"
   Write(Html.Hidden("type"));

            
            #line default
            #line hidden
            
            #line 40 "..\..\Translation\Views\ViewInstance.cshtml"
                            
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Translation\Views\ViewInstance.cshtml"
   Write(Html.Hidden("culture"));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Translation\Views\ViewInstance.cshtml"
                               
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Translation\Views\ViewInstance.cshtml"
   Write(Html.TextBox("filter", filter));

            
            #line default
            #line hidden
            
            #line 42 "..\..\Translation\Views\ViewInstance.cshtml"
                                       ;


            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"searchPressed\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1804), Tuple.Create("\"", 1853)
            
            #line 45 "..\..\Translation\Views\ViewInstance.cshtml"
, Tuple.Create(Tuple.Create("", 1812), Tuple.Create<System.Object, System.Int32>(TranslationMessage.Search.NiceToString()
            
            #line default
            #line hidden
, 1812), false)
);

WriteLiteral(" />\r\n");

            
            #line 46 "..\..\Translation\Views\ViewInstance.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 49 "..\..\Translation\Views\ViewInstance.cshtml"
 if (Model == null)
{

            
            #line default
            #line hidden
WriteLiteral("    <em>");

            
            #line 51 "..\..\Translation\Views\ViewInstance.cshtml"
   Write(TranslationMessage.PressSearchForResults.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");

            
            #line 52 "..\..\Translation\Views\ViewInstance.cshtml"
}
else if (Model.IsEmpty())
{

            
            #line default
            #line hidden
WriteLiteral("    <strong>");

            
            #line 55 "..\..\Translation\Views\ViewInstance.cshtml"
       Write(TranslationMessage.NoResultsFound.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n");

            
            #line 56 "..\..\Translation\Views\ViewInstance.cshtml"
}
else
{
    using (Html.BeginForm((TranslatedInstanceController c) => c.SaveView(Signum.Engine.Basics.TypeLogic.GetCleanName(type), culture == null ? null : culture.Name, filter)))
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" id=\"results\"");

WriteLiteral(" style=\"width: 100%; margin: 0px\"");

WriteLiteral(" class=\"st\"");

WriteLiteral(">\r\n");

            
            #line 62 "..\..\Translation\Views\ViewInstance.cshtml"
            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Translation\Views\ViewInstance.cshtml"
             foreach (var instance in master.Keys.Where(li => master.GetOrThrow(li).HasText()).Where(filtered).GroupBy(a => a.Instance).OrderBy(a => a.Key.Id))
            {

            
            #line default
            #line hidden
WriteLiteral("                <thead>\r\n                    <tr>\r\n                        <th");

WriteLiteral(" class=\"leftCell\"");

WriteLiteral(">");

            
            #line 66 "..\..\Translation\Views\ViewInstance.cshtml"
                                        Write(TranslationMessage.Instance.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th");

WriteLiteral(" class=\"titleCell\"");

WriteLiteral(">");

            
            #line 67 "..\..\Translation\Views\ViewInstance.cshtml"
                                         Write(Html.Href(Navigator.NavigateRoute(instance.Key), instance.Key.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n");

            
            #line 70 "..\..\Translation\Views\ViewInstance.cshtml"

                foreach (LocalizedInstanceKey key in instance.OrderBy(a => a.Route.ToString()))
                {
                    var propertyString = key.Route.PropertyString().Replace("/", "[" + key.RowId + "].");

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <th");

WriteLiteral(" class=\"leftCell\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 76 "..\..\Translation\Views\ViewInstance.cshtml"
                       Write(TranslationMessage.Property.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                    <th>");

            
            #line 78 "..\..\Translation\Views\ViewInstance.cshtml"
                   Write(propertyString);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                </tr>\r\n");

            
            #line 80 "..\..\Translation\Views\ViewInstance.cshtml"

                    foreach (var ci in cultures)
                    {
                        var formName = ci.Name + "#" + key.Instance.Key() + "#" + propertyString;

                        if (ci.Name == TranslatedInstanceLogic.DefaultCulture.Name)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td");

WriteLiteral(" class=\"leftCell\"");

WriteLiteral("><em>");

            
            #line 88 "..\..\Translation\Views\ViewInstance.cshtml"
                                                    Write(TranslatedInstanceLogic.DefaultCulture);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n                                <td");

WriteLiteral(" class=\"monospaceCell\"");

WriteLiteral(">\r\n");

            
            #line 90 "..\..\Translation\Views\ViewInstance.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 90 "..\..\Translation\Views\ViewInstance.cshtml"
                                     if (TranslatedInstanceLogic.RouteType(key.Route).Value == TraducibleRouteType.Html)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <pre>");

            
            #line 92 "..\..\Translation\Views\ViewInstance.cshtml"
                                        Write(master[key]);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n");

            
            #line 93 "..\..\Translation\Views\ViewInstance.cshtml"
                                    }
                                    else
                                    {
                                        
            
            #line default
            #line hidden
            
            #line 96 "..\..\Translation\Views\ViewInstance.cshtml"
                                   Write(master[key]);

            
            #line default
            #line hidden
            
            #line 96 "..\..\Translation\Views\ViewInstance.cshtml"
                                                    
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 98 "..\..\Translation\Views\ViewInstance.cshtml"
                               Write(Html.TextArea(formName, master[key], new { style = "display:none" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");

            
            #line 101 "..\..\Translation\Views\ViewInstance.cshtml"
                        }
                        else
                        {
                            TranslatedInstanceEntity trans = Model.TryGetC(ci).TryGetC(key);

                            if (trans != null && editCulture(ci))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"leftCell\"");

WriteLiteral(">");

            
            #line 109 "..\..\Translation\Views\ViewInstance.cshtml"
                                                    Write(ci.Name);

            
            #line default
            #line hidden
WriteLiteral(" Diff</td>\r\n                                    <td");

WriteLiteral(" class=\"monospaceCell\"");

WriteLiteral(">\r\n                                        <pre>");

            
            #line 111 "..\..\Translation\Views\ViewInstance.cshtml"
                                        Write(Signum.Web.Translation.TranslationClient.Diff(trans.OriginalText, trans.TranslatedText));

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n                                    </td>\r\n                              " +
"  </tr>\r\n");

            
            #line 114 "..\..\Translation\Views\ViewInstance.cshtml"

                            }


                            if (trans != null || editCulture(ci))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"leftCell\"");

WriteLiteral(">");

            
            #line 121 "..\..\Translation\Views\ViewInstance.cshtml"
                                                    Write(ci.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" class=\"monospaceCell\"");

WriteLiteral(">\r\n");

            
            #line 123 "..\..\Translation\Views\ViewInstance.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 123 "..\..\Translation\Views\ViewInstance.cshtml"
                                         if (editCulture(ci))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 125 "..\..\Translation\Views\ViewInstance.cshtml"
                                       Write(Html.TextArea(formName, trans?.TranslatedText, new { style = "width:90%;" }));

            
            #line default
            #line hidden
            
            #line 125 "..\..\Translation\Views\ViewInstance.cshtml"
                                                                                                                                    
                                        }
                                        else if (TranslatedInstanceLogic.RouteType(key.Route).Value == TraducibleRouteType.Html)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <pre>");

            
            #line 129 "..\..\Translation\Views\ViewInstance.cshtml"
                                            Write(trans.TranslatedText);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n");

            
            #line 130 "..\..\Translation\Views\ViewInstance.cshtml"
                                        }
                                        else
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 133 "..\..\Translation\Views\ViewInstance.cshtml"
                                       Write(trans.TranslatedText);

            
            #line default
            #line hidden
            
            #line 133 "..\..\Translation\Views\ViewInstance.cshtml"
                                                                 
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                </tr>\r" +
"\n");

            
            #line 137 "..\..\Translation\Views\ViewInstance.cshtml"
                            }
                        }

                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6432), Tuple.Create("\"", 6479)
            
            #line 144 "..\..\Translation\Views\ViewInstance.cshtml"
, Tuple.Create(Tuple.Create("", 6440), Tuple.Create<System.Object, System.Int32>(TranslationMessage.Save.NiceToString()
            
            #line default
            #line hidden
, 6440), false)
);

WriteLiteral(" />\r\n");

            
            #line 145 "..\..\Translation\Views\ViewInstance.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    $(function () {\r\n");

WriteLiteral("        ");

            
            #line 151 "..\..\Translation\Views\ViewInstance.cshtml"
    Write(Signum.Web.Translation.TranslationClient.Module["fixTextAreas"]());

            
            #line default
            #line hidden
WriteLiteral("\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
