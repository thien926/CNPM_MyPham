#pragma checksum "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6d19dd14c312981d977dad77a3c4c4da284415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\_ViewImports.cshtml"
using CNPM_MyPham;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\_ViewImports.cshtml"
using CNPM_MyPham.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6d19dd14c312981d977dad77a3c4c4da284415", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405ffefc3cd786874472c586c5fa76147766a884", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewShopModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Stylesheet", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function BrandAjax(idbrand) {\r\n            var Type = \"");
#nullable restore
#line 12 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                   Write(Model.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var Brand = \"");
#nullable restore
#line 13 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                    Write(Model.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var SearchString = \"");
#nullable restore
#line 14 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                           Write(Model.SearchString);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var pageIndex = \"");
#nullable restore
#line 15 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                        Write(Model.ListSP.PageIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            
            if (document.getElementById(idbrand).checked) {
                Brand += idbrand + ""-"";
            }
            else {
                Brand = Brand.replace(idbrand + ""-"", """");
            }

            var url = lay_URL_truoc_dau_hoi();
            if(Type != """"){
                url += ""?Type="" + Type;
                if(Brand != """"){
                    url +=  ""&Brand="" + Brand + ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
                else{
                    url += ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
            }
            else{
                if(Brand != """"){
                    url +=  ""?Brand="" + Brand + ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
                else{
                    url +=  ""?price="" + price + ""&pageIndex="" + pageIndex;
                }
            }
            
            location.href = url; 
        }

        function loadprice(){
");
                WriteLiteral("            var pricefrom = document.getElementById(\"minamount\").value;\r\n            var priceto = document.getElementById(\"maxamount\").value;\r\n            var Type = \"");
#nullable restore
#line 49 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                   Write(Model.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var Brand = \"");
#nullable restore
#line 50 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                    Write(Model.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var SearchString = \"");
#nullable restore
#line 51 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                           Write(Model.SearchString);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            var pageIndex = \"");
#nullable restore
#line 52 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                        Write(Model.ListSP.PageIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            var price = pricefrom + ""-"" + priceto;
            var url = lay_URL_truoc_dau_hoi();
            if(Type != """"){
                url += ""?Type="" + Type;
                if(Brand != """"){
                    url +=  ""&Brand="" + Brand + ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
                else{
                    url += ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
            }
            else{
                if(Brand != """"){
                    url +=  ""?Brand="" + Brand + ""&price="" + price + ""&pageIndex="" + pageIndex;
                }
                else{
                    url +=  ""?price="" + price + ""&pageIndex="" + pageIndex;
                }
            }

            location.href = url; 
        }

        function lay_URL_truoc_dau_hoi(){
            var url = location.href;
            var dauHoi = url.split(""?"");
            if(dauHoi[0]){
                return dauHoi[0];
            }
            
   ");
                WriteLiteral("         return \"\";\r\n        }\r\n\r\n        function loadCheckThuongHieu(){\r\n            var Brand = \"");
#nullable restore
#line 87 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                    Write(Model.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            if(Brand == """"){
                return;
            }
            Brand = Brand.split(""-"");
            for(let i = 0; i < Brand.length; ++i){
                document.getElementById(Brand[i]).checked = true;
            }
        }

        function loadPrice(){
            var price = """);
#nullable restore
#line 98 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                    Write(Model.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            if(price == """"){
                return;
            }
            price = price.split(""-"");
            document.getElementById(""minamount"").value = price[0];
            document.getElementById(""maxamount"").value = price[1];
        }

        loadCheckThuongHieu();
    </script>
");
            }
            );
            WriteLiteral("\r\n<!-- Breadcrumb Section Begin -->\r\n    <div class=\"breacrumb-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"breadcrumb-text\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b6d19dd14c312981d977dad77a3c4c4da28441510385", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i> Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <span>Shop</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb Section Begin -->
    <!-- Product Shop Section Begin -->
    <section class=""product-shop spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-8 order-2 order-lg-1 produts-sidebar-filter"">
                    <div class=""filter-widget"">
                        <h4 class=""fw-title"">Danh mục</h4>
                        <ul class=""filter-catagories"">
");
#nullable restore
#line 133 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                              
                                foreach (var q in Model.ListLSP)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4589, "\"", 4632, 2);
            WriteAttributeValue("", 4596, "/Shop/Index/?Type=", 4596, 18, true);
#nullable restore
#line 136 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 4614, q.product_type_id, 4614, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 136 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                                                  Write(q.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 137 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"filter-widget\">\r\n                        <h4 class=\"fw-title\">Thương hiệu</h4>\r\n                        <div class=\"fw-brand-check scrollpane\">\r\n");
#nullable restore
#line 151 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                              
                                foreach (var q in Model.ListTH)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"bc-item\">\r\n                                        <label");
            BeginWriteAttribute("for", " for=", 5586, "", 5602, 1);
#nullable restore
#line 155 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5591, q.brand_id, 5591, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 156 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                       Write(q.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                            <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=", 5725, "", 5740, 1);
#nullable restore
#line 157 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5729, q.brand_id, 5729, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 5740, "\"", 5772, 3);
            WriteAttributeValue("", 5750, "BrandAjax(", 5750, 10, true);
#nullable restore
#line 157 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5760, q.brand_id, 5760, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5771, ")", 5771, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <span class=\"checkmark\"></span>\r\n                                        </label>\r\n                                    </div>\r\n");
#nullable restore
#line 161 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""filter-widget"">
                        <h4 class=""fw-title"">Giá</h4>
                        <div class=""filter-range-wrap"">
                            <div class=""range-slider"">
                                <div class=""price-input"">
                                    <input type=""text"" id=""minamount"" disabled>
                                    <input type=""text"" id=""maxamount"" disabled>
                                </div>
                            </div>
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content""
                                data-min=""0"" data-max=""");
#nullable restore
#line 188 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                  Write(Model.pricemax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
");
            WriteLiteral(@"                        </div>
                        <a class=""filter-btn"" onclick=""loadprice()"">Lọc</a>
                    </div>
                    
                </div>
                <div class=""col-lg-9 order-1 order-lg-2"">
                    <div class=""product-show-option"">
                        <div class=""row"">
                            <div class=""col-lg-8 col-md-8"">
");
#nullable restore
#line 209 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                  
                                    if(!string.IsNullOrEmpty(Model.NameType)){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p style=\"font-weight: bold;\">Loại sản phẩm: ");
#nullable restore
#line 211 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                                                Write(Model.NameType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 212 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                    }
                                    else{
                                        if(!string.IsNullOrEmpty(Model.SearchString)){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p style=\"font-weight: bold;\">Kết quả tìm kiếm: ");
#nullable restore
#line 215 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                                                       Write(Model.SearchString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 216 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                        }
                                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p style=\"font-weight: bold;\">Kết quả tìm kiếm: Tất cả</p>\r\n");
#nullable restore
#line 219 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                        }
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""col-lg-4 col-md-4 text-right"">
                                <div class=""select-option"">
                                    <select class=""sorting"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b6d19dd14c312981d977dad77a3c4c4da28441520360", async() => {
                WriteLiteral("Default Sorting");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n                            </div>\r\n                            \r\n                        </div>\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"product-list\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 248 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                              
                                foreach(var sp in Model.ListSP){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-lg-4 col-sm-6\">\r\n                                        <div class=\"product-item\">\r\n                                            <div class=\"pi-pic\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 11556, "\"", 11583, 1);
#nullable restore
#line 253 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 11562, Url.Content(@sp.img), 11562, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 11584, "\"", 11590, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <ul>
                                                    <li class=""w-icon active""><a href=""#""><i class=""icon_bag_alt""></i></a></li>
                                                    <li class=""quick-view""><a");
            BeginWriteAttribute("href", " href=\"", 11854, "\"", 11890, 2);
            WriteAttributeValue("", 11861, "/Product/Index/", 11861, 15, true);
#nullable restore
#line 256 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 11876, sp.product_id, 11876, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi tiết</a></li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <div class=\"pi-text\">\r\n");
#nullable restore
#line 260 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                  
                                                    foreach(var k in Model.ListTH){
                                                        if(sp.brand_id == k.brand_id){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"catagory-name\">");
#nullable restore
#line 263 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                                                  Write(k.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 264 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                            break;
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                \r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 12749, "\"", 12785, 2);
            WriteAttributeValue("", 12756, "/Product/Index/", 12756, 15, true);
#nullable restore
#line 269 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
WriteAttributeValue("", 12771, sp.product_id, 12771, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <h5>");
#nullable restore
#line 270 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                   Write(sp.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                </a>\r\n                                                <div class=\"product-price\">\r\n                                                    ");
#nullable restore
#line 273 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                                Write(String.Format("{0:n0}", (int)sp.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 281 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Shop\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""loading-more"">
                        <i class=""icon_loading""></i>
                        <a href=""#"">
                            Loading More
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Shop Section End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewShopModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
