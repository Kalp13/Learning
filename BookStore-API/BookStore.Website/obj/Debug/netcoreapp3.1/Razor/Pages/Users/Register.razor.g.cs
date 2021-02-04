#pragma checksum "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da0aa9361d6cc97d5466add7087454f57138cf55"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Website.Pages.Users
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<h3 class=\"card-title\">Register Now</h3>");
#nullable restore
#line 8 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
     if (!this.response)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"alert alert-danger\"><p>Something went wrong with the registration attempt.</p></div>");
#nullable restore
#line 13 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                         this.RegistrationModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                                                HandleRegistration

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label for=\"email\">Email Address</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "Id", "email");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                                                        this.RegistrationModel.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => this.RegistrationModel.EmailAddress = __value, this.RegistrationModel.EmailAddress))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => this.RegistrationModel.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __Blazor.BookStore.Website.Pages.Users.Register.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 21 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                          () => this.RegistrationModel.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label for=\"password\">Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Id", "password");
                __builder2.AddAttribute(32, "type", "password");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                                                                           this.RegistrationModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => this.RegistrationModel.Password = __value, this.RegistrationModel.Password))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => this.RegistrationModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __Blazor.BookStore.Website.Pages.Users.Register.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 26 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                          () => this.RegistrationModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"confirmpassword\">Confirm Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "Id", "confirmpassword");
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                                                                                  this.RegistrationModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => this.RegistrationModel.ConfirmPassword = __value, this.RegistrationModel.ConfirmPassword))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => this.RegistrationModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __Blazor.BookStore.Website.Pages.Users.Register.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 31 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
                                          () => this.RegistrationModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.AddMarkupContent(55, "<button type=\"submit\" class=\"btn btn-primary btn-block\">Register</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\VSTS\Learning\BookStore-API\BookStore.Website\Pages\Users\Register.razor"
       
    private UserRegistrationModel RegistrationModel = new UserRegistrationModel();

    bool response = true;

    private async Task HandleRegistration()
    {
        var response = await this.authRepository.Register(this.RegistrationModel);

        if (response)
        {
            this.navManager.NavigateTo("/LogIn");
        }
        else
        {
            this.response = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationRepository authRepository { get; set; }
    }
}
namespace __Blazor.BookStore.Website.Pages.Users.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
