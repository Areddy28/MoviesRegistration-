#pragma checksum "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d721b3e15d72a6690d4207733878ccddb3757f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#line 1 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\_ViewImports.cshtml"
using MoiveDataBase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\_ViewImports.cshtml"
using MoiveDataBase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d721b3e15d72a6690d4207733878ccddb3757f55", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df29970996248c9fe3774bf8cfcb0a5e85b0626f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
 using (Html.BeginForm("Index", "Movies", FormMethod.Post))

{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"centerDiv\">\r\n    <h3>Welcome Please add a new Movie</h3>\r\n    ");
#nullable restore
#line 8 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 11 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(t => t.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(t => t.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 16 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(t => t.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(t => t.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.ValidationMessageFor(t => t.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 22 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(t => t.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.ValidationMessageFor(t => t.Genre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 28 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(t => t.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(t => t.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 33 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.LabelFor(t => t.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"
   Write(Html.TextBoxFor(t => t.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <input class=\"submit\" type=\"submit\" value=\"Submit\" />\r\n\r\n</div>\r\n");
#nullable restore
#line 40 "C:\Users\areddy1\source\repos\MoiveDataBase\MoiveDataBase\Views\Home\Registration.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591
