// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.Website.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\Pages\Books\BookDelete.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\Pages\Books\BookDelete.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/delete/{id}")]
    public partial class BookDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\VSTS\Kalp13\Learning\BookStore-API\BookStore.Website\Pages\Books\BookDelete.razor"
       
    [Parameter]
    public string Id { get;  set; }

    private BookModel Model = new BookModel();
    private bool isFailed = false;

    protected override async Task OnInitializedAsync()
    {
        int id = Convert.ToInt32(this.Id);
        this.Model = await this.bookRepo.Get(Endpoints.BookssEndpoint, id);
    }

    protected async Task DeleteBook()
    {
        fileUpload.RemoveFile(this.Model.Image);
        isFailed = !(await bookRepo.Delete(Endpoints.BookssEndpoint, Model.Id));

        if(!isFailed)
        {
            this.BackToList();
      }
    }

    private void BackToList()
    {
        this.navigationManager.NavigateTo("/books");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository bookRepo { get; set; }
    }
}
#pragma warning restore 1591
