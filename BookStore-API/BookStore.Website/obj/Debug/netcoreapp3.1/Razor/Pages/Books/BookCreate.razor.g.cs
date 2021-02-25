#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b45de3a2582268f44118903df106f43277978e4"
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
#line 2 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
           [Authorize(Roles="Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/create")]
    public partial class BookCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Book</h3>\r\n<hr>\r\n<br>\r\n\r\n");
#nullable restore
#line 14 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
 if (this.isFailed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "        ");
            __builder.OpenComponent<BookStore.Website.Shared.ErrorMessage>(2);
            __builder.AddAttribute(3, "Message", "Something went wrong with the operation.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 17 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 19 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
 if (this.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<BookStore.Website.Shared.LoadingMessage>(7);
            __builder.AddAttribute(8, "Message", "Loading Author Details");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<h3 class=\"card-title\">Create New Author</h3>\r\n");
            __builder.AddContent(12, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                           CreateBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.AddMarkupContent(25, "<label for=\"title\">Book Title</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "id", "firstname");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                    Model.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Title = __value, Model.Title))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.AddMarkupContent(37, "<label for=\"isbn\">ISBN</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "id", "lastname");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                    Model.Isbn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Isbn = __value, Model.Isbn))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Isbn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.AddMarkupContent(49, "<label for=\"price\">Price</label>\r\n            ");
                __Blazor.BookStore.Website.Pages.Books.BookCreate.TypeInference.CreateInputNumber_0(__builder2, 50, 51, "form-control", 52, "biography", 53, 
#nullable restore
#line 40 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                      Model.Price

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Price = __value, Model.Price)), 55, () => Model.Price);
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.AddMarkupContent(61, "<label for=\"author\">Author</label>\r\n            ");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "id", "author");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                           Model.AuthorId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.AuthorId = __value, Model.AuthorId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", true);
                __builder2.AddContent(70, "-- Select Author --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
#nullable restore
#line 46 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                 if (Authors != null)
                {
                    foreach (var author in Authors)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "                        ");
                __builder2.OpenElement(73, "option");
                __builder2.AddAttribute(74, "value", 
#nullable restore
#line 50 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                        author.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(75, 
#nullable restore
#line 50 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                                    author.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(76, " ");
                __builder2.AddContent(77, 
#nullable restore
#line 50 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                                                      author.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 51 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.AddMarkupContent(85, "<label for=\"image\">Book Cover Photo</label>\r\n            ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(86);
                __builder2.AddAttribute(87, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 57 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                                 HandleFileSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n");
#nullable restore
#line 58 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
             if (isInvalidFileType)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(89, "                ");
                __builder2.OpenComponent<BookStore.Website.Shared.ErrorMessage>(90);
                __builder2.AddAttribute(91, "Message", "Invalid File Type");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 61 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
             if (!String.IsNullOrWhiteSpace(imageDataUrl))
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "                ");
                __builder2.OpenElement(94, "img");
                __builder2.AddAttribute(95, "src", 
#nullable restore
#line 64 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                           imageDataUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(96, "style", "height:100px; width:100px");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n");
#nullable restore
#line 65 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(98, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n        ");
                __builder2.AddMarkupContent(100, "<button class=\"btn btn-primary\" type=\"submit\">\r\n            <span class=\"oi oi-pencil\"></span>\r\n            Create\r\n        </button>\r\n        ");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
                          BackToList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "class", "btn btn-outline-secondary");
                __builder2.AddMarkupContent(104, "\r\n            <span class=\"oi oi-media-skip-backward\"></span>\r\n            Cancel\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 77 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Books\BookCreate.razor"
       
    private BookModel Model = new BookModel();
    private IList<AuthorModel> Authors;
    private bool isFailed = false;
    private IFileListEntry file;
    private string imageDataUrl;
    private bool isInvalidFileType;


    protected override async Task OnInitializedAsync()
    {
        Authors = await authorRepo.Get(Endpoints.AuthorsEndpoint);
    }

    private async Task CreateBook()
    {
        if (!isInvalidFileType)
        {
            var extension = Path.GetExtension(file.Name);
            var pictureId = Guid.NewGuid().ToString().Replace("-", "");
            var pictureName = $"{pictureId}{extension}";
            await fileUpload.UploadFile(file, pictureName).ConfigureAwait(false);
            Model.Image = pictureName;
            isFailed = !(await this.bookRepo.Create(Endpoints.BookssEndpoint, Model));
            if (!isFailed)
            {
                BackToList();
            }
        }
    }

    private async Task HandleFileSelection(IFileListEntry[] files) 
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            isInvalidFileType = !(file.Name.Contains(".jpg") || file.Name.Contains(".png") || file.Name.Contains(".jpeg"));
            if (!isInvalidFileType)
            {
                using (var stream = new MemoryStream())
                {
                    await file.Data.CopyToAsync(stream);
                    var reader = new StreamReader(file.Data);
                    var imageBase64Data = Convert.ToBase64String(stream.ToArray());
                    imageDataUrl = $"data:image/png;base64,{imageBase64Data}";
                }
            }
            else
            {
                imageDataUrl = String.Empty;
            }
        }
        else 
        {
            isInvalidFileType = false;
        }
    }

    private void BackToList(){
        this.navigationManager.NavigateTo("/authors");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository authorRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository bookRepo { get; set; }
    }
}
namespace __Blazor.BookStore.Website.Pages.Books.BookCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
