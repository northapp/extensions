﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Signum.Utilities;
    using Signum.Entities;
    using Signum.Web;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Web.DynamicData;
    using System.Web.SessionState;
    using System.Web.Profile;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Xml.Linq;
    using Signum.Entities.ControlPanel;
    using Signum.Web.ControlPanel;
    using System.Reflection;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ControlPanel/Views/Admin/ControlPanelAdmin.cshtml")]
    public class _Page_ControlPanel_Views_Admin_ControlPanelAdmin_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {


        public _Page_ControlPanel_Views_Admin_ControlPanelAdmin_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {



WriteLiteral("\r\n");


Write(Html.ScriptsJs("~/ControlPanel/Scripts/SF_FlowTable.js"));

WriteLiteral("\r\n");


Write(Html.ScriptCss("~/ControlPanel/Content/SF_FlowTable.css",
                "~/ControlPanel/Content/SF_ControlPanel.css"));

WriteLiteral("\r\n\r\n<div>\r\n");


     using (var tc = Html.TypeContext<ControlPanelDN>())
    {
        
   Write(Html.EntityLine(tc, cp => cp.Related, el => el.Create = false));

                                                                       
        
   Write(Html.ValueLine(tc, cp => cp.DisplayName));

                                                 
        
   Write(Html.ValueLine(tc, cp => cp.HomePage));

                                              
        
   Write(Html.ValueLine(tc, cp => cp.NumberOfColumns));

                                                     
    
        Html.RenderPartial(ControlPanelClient.AdminViewPrefix.Formato("PanelParts"), tc.Value);

WriteLiteral("        <div class=\"clearall\"></div>   \r\n");


    }

WriteLiteral("</div>\r\n\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n        SF.FlowTa" +
"ble.init($(\"#sfCpAdminContainer\"));\r\n    });\r\n</script>");


        }
    }
}
