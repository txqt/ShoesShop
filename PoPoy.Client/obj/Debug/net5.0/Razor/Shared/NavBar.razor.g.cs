#pragma checksum "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa74db2c74042b7af4c4e40f57eb2b823435fe7d"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared.PaginationView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-main");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mid-header container");
            __builder.AddMarkupContent(4, "<a href=\"/\" class=\"logo\">Popoy</a>\r\n        ");
            __builder.AddMarkupContent(5, "<div class=\"search\"><input type=\"text\" placeholder=\"Search\">\r\n            <i class=\'bx bx-search-alt\'></i></div>\r\n        ");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "user-menu");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(8);
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "li");
                __builder2.AddAttribute(11, "class", "dropdown");
                __builder2.OpenElement(12, "a");
                __builder2.AddAttribute(13, "href", "/login?returnUrl=" + (
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                   _navigation.ToBaseRelativePath(_navigation.Uri)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "<i class=\'bx bx-user-circle\'></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "ul");
                __builder2.AddAttribute(17, "class", "dropdown-content");
                __builder2.AddAttribute(18, "style", "width:115px");
                __builder2.AddMarkupContent(19, "<li><a href=\"/register\">Đăng ký</a></li>\r\n                            ");
                __builder2.OpenElement(20, "li");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "/login?returnUrl=" + (
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                           _navigation.ToBaseRelativePath(_navigation.Uri)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "Đăng nhập");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(24, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(25, "li");
                __builder2.AddAttribute(26, "class", "dropdown");
                __builder2.OpenElement(27, "a");
                __builder2.AddAttribute(28, "href", "/user/profile/" + (
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                context.User.GetUserId()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "class", "h6");
                __builder2.AddContent(30, "Hello, ");
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
__builder2.AddContent(31, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "ul");
                __builder2.AddAttribute(34, "class", "dropdown-content");
                __builder2.AddAttribute(35, "style", "width:115px");
                __builder2.OpenElement(36, "li");
                __builder2.OpenElement(37, "a");
                __builder2.AddAttribute(38, "href", "/user/profile/" + (
#nullable restore
#line 30 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                        context.User.GetUserId()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "Thông tin tài khoản");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.AddMarkupContent(41, "<li><a href=\"/logout\">Đăng xuất</a></li>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<li><a href=\"#\"><i class=\'bx bx-bell\'></i></a></li>\r\n\r\n            ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "has_dropdown");
            __builder.AddMarkupContent(46, "<a href=\"/cart\"><i class=\'bx bx-cart\'></i></a>\r\n                ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "position-absolute top-0 start-100 translate-middle");
#nullable restore
#line 42 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
__builder.AddContent(49, cartCount);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\r\n                    <span class=\"visually-hidden\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "dropdowns messaging--dropdown");
            __builder.AddAttribute(54, "style", "background: white;");
            __builder.AddMarkupContent(55, "<div class=\"dropdown_module_header\"><h4>Giỏ hàng</h4>\r\n                        <a href=\"/cart\">Xem tất cả</a></div>");
#nullable restore
#line 51 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                     if (carts is null)
                    {


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PoPoy.Client.Shared.LoadingScreen>(56);
            __builder.CloseComponent();
#nullable restore
#line 54 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                        }
                    else if (carts.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<h2>Hiện tại không có sản phẩm nào trong giỏ hàng của bạn.</h2>");
#nullable restore
#line 57 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                                                        }
                    else
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                         foreach (var cart in carts)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "messages");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", "/product-detail/" + (
#nullable restore
#line 64 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                          cart.Product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "class", "message recent");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "message__actions_avatar");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "avatar");
#nullable restore
#line 67 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                             try
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                 if (cart.Product.ProductImages.Any())
                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "img");
            __builder.AddAttribute(68, "src", 
#nullable restore
#line 71 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                               cart.Product.ProductImages.FirstOrDefault().ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "alt");
            __builder.CloseElement();
#nullable restore
#line 72 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "src", (
#nullable restore
#line 75 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                               _config["BackendApiUrl"]

#line default
#line hidden
#nullable disable
            ) + "/uploads/no-photo-available.png");
            __builder.AddAttribute(72, "alt");
            __builder.CloseElement();
#nullable restore
#line 76 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                                                 



                                            }
                                            catch { }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "message_data");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "name_time");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "name");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "text-break text-wrap");
#nullable restore
#line 87 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
__builder.AddContent(82, cart.Product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                            <span class=\"time\"></span>\r\n                                            ");
            __builder.OpenElement(84, "p");
            __builder.AddMarkupContent(85, "Số lượng: ");
#nullable restore
#line 92 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
__builder.AddContent(86, cart.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 98 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
                         

                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Shared\NavBar.razor"
       
    private int cartCount;
    private List<Cart> carts;
    protected override async Task OnInitializedAsync()
    {
        cartCount = await GetCartCount();
        CartState.OnQuantityChanged += OnCountChanged;
        GetCart();
    }

    private async ValueTask<int> GetCartCount()
    {
        var carts = await _cartSvc.GetAllAsync();
        return carts.Sum(x => x.Quantity);
    }

    private void OnCountChanged(int count)
    {
        GetCart();
        cartCount = count;
        StateHasChanged();
    }

    private async void GetCart()
    {
        carts = await _cartSvc.GetAllAsync();
        await CartState.UpdateAsync();
    }
    public void Dispose()
        => CartState.OnQuantityChanged -= OnCountChanged;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartState CartState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService _cartSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService _productSvc { get; set; }
    }
}
#pragma warning restore 1591
