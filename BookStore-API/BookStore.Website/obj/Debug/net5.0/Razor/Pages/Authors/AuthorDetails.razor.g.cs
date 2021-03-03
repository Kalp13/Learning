#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fcd803db902510807d72d243f4ddd2ebc6693f"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Website.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BookStore.Website.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\VSTS\Learning\BookStore-API\BookStore.Website\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/details/{Id}")]
    public partial class AuthorDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View Author Details</h3>");
#nullable restore
#line 8 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
 if (int.Parse(Id) < 1 || string.IsNullOrWhiteSpace(Id))
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore.Website.Shared.ErrorMessage>(1);
            __builder.AddAttribute(2, "Message", "Invalid Selection. Please Try Again");
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
}
else if (this.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(3);
            __builder.AddAttribute(4, "Message", "Loading Author Details");
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-responsive");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "<td>First Name</td>\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                     Model.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<td>Last Name</td>\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                     Model.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<td>Biography</td>\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        <br>");
#nullable restore
#line 34 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
         if (Model.Books == null || Model.Books.Count < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "alert alert-dismissible alert-secondary");
            __builder.AddMarkupContent(26, "\r\n                No Books for ");
            __builder.AddContent(27, 
#nullable restore
#line 37 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                              Model.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " ");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                                               Model.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
        }
        else 
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card");
            __builder.AddAttribute(32, "style", "width: 18rem;");
            __builder.AddMarkupContent(33, "<div class=\"card-header\"><h4>Books</h4></div>\r\n                ");
            __builder.OpenElement(34, "ul");
            __builder.AddAttribute(35, "class", "list-group list-group-flush");
#nullable restore
#line 47 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                     foreach (var book in @Model.Books)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "list-group-item");
            __builder.AddContent(38, 
#nullable restore
#line 49 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                                                     book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, " - ");
            __builder.AddContent(40, 
#nullable restore
#line 49 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                                                                   book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", "/books/details/" + (
#nullable restore
#line 49 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                                                                                                       book.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "View");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 55 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
                  BackToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(48, "<span class=\"oi oi-media-skip-backward\"></span>\r\n    Back To List\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorDetails.razor"
       
    [Parameter]
    public string Id { get;  set; }

    private AuthorModel Model = new AuthorModel();

    protected override async Task OnInitializedAsync()
    {
        int id = Convert.ToInt32(this.Id);
        this.Model = await this.authorRepo.Get(Endpoints.AuthorsEndpoint, id);
    }

    private void BackToList(){
        this.navigationManager.NavigateTo("/authors");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository authorRepo { get; set; }
    }
}
#pragma warning restore 1591