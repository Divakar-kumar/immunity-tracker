#pragma checksum "D:\Trainer\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1dc74b45315e5e04e24d045be7d06ef1e182ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreVerifiableCredentials.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCoreVerifiableCredentials.Pages
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
#line 1 "D:\Trainer\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\_ViewImports.cshtml"
using AspNetCoreVerifiableCredentials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1dc74b45315e5e04e24d045be7d06ef1e182ed", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1696cd1c73de55a48ac8554feb073dcb6d0d8bc3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Trainer\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div style=""margin-top:10px;text-align: center;"">                      
        <b>Get Your Precaution Dose</b> <br/><br/>
Our citizen’s health is our responsibility. Precaution Dose is available for fully vaccinated HCW/FLW and Senior Citizens (60+ yrs) after 39 weeks from 2nd dose. Citizens aged 60 years or more and having co-morbidities, should take precaution dose, only after medical advice. Both online and walk-in available.
                <br/>
                <br/>
                <br/>
                <b>Vaccination for Children</b><br/><br/>

Protect your child! Getting your children(15-18 yrs) vaccinated is the best thing you can do to protect them from COVID-19. Vaccination slots can now be booked for children aged 15-18 yrs. Both online and walk-in available.
<br/>
                <br/>
                <br/>
                
                <button type=""button"" id=""idIssue"" class=""btn btn-success"">Get Vaccinated</button>
               <!-- <button type=""button"" id=""i");
            WriteLiteral(@"dVerify"" class=""button"">VERIFY CREDENTIAL</button>-->
                <script>
                        var idIssue = document.getElementById('idIssue');
                       //var idVerify = document.getElementById('idVerify');

                        idIssue.addEventListener('click', () => {
                            window.location = ""issuer"";
                        })
                        /*idVerify.addEventListener('click', () => {
                            window.location = ""verifier"";
                        })*/
                    </script>
            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
