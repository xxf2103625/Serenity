﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityPageController : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 2 "..\..\Views\EntityPageController.cshtml"
 public dynamic Model { get; set; } 
        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



            
            #line 2 "..\..\Views\EntityPageController.cshtml"
                                                   
    var dotModule = Model.Module == null ? "" : ("." + Model.Module);
    var modulePath = Model.Module ?? Model.RootNamespace;


            
            #line default
            #line hidden
WriteLiteral("\r\nnamespace ");


            
            #line 7 "..\..\Views\EntityPageController.cshtml"
      Write(Model.RootNamespace);

            
            #line default
            #line hidden

            
            #line 7 "..\..\Views\EntityPageController.cshtml"
                            Write(dotModule);

            
            #line default
            #line hidden
WriteLiteral(".Pages\r\n{\r\n    using Serenity;\r\n    using System.Web.Mvc;\r\n\r\n    public class ");


            
            #line 12 "..\..\Views\EntityPageController.cshtml"
             Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Controller : Controller\r\n    {\r\n        [Authorize]\r\n        public ActionResult " +
"Index()\r\n        {\r\n            SecurityHelper.EnsurePermission(\"");


            
            #line 17 "..\..\Views\EntityPageController.cshtml"
                                         Write(Model.Permission);

            
            #line default
            #line hidden
WriteLiteral("\", RightErrorHandling.Redirect);\r\n            return View(\"~/Modules/");


            
            #line 18 "..\..\Views\EntityPageController.cshtml"
                               Write(modulePath);

            
            #line default
            #line hidden
WriteLiteral("/");


            
            #line 18 "..\..\Views\EntityPageController.cshtml"
                                             Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("/");


            
            #line 18 "..\..\Views\EntityPageController.cshtml"
                                                                Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Index.cshtml\");\r\n        }\r\n    }\r\n}");


        }
    }
}
#pragma warning restore 1591