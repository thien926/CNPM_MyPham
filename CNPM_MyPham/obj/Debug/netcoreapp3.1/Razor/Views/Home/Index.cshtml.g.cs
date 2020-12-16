#pragma checksum "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51010b90d4b8eb4ee996fcdc7fad8280f07b5223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51010b90d4b8eb4ee996fcdc7fad8280f07b5223", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405ffefc3cd786874472c586c5fa76147766a884", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewHomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

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
                WriteLiteral(@"
    <script>
        function ShopThemSPAjax(idsp){
            $.ajax({
                url : ""/Shop/ShopThemSPAjax"",
                type : ""POST"",
                dataType: ""json"",
                data: {
                    idsp: idsp
                },
                async: false,
                success: function(data){
                    if(data != null){
                        Swal.fire({
                            type: ""success"",
                            title : data
                        }).then((result) => {
                            // layout.js
                            LoadCartForLayOut();
                        });
                    }
                },
                error: function(e){
                    Swal.fire({
                            type: ""error"",
                            title: ""Lỗi thêm sản phẩm => ShopThemSPAjax"",
                            html: e.responseText
                        });
                }
            });
   ");
                WriteLiteral("     }\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<!-- Hero Section Begin -->
    <section class=""hero-section"">
        <div class=""hero-items owl-carousel"">
            <div class=""single-hero-items set-bg"" data-setbg=""/img/hero-1.jpg"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            
                            <h1>Black friday</h1>
                            
                            <a href=""/Shop/Index"" class=""primary-btn"">Shop Now</a>
                        </div>
                    </div>
                    
                </div>
            </div>
            <div class=""single-hero-items set-bg"" data-setbg=""/img/hero-2.jpg"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            
                            <h1>Black friday</h1>
                            
                            <a href=""/Shop/Index"" class=""pri");
            WriteLiteral(@"mary-btn"">Shop Now</a>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
    </section>
    <!-- Hero Section End -->

    

    <!-- Women Banner Section Begin -->
    <section class=""women-banner spad"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""product-large set-bg"" data-setbg=""/img/products/women-large.jpg"">
                        
                    </div>
                </div>
                <div class=""col-lg-8 offset-lg-1"">
                    <div class=""filter-control"" style=""font-size: 130%; font-weight: bold;"">
                        Sản phẩm bán chạy
                    </div>
                    <div class=""product-slider owl-carousel"">
");
#nullable restore
#line 92 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                          
                            foreach(var sp in Model.ListSPChay){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product-item\">\r\n                                    <div class=\"pi-pic\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3320, "\"", 3347, 1);
#nullable restore
#line 96 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 3326, Url.Content(@sp.img), 3326, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3348, "\"", 3354, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <ul>\r\n                                            <li class=\"w-icon active\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3476, "\"", 3516, 3);
            WriteAttributeValue("", 3486, "ShopThemSPAjax(", 3486, 15, true);
#nullable restore
#line 98 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 3501, sp.product_id, 3501, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3515, ")", 3515, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon_bag_alt\"></i></a></li>\r\n                                            <li class=\"quick-view\"><a");
            BeginWriteAttribute("href", " href=\"", 3626, "\"", 3662, 2);
            WriteAttributeValue("", 3633, "/Product/Index/", 3633, 15, true);
#nullable restore
#line 99 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 3648, sp.product_id, 3648, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi tiết</a></li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"pi-text\">\r\n");
#nullable restore
#line 103 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                          
                                            foreach(var k in Model.ListTH){
                                                if(sp.brand_id == k.brand_id){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"catagory-name\">");
#nullable restore
#line 106 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                                                          Write(k.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 107 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                                    break;
                                                }
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4417, "\"", 4453, 2);
            WriteAttributeValue("", 4424, "/Product/Index/", 4424, 15, true);
#nullable restore
#line 112 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 4439, sp.product_id, 4439, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h5>");
#nullable restore
#line 113 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                           Write(sp.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </a>\r\n                                        <div class=\"product-price\">\r\n                                            ");
#nullable restore
#line 116 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                        Write(String.Format("{0:n0}", sp.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 120 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Women Banner Section End -->
    <!-- Man Banner Section Begin -->
    <section class=""man-banner spad"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""filter-control"" style=""font-size: 130%; font-weight: bold;"">
                        Sản phẩm hot
                    </div>
                    <div class=""product-slider owl-carousel"">
");
#nullable restore
#line 137 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                          
                            foreach(var sp in Model.ListSPNoi){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product-item\">\r\n                                    <div class=\"pi-pic\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 5718, "\"", 5745, 1);
#nullable restore
#line 141 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 5724, Url.Content(@sp.img), 5724, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5746, "\"", 5752, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <ul>\r\n                                            <li class=\"w-icon active\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 5874, "\"", 5914, 3);
            WriteAttributeValue("", 5884, "ShopThemSPAjax(", 5884, 15, true);
#nullable restore
#line 143 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 5899, sp.product_id, 5899, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5913, ")", 5913, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon_bag_alt\"></i></a></li>\r\n                                            <li class=\"quick-view\"><a");
            BeginWriteAttribute("href", " href=\"", 6024, "\"", 6060, 2);
            WriteAttributeValue("", 6031, "/Product/Index/", 6031, 15, true);
#nullable restore
#line 144 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 6046, sp.product_id, 6046, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi tiết</a></li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"pi-text\">\r\n");
#nullable restore
#line 148 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                          
                                            foreach(var k in Model.ListTH){
                                                if(sp.brand_id == k.brand_id){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"catagory-name\">");
#nullable restore
#line 151 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                                                          Write(k.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 152 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                                    break;
                                                }
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6815, "\"", 6851, 2);
            WriteAttributeValue("", 6822, "/Product/Index/", 6822, 15, true);
#nullable restore
#line 157 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
WriteAttributeValue("", 6837, sp.product_id, 6837, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h5>");
#nullable restore
#line 158 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                           Write(sp.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </a>\r\n                                        <div class=\"product-price\">\r\n                                            ");
#nullable restore
#line 161 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                                        Write(String.Format("{0:n0}", sp.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 165 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-lg-3 offset-lg-1"">
                    <div class=""product-large set-bg m-large"" data-setbg=""/img/products/man-large.jpg"">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Man Banner Section End -->

    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewHomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
