// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PoPoy.Client.Pages
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
#line 22 "D:\Myproject\CSharp\DATN3\PoPoy.Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

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
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Pages\CartShow.razor"
using PoPoy.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Pages\CartShow.razor"
using PoPoy.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Pages\CartShow.razor"
using PoPoy.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Pages\CartShow.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartShow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "D:\Myproject\CSharp\DATN3\PoPoy.Client\Pages\CartShow.razor"
        private List<Cart> carts;
    private bool buttonDisabled;
    private bool showButton = false;
    public bool IsUserLoggedIn = false;

    Address addressModel = new Address();
    PaymentModeModel paymentModel = new PaymentModeModel()
        {
            Name = "CashOnDelivery" // default value
        };

    List<string> rdOptions = new List<string> { "CashOnDelivery", "PayPal" };

    protected override async Task OnInitializedAsync()
    {
        var userId = await LocalStorage.GetItemAsync<Guid>("getUserId");
        carts = await CartService.GetAllAsync();
        await CartState.UpdateAsync();
        addressModel.UserId = userId;
    }

    private decimal CalcTotalAmount()
        => carts.Sum(x => x.CalcAmount());

    private int CalcTotalQuantity()
        => carts.Sum(x => x.Quantity);


    private async Task RemoveCart(Cart cart)
    {
        await CartService.RemoveAsync(cart.Product.Id);
        carts = await CartService.GetAllAsync();
        StateHasChanged();
    }
    //private async Task PayPalPayment()
    //{
    //    var total = CalcTotalAmount() * CalcTotalQuantity();
    //    var url = await AuthService.MakePayPalPayment((double)total);
    //    await CheckOut();
    //    NavigationManager.NavigateTo(url);
    //}
    private async Task CheckOut()
    {
        try
        {
            var userId = await LocalStorage.GetItemAsync<Guid>("getUserId");
            var address = await AuthService.GetAddress(userId);
            if (address != null)
            {
                var finalTotal = CalcTotalAmount() * CalcTotalQuantity();
                if (paymentModel.Name == "PayPal")
                {
                    carts.FirstOrDefault().AddressId = address.Id;
                    carts.FirstOrDefault().PayPalPayment = (double)finalTotal;
                    carts.FirstOrDefault().PaymentMode = paymentModel.Name;
                    var total = CalcTotalAmount() * CalcTotalQuantity();
                    var url = await AuthService.MakePayPalPayment((double)total);
                    NavigationManager.NavigateTo(url);
                }
                var productId = await LocalStorage.GetItemAsync<int>("getProductId");
                buttonDisabled = true;
                if (carts != null && carts.Count > 0)
                {
                    carts.FirstOrDefault().Price = CalcTotalAmount();
                    carts.FirstOrDefault().Quantity = CalcTotalQuantity();
                    carts.FirstOrDefault().PaymentMode = paymentModel.Name;
                    carts.FirstOrDefault().AddressId = address.Id;
                    carts.FirstOrDefault().ProductId = productId;
                }
                if (userId != null)
                {
                    carts.FirstOrDefault().UserId = userId;
                    addressModel.UserId = userId;
                }

                IsUserLoggedIn = await AuthService.IsUserAuthenticated();
                if (IsUserLoggedIn)
                {
                    var response = await AuthService.Checkout(carts);
                    if (response)
                    {
                        carts.Clear();
                        await CartService.RemoveAllAsync();
                        if (paymentModel.Name != "PayPal")
                        {
                            StateHasChanged();
                            NavigationManager.NavigateTo("/");
                            _toastSvc.ShowSuccess("Thanh toán thành công");
                        }
                    }
                }
                else
                {
                    await LocalStorage.SetItemAsync("checkoutAlert", "Cannot checkout probably!");
                    NavigationManager.NavigateTo("login");
                }
            }
            else
            {
                NavigationManager.NavigateTo($"/user/profile/{userId}");
                _toastSvc.ShowError("Mời nhập địa chỉ");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            buttonDisabled = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartState CartState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
    }
}
#pragma warning restore 1591