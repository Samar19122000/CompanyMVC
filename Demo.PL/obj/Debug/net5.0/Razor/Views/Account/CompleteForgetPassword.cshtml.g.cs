#pragma checksum "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\Account\CompleteForgetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd0e6514e95bb0caf503844ba33f54c02b1c43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CompleteForgetPassword), @"mvc.1.0.view", @"/Views/Account/CompleteForgetPassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd0e6514e95bb0caf503844ba33f54c02b1c43a", @"/Views/Account/CompleteForgetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0bb1aa19a06c9fe00942483623e7d2121faa0a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_CompleteForgetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\route\MVC\Day_2\AssAndPP\Demo.PL Solution\Demo.PL\Views\Account\CompleteForgetPassword.cshtml"
  
    ViewData["Title"] = "CompleteForgetPassword";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-agileinfo"">
			<div class=""agileits-top"">
				<p> Passowrd Reset Link has been Sent To Your Email. Please check your inbox :)</P>
					<a class=""btn btn-primary"" target=""_blank"" href = ""https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox"">Your Inbox</a>
				</div>
		</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
