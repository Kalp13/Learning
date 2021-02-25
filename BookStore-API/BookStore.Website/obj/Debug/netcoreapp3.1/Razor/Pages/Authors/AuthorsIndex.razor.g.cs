#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b6868a561efbc19d26d112fc3cfda53de1223e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class AuthorsIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Authors Index</h3>\r\n<br>\r\n<hr>\r\n<br>\r\n\r\n");
#nullable restore
#line 10 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
 if (this.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(2);
            __builder.AddAttribute(3, "Message", "Loading Authors...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 13 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Roles", "Administrator");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<a href=\"authors/create\" class=\"btn btn-primary\">\r\n        <span class=\"oi oi-plus\"></span>\r\n        Create New Author\r\n    </a>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
#nullable restore
#line 22 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
 if (this.Model != null && this.Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-responsive");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<thead>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Biography</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 34 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
             foreach (var author in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                         author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                         author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/authors/details/" + (
#nullable restore
#line 40 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                                                   author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddMarkupContent(33, "\r\n                            <span class=\"oi oi-book\"></span>\r\n                            View\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(35);
            __builder.AddAttribute(36, "Roles", "Administrator");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.OpenElement(39, "a");
                __builder2.AddAttribute(40, "href", "/authors/update/" + (
#nullable restore
#line 45 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                                                      author.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "class", "btn btn-warning");
                __builder2.AddMarkupContent(42, "\r\n                                <span class=\"oi oi-pencil\"></span>\r\n                                Edit\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.OpenElement(44, "a");
                __builder2.AddAttribute(45, "href", "/authors/delete/" + (
#nullable restore
#line 49 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
                                                      author.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "class", "btn btn-danger");
                __builder2.AddMarkupContent(47, "\r\n                                <span class=\"oi oi-delete\"></span>\r\n                                Delete\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 56 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 59 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}
else if (this.Model != null && this.Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.AddMarkupContent(56, "<div class=\"alert alert-info\">\r\n        No Authors available.\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Authors\AuthorsIndex.razor"
       
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
