#pragma checksum "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38aa7f253989f20a0e7ff34d2aae99377de9b73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38aa7f253989f20a0e7ff34d2aae99377de9b73e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405ffefc3cd786874472c586c5fa76147766a884", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.DTOs.CurrentUserDTO.DonHangDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Thanh toán khi nhận hàng", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Thanh toán qua thẻ ngân hàng", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "dcmacdinh", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "diachi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("intput_dcnh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Stylesheet", async() => {
                WriteLiteral("\r\n    <style>\r\n        .left_cart_select {\r\n            width: 100%;\r\n            margin: 0 6px 20px 0;\r\n            height: 40px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function CheckOutCart(){
            this.focus();
            var address = $(""#input_nhapdcnh"").val();
            $.ajax({
                url : ""/Cart/CheckOutCart"",
                type: ""POST"",
                dataType: ""json"",
                data:{
                    address: address
                },
                async: false,
                success: function(data){
                    if(data != 1){
                        Swal.fire({
                            type: ""error"",
                            title: ""Lỗi đặt hàng"",
                            html: data
                        });
                    }
                    else{
                        Swal.fire({
                            type: ""success"",
                            title: ""Đặt hàng thành công""
                        }).then((result) => {
                            // layout.js
                            LoadCartForLayOut();
                            $(""#sua_");
                WriteLiteral(@"listSP"").html("""");
                            $(""#tongsp"").html(""0"");
                            $(""#tongtien"").html(""0 Đ"");
                        });
                    }
                },
                error: function(e){
                    Swal.fire({
                        type: ""error"",
                        title: ""Lỗi đặt hàng => CheckOutCart"",
                        html: e.responseText
                    });
                }
            });
        }
        function onchange_dc(tag){
            if(tag.value == ""dcmacdinh""){
                $(""#intput_dcnh"").css(""display"", ""none"");
            }
            else if(tag.value == ""diachi""){
                $(""#intput_dcnh"").css(""display"", ""block"");
            }
        }
        function RemoveCart(idsp){
            $.ajax({
                url : """);
#nullable restore
#line 69 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                  Write(Url.Action("RemoveCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                type: ""POST"",
                dataType: ""json"",
                data: {
                    idsp: idsp
                },
                async: false,
                success: function(data){
                    if(data != null){
                        location.reload();
                    }
                },
                error: function(e){
                    alert(e.responseText);
                }
            });
        }
        function ChangeSL(tag, idsp){
            var slsp = tag.value;
            $.ajax({
                url : """);
#nullable restore
#line 89 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                  Write(Url.Action("UpdateSP"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                type: ""POST"",
                dataType: ""json"",
                data: {
                    idsp: idsp,
                    slsp: slsp
                },
                async: false,
                success: function(data){
                    if(data != null){
                        location.reload();
                    }
                },
                error: function(e){
                    alert(e.responseText);
                }
            });
        }
        $(document).ready(function(){
            $("".inc"").click(function(){
                var idsp = $(this).parent().parent().parent().find(""input"").val();
                $.ajax({
                    url : """);
#nullable restore
#line 111 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                      Write(Url.Action("TangSP"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    type: ""POST"",
                    dataType: ""json"",
                    data: {
                        idsp: idsp
                    },
                    async: false,
                    success: function(data){
                        if(data != null){
                            location.reload();
");
                WriteLiteral(@"                        }
                    },
                    error: function(e){
                        alert(e.responseText);
                    }
                });
            });
            $("".dec"").click(function(){
                var idsp = $(this).parent().parent().parent().find(""input"").val();
                $.ajax({
                    url : """);
#nullable restore
#line 158 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                      Write(Url.Action("GiamSP"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    type: ""POST"",
                    dataType: ""json"",
                    data: {
                        idsp: idsp
                    },
                    async: false,
                    success: function(data){
                        if(data != null){
                            location.reload();
");
                WriteLiteral("                        }\r\n                    },\r\n                    error: function(e){\r\n                        alert(e.responseText);\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n<!-- Breadcrumb Section Begin -->\r\n<div class=\"breacrumb-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"breadcrumb-text product-more\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e12821", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i> Trang chủ");
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
                    <span>Giỏ hàng</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb Section Begin -->
<!-- Shopping Cart Section Begin -->
<section class=""shopping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""cart-table"">
                    <table>
                        <thead>
                            <tr>
                                <th>Ảnh</th>
                                <th class=""p-name"">Tên sản phẩm</th>
                                <th>Giá</th>
                                <th>Số lượng</th>
                                <th>Tổng tiền</th>
                                <th><i class=""ti-close""></i></th>
                            </tr>
                        </thead>
                        <tbody id=""sua_listSP"">
");
#nullable restore
#line 238 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                              
                                int tongsp = 0;
                                long tongtien = 0;
                                if (Model != null)
                                {
                                    foreach (var q in Model.ListSP)
                                    {
                                        tongsp += q.soluong;
                                        tongtien += q.SP.price * q.soluong;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"cart-pic first-row\"><img");
            BeginWriteAttribute("src", " src=\"", 10820, "\"", 10849, 1);
#nullable restore
#line 248 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
WriteAttributeValue("", 10826, Url.Content(@q.SP.img), 10826, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10850, "\"", 10856, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                            <td class=\"cart-title first-row\">\r\n                                                <h5>");
#nullable restore
#line 250 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                               Write(q.SP.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            </td>\r\n                                            <td class=\"p-price first-row\">");
#nullable restore
#line 252 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                                                      Write(String.Format("{0:n0}", q.SP.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                                            <td class=\"qua-col first-row\">\r\n                                                <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 11327, "\"", 11351, 1);
#nullable restore
#line 254 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
WriteAttributeValue("", 11335, q.SP.product_id, 11335, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly style=""display: none;"" class=""input_none"" />
                                                <div class=""quantity"">
                                                    <div class=""pro-qty"">
                                                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 11629, "\"", 11647, 1);
#nullable restore
#line 257 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
WriteAttributeValue("", 11637, q.soluong, 11637, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onkeypress=\'return event.charCode >= 48 && event.charCode <= 57\' maxlength=\"3\"");
            BeginWriteAttribute("onchange", " onchange=\"", 11727, "\"", 11770, 3);
            WriteAttributeValue("", 11738, "ChangeSL(this,", 11738, 14, true);
#nullable restore
#line 257 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 11752, q.SP.product_id, 11753, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11769, ")", 11769, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    </div>\r\n                                                </div>\r\n                                            </td>\r\n                                            <td class=\"total-price first-row\">");
#nullable restore
#line 261 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                                                          Write(String.Format("{0:n0}", q.SP.price*q.soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                                            <td class=\"close-td first-row\"><i class=\"ti-close\"");
            BeginWriteAttribute("onclick", " onclick=\"", 12170, "\"", 12208, 3);
            WriteAttributeValue("", 12180, "RemoveCart(", 12180, 11, true);
#nullable restore
#line 262 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
WriteAttributeValue("", 12191, q.SP.product_id, 12191, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12207, ")", 12207, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 264 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-4\">\r\n");
            WriteLiteral("                        <div class=\"discount-coupon\">\r\n                            <h6>Phương thức thanh toán</h6>\r\n                            <select class=\"left_cart_select\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e20822", async() => {
                WriteLiteral("Thanh toán khi nhận hàng");
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e22032", async() => {
                WriteLiteral("Thanh toán qua thẻ ngân hàng(Đang xấy dựng)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n");
            WriteLiteral(@"                        </div>
                        <div class=""discount-coupon"">
                            <h6>Địa chỉ thanh toán</h6>
                            <select class=""left_cart_select"" onchange=""onchange_dc(this)"" id=""thay_doi_dia_chi"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e23683", async() => {
                WriteLiteral("Chọn địa chỉ mặc định của tài khoản để nhận hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e24917", async() => {
                WriteLiteral("Chọn địa chỉ nhận hàng khác");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa7f253989f20a0e7ff34d2aae99377de9b73e26167", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Nhập địa chỉ nhận hàng\" class=\"left_cart_select\" id=\"input_nhapdcnh\">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-lg-4 offset-lg-4"">
                        <div class=""proceed-checkout"">
                            <ul>
                                <li class=""subtotal"">Tổng sản phẩm <span id=""tongsp"">");
#nullable restore
#line 349 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                                                                Write(tongsp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li class=\"cart-total\">Thành tiền <span id=\"tongtien\">");
#nullable restore
#line 350 "G:\Git\CNPM_MyPham\CNPM_MyPham\Views\Cart\Index.cshtml"
                                                                                  Write(String.Format("{0:n0}", tongtien));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</span></li>
                            </ul>
                            <p onclick=""CheckOutCart(this)"" class=""proceed-btn"">Thanh toán</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Shopping Cart Section End -->
<!-- Partner Logo Section Begin -->
<div class=""partner-logo"">
    <div class=""container"">
        <div class=""logo-carousel owl-carousel"">
            <div class=""logo-item"">
                <div class=""tablecell-inner"">
                    <img src=""img/logo-carousel/logo-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 18458, "\"", 18464, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 18655, "\"", 18661, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 18852, "\"", 18858, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-4.png\"");
            BeginWriteAttribute("alt", " alt=\"", 19049, "\"", 19055, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-5.png\"");
            BeginWriteAttribute("alt", " alt=\"", 19246, "\"", 19252, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Partner Logo Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.DTOs.CurrentUserDTO.DonHangDto> Html { get; private set; }
    }
}
#pragma warning restore 1591