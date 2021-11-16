// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.WASM.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BookStore.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BookStore.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BookStore.WASM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BookStore.WASM.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BookStore.WASM.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\Pages\Books\BookUpdate.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\Pages\Books\BookUpdate.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/update/{id}")]
    public partial class BookUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\VSTS\Learning\BookStore-API\BookStore.WASM\Pages\Books\BookUpdate.razor"
       
    [Parameter]
    public string Id { get;  set; }

    private BookModel Model = new BookModel();
    private IList<AuthorModel> Authors;
    private bool isFailed = false;
    private IFileListEntry file;
    private string imageDataUrl;
    private bool isInvalidFileType;
    private bool isFileChanged = false;

    protected override async Task OnInitializedAsync()
    {
        int id = Convert.ToInt32(this.Id);
        Authors = await authorRepo.Get(Endpoints.AuthorsEndpoint);
        this.Model = await this.bookRepo.Get(Endpoints.BookssEndpoint, id);
    }

    private async Task UpdateBook()
    {
        if (!isInvalidFileType)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file?.Name);
                var pictureId = Guid.NewGuid().ToString().Replace("-", "");
                var pictureName = $"{pictureId}{extension}";
                await fileUpload.UploadFile(file, pictureName).ConfigureAwait(false);
                Model.Image = pictureName;
            }
            else if (isFileChanged && file == null)
            {
                Model.Image = String.Empty;
            }

            isFailed = !(await this.bookRepo.Update(Endpoints.BookssEndpoint, Model, Model.Id));
            if (!isFailed)
            {
                BackToList();
            }
        }
    }

    private void BackToList(){
        this.navigationManager.NavigateTo("/books");
    }

    private async Task HandleFileSelection(IFileListEntry[] files) 
    {
        file = files.FirstOrDefault();
        isFileChanged = true;
        if (file != null)
        {
            var name = file.Name;
            isInvalidFileType = !(file.Name.Contains(".jpg") || file.Name.Contains(".png") || file.Name.Contains(".jpeg"));
            if (!isInvalidFileType)
            {
                var stream = new MemoryStream();
                await file.Data.CopyToAsync(stream);
                var reader = new StreamReader(file.Data);
                var imageBase64Data = Convert.ToBase64String(stream.ToArray());
                imageDataUrl = string.Format("data:image/png;base64,{0}", imageBase64Data);
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository authorRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository bookRepo { get; set; }
    }
}
#pragma warning restore 1591
