#pragma checksum "C:\Users\Farid Guluzade\source\repos\Layout\Layout\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcca25db6e0f0fc3b39a0f670b3de8b096b41fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Farid Guluzade\source\repos\Layout\Layout\Views\_ViewImports.cshtml"
using Layout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcca25db6e0f0fc3b39a0f670b3de8b096b41fa3", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7789415640fa43c93e4cc5ab1d2658d06ef31f84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Card>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
        <section>

            <div class=""container mt-5"">
                <div class=""row justify-content-center"">
                  <div class=""col-lg-6 py-4"">
                      <div class=""card""  >
                   <img src=""https://picsum.photos/400/300"" class=""card-img-top"" alt=""img"">
                   <div class=""card-body"">
                      <h5 class=""card-title"">");
#nullable restore
#line 11 "C:\Users\Farid Guluzade\source\repos\Layout\Layout\Views\Home\Details.cshtml"
                                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card\'s content.</p>\r\n                      <a href=\"/\" class=\"btn btn-danger\">Go Back ");
#nullable restore
#line 13 "C:\Users\Farid Guluzade\source\repos\Layout\Layout\Views\Home\Details.cshtml"
                                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                         </div>\r\n                      </div>\r\n                    \r\n                    </div>\n                \r\n                </div> \r\n            </div>\r\n\r\n        </section>\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Card> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
