#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21febd94a49a74157579dd5161f075241077b277"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Website.Pages.Books
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
#nullable restore
#line 2 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/")]
    public partial class BooksIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Books Index</h3>\r\n<br>\r\n<hr>\r\n<br>");
#nullable restore
#line 11 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
 if (this.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(1);
            __builder.AddAttribute(2, "Message", "Loading Books...");
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Roles", "Administrator");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<a href=\"books/create\" class=\"btn btn-primary\"><span class=\"oi oi-plus\"></span>\r\n        Create New Book\r\n    </a>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n<br>\r\n<br>");
#nullable restore
#line 26 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
 if (this.Model != null && this.Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-responsive");
            __builder.AddMarkupContent(10, "<thead><tr><th>Title</th>\r\n                <th>Price</th>\r\n                <th>Author</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 38 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "uploads/" + (
#nullable restore
#line 42 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                                           book.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "style", "height:50px;width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 44 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                         book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 45 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                         book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 46 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                         book.Author?.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " ");
            __builder.AddContent(27, 
#nullable restore
#line 46 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                                                 book.Author?.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/books/details/" + (
#nullable restore
#line 48 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                                                 book.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddMarkupContent(33, "<span class=\"oi oi-book\"></span>\r\n                            View\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(35);
            __builder.AddAttribute(36, "Roles", "Administrator");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(38, "a");
                __builder2.AddAttribute(39, "href", "/books/update/" + (
#nullable restore
#line 53 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                                                    book.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "class", "btn btn-warning");
                __builder2.AddMarkupContent(41, "<span class=\"oi oi-pencil\"></span>\r\n                                Edit\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "href", "/books/delete/" + (
#nullable restore
#line 57 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
                                                    book.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "class", "btn btn-danger");
                __builder2.AddMarkupContent(46, "<span class=\"oi oi-delete\"></span>\r\n                                Delete\r\n                            ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
}
else if (this.Model != null && this.Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(47);
            __builder.AddAttribute(48, "Message", "There are no books in the data store. Click \'Create Book\' to begin.");
            __builder.CloseComponent();
#nullable restore
#line 71 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BooksIndex.razor"
       
    private IList<BookModel> Model;

    protected override async Task OnInitializedAsync()
    {
        this.Model = await this.bookRepo.Get(Endpoints.BookssEndpoint);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository bookRepo { get; set; }
    }
}
#pragma warning restore 1591