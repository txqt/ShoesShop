#pragma checksum "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf493d0b492467452c03fa3ab38971eae8797b9"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Client.Pages.Ultilities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared.PaginationView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.UserAvatarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.ProductView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class Carosel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "hero");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "slider");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
             if (_productSvc.SlideProducts is null || _productSvc.SlideProducts.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PoPoy.Client.Shared.LoadingScreen>(6);
            __builder.CloseComponent();
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
            }
            else
            {
                foreach (var item in _productSvc.SlideProducts)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "slide");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "info");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "info-content");
            __builder.OpenElement(13, "h3");
            __builder.AddAttribute(14, "class", "top-down font-weight-bold");
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
__builder.AddContent(15, item.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                                ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "top-down trans-delay-0-4");
#nullable restore
#line 25 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
__builder.AddContent(19, item.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "top-down trans-delay-0-6");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "btn-flat btn-hover");
            __builder.AddAttribute(25, "href", "/product-detail/" + (
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                                                                                         item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<span>shop now</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "img top-down");
#nullable restore
#line 35 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                             if (item.ProductImages.Any())
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 37 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                                           item.ProductImages.FirstOrDefault().ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "alt");
            __builder.CloseElement();
#nullable restore
#line 38 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "src", (
#nullable restore
#line 41 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                                           _config["BackendApiUrl"]

#line default
#line hidden
#nullable disable
            ) + "/uploads/no-photo-available.png");
            __builder.AddAttribute(35, "alt");
            __builder.CloseElement();
#nullable restore
#line 42 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        \r\n        ");
            __builder.AddMarkupContent(37, "<button class=\"slide-controll slide-next\"><i class=\'bx bxs-chevron-right\'></i></button>\r\n        ");
            __builder.AddMarkupContent(38, "<button class=\"slide-controll slide-prev\"><i class=\'bx bxs-chevron-left\'></i></button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\Myproject\CSharp\DATN2\ShoesWebSiteBlazor\PoPoy.Client\Pages\Ultilities\Carosel.razor"
       
    private IJSObjectReference MyJsModule { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await GetProduct();
        var timer = new System.Threading.Timer((_) =>
        {
            InvokeAsync(async () =>
            {
                // Add your update logic here
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./js/index2.js");
                // Update the UI
                StateHasChanged();
            });
        }, null, 0, 1000);
    }
    public async Task GetProduct()
    {
        await _productSvc.GetProductForSlide();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService _productSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591