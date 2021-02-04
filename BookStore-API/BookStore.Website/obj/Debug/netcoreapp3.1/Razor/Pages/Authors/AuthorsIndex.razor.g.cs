#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba99e76f9c70ca7ee44997da96623a724598cc2"
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
using BookStore.Website.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class AuthorsIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Authors Index</h3>");
#nullable restore
#line 7 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
 if (this.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(1);
            __builder.AddAttribute(2, "Message", "Loading Authors");
            __builder.CloseComponent();
#nullable restore
#line 10 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
 if (this.Model != null && this.Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-responsive");
            __builder.AddMarkupContent(5, "<thead><tr><th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Biography</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
             foreach (var author in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 27 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                         author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                         author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/authors/details/" + (
#nullable restore
#line 30 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                                                   author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddMarkupContent(18, "<span class=\"oi oi-book\"></span>\r\n                            View\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/authors/update/" + (
#nullable restore
#line 34 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                                                  author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-warning");
            __builder.AddMarkupContent(23, "<span class=\"oi oi-pencil\"></span>\r\n                            Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<a class=\"btn btn-danger\"><span class=\"oi oi-delete\"></span>\r\n                            Delete\r\n                        </a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}
else if (this.Model != null && this.Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<div class=\"alert alert-info\">\r\n        No Authors available.\r\n    </div>");
#nullable restore
#line 53 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
       
    private IList<AuthorModel> Model;

    protected override async Task OnInitializedAsync()
    {
        this.Model = await this.authorRepo.Get(Endpoints.AuthorsEndpoint);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository authorRepo { get; set; }
    }
}
#pragma warning restore 1591