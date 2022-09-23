// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PoPoy.Admin.Pages.ProductView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\Pages\ProductView\EditProduct.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\Pages\ProductView\EditProduct.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateProduct/{Id}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "D:\Myproject\CSharp\DATN3\PoPoy.Admin\Pages\ProductView\EditProduct.razor"
       
    [Parameter]
    public string Id { get; set; }
    private int maxAllowedFiles = int.MaxValue;
    private long maxFileSize = long.MaxValue;
    private List<string> fileNames = new();
    private List<UploadResult> uploadResults = new();
    public ProductVM Product = new ProductVM();
    public bool ShowErrors = false;
    public string Message;

    protected async override Task OnInitializedAsync()
    {
        Product = await ProductService.GetProductById(int.Parse(Id));
    }

    private async Task UpdateProduct()
    {
        await ProductService.UpdateProduct(Product);
        NavigationManager.NavigateTo("/listProduct");
    }

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        using var content = new MultipartFormDataContent();

        foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
        {
            var fileContent = new StreamContent(file.OpenReadStream(maxFileSize));
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

            fileNames.Add(file.Name);

            content.Add(
                content: fileContent,
                name: "\"files\"",
                fileName: file.Name);
        }
        var response = await httpClient.PostAsync($"/api/product/upload-image?id={Id}", content);
        var newUploadResults = await response.Content.ReadFromJsonAsync<List<UploadResult>>();

        if (newUploadResults is not null)
        {
            uploadResults = uploadResults.Concat(newUploadResults).ToList();
        }
        Product = await ProductService.GetProductById(int.Parse(Id));
        StateHasChanged();
    }

    private async void DeleteImage(int productId)
    {
        await ProductService.DeleteFile(productId);
        Product = await ProductService.GetProductById(int.Parse(Id));
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591