#pragma checksum "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "967cc19aa9a5e401382011fa7edf8902fae65c58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetByUserId), @"mvc.1.0.view", @"/Views/Account/GetByUserId.cshtml")]
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
#line 5 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\_ViewImports.cshtml"
using Dk.BankApp.Web.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\_ViewImports.cshtml"
using Dk.BankApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"967cc19aa9a5e401382011fa7edf8902fae65c58", @"/Views/Account/GetByUserId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"560341e2b04ad6b6df7ab117c441c251f4b07e10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_GetByUserId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AccountListModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMoney", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-6"">

                <div class=""card"" style=""width: 18rem;"">
          <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
          <div class=""card-body"">
            <h5 class=""card-title"">Kullanıcı Bilgileri</h5>
            <p class=""card-text"">Ad: ");
#nullable restore
#line 16 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
                                Write(ViewBag.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967cc19aa9a5e401382011fa7edf8902fae65c585657", async() => {
                WriteLiteral("Kullanıcı Listesine Geri Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-6\">\r\n");
#nullable restore
#line 23 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
         if(Model.Count()>0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
             foreach(var account in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"width: 18rem;\">\r\n                  <img class=\"card-img-top\" src=\"...\" alt=\"Card image cap\">\r\n                  <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Hesap Numarası: ");
#nullable restore
#line 30 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
                                                      Write(account.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Bakiye Bilgisi: ");
#nullable restore
#line 31 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
                                                    Write(account.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967cc19aa9a5e401382011fa7edf8902fae65c588666", async() => {
                WriteLiteral("Para Gönder");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-accountId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
                                                                                WriteLiteral(account.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-accountId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n            </div> \r\n");
#nullable restore
#line 35 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
             
           
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-primary\" role=\"alert\" >\r\n              <p class=\"lead\">\r\n                  Kullanıcının hesabı bulunmamaktadır.\r\n              </p>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\duhan\Documents\GitHub\BankApp-AspNetCoreMVC5\Dk.BankApp.Web\Views\Account\GetByUserId.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AccountListModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591