﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Extensions.SMS.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
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
    
    #line 1 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    
    #line 6 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Engine.SMS;
    
    #line default
    #line hidden
    
    #line 3 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Entities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Entities.SMS;
    
    #line default
    #line hidden
    
    #line 7 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Utilities;
    
    #line default
    #line hidden
    
    #line 4 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Web;
    
    #line default
    #line hidden
    
    #line 8 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Web.Mailing;
    
    #line default
    #line hidden
    
    #line 5 "..\..\SMS\Views\SMSTemplate.cshtml"
    using Signum.Web.SMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/SMS/Views/SMSTemplate.cshtml")]
    public partial class SMSTemplate : System.Web.Mvc.WebViewPage<dynamic>
    {
        public SMSTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 10 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ScriptCss("~/SMS/Content/SMS.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 12 "..\..\SMS\Views\SMSTemplate.cshtml"
 using (var tc = Html.TypeContext<SMSTemplateDN>())
{   
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.Name));

            
            #line default
            #line hidden
            
            #line 14 "..\..\SMS\Views\SMSTemplate.cshtml"
                                    
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.Active, vl => vl.ReadOnly = true));

            
            #line default
            #line hidden
            
            #line 15 "..\..\SMS\Views\SMSTemplate.cshtml"
                                                                
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.StartDate));

            
            #line default
            #line hidden
            
            #line 16 "..\..\SMS\Views\SMSTemplate.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.EndDate));

            
            #line default
            #line hidden
            
            #line 17 "..\..\SMS\Views\SMSTemplate.cshtml"
                                        
    
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.From));

            
            #line default
            #line hidden
            
            #line 19 "..\..\SMS\Views\SMSTemplate.cshtml"
                                     
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.Certified));

            
            #line default
            #line hidden
            
            #line 20 "..\..\SMS\Views\SMSTemplate.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.EditableMessage));

            
            #line default
            #line hidden
            
            #line 21 "..\..\SMS\Views\SMSTemplate.cshtml"
                                               
    
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.RemoveNoSMSCharacters));

            
            #line default
            #line hidden
            
            #line 23 "..\..\SMS\Views\SMSTemplate.cshtml"
                                                     
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.ValueLine(tc, s => s.MessageLengthExceeded));

            
            #line default
            #line hidden
            
            #line 24 "..\..\SMS\Views\SMSTemplate.cshtml"
                                                     
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clearall\"");

WriteLiteral("></div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"sfTemplateLiterals\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\SMS\Views\SMSTemplate.cshtml"
       Write(Html.EntityCombo(tc, s => s.AssociatedType, ec =>
            {
                ec.Data = SMSLogic.RegisteredDataObjectProviders();
                ec.ComboHtmlProperties["class"] = "sf-associated-type";
                ec.AttachFunction = new JsLineFunction(SMSClient.Module, "attachAssociatedType", Url.Action<SMSController>(s => s.GetLiteralsForType()));
            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 37 "..\..\SMS\Views\SMSTemplate.cshtml"
    Write(new HtmlTag("select").Attr("multiple", "multiple").Id("sfLiterals").ToHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n        <br />\r\n        <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"sf-button\"");

WriteLiteral(" id=\"sfInsertLiteral\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1433), Tuple.Create("\"", 1474)
            
            #line 39 "..\..\SMS\Views\SMSTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create<System.Object, System.Int32>(SmsMessage.Insert.NiceToString()
            
            #line default
            #line hidden
, 1441), false)
);

WriteLiteral(" />\r\n    </div>\r\n");

            
            #line 41 "..\..\SMS\Views\SMSTemplate.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\SMS\Views\SMSTemplate.cshtml"
Write(Html.EntityTabRepeater(tc, e => e.Messages, er =>
        {
            er.PreserveViewData = true;
        }));

            
            #line default
            #line hidden
            
            #line 45 "..\..\SMS\Views\SMSTemplate.cshtml"
          
    

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n");

WriteLiteral("        ");

            
            #line 48 "..\..\SMS\Views\SMSTemplate.cshtml"
    Write(new JsFunction(SMSClient.Module, "init",
    Url.Action<SMSController>(s => s.RemoveNoSMSCharacters("")),
    Url.Action<SMSController>(s => s.GetDictionaries())));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n");

            
            #line 52 "..\..\SMS\Views\SMSTemplate.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
