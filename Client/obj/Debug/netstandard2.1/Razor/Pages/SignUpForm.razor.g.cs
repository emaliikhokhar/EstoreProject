#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b1ef1ca272a9a2cdc77d837734a2cf6a2e96d9"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUpForm")]
    public partial class SignUpForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\n                ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card card-signin my-5");
            __builder.AddMarkupContent(5, "\n                    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body  align-items-center");
            __builder.AddMarkupContent(8, "\n                        <br>\n                        ");
            __builder.AddMarkupContent(9, "<h2 class=\"card-title text-center mb-1\">Register</h2>\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                          seller

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "form-signin");
            __builder.AddAttribute(13, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                                                                FormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\n                            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-label-group");
                __builder2.AddMarkupContent(18, "\n                                ");
                __builder2.AddMarkupContent(19, "<label for=\"inputEmail\">Full Name</label>\n                                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "id", "fullName");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Full Name");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "autofocus", true);
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                                                              seller.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seller.Name = __value, seller.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                            <br>\n                            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-label-group");
                __builder2.AddMarkupContent(33, "\n                                ");
                __builder2.AddMarkupContent(34, "<label for=\"inputEmail\">Email address</label>\n                                ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "email");
                __builder2.AddAttribute(37, "id", "inputEmail");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Email address");
                __builder2.AddAttribute(40, "required", true);
                __builder2.AddAttribute(41, "autofocus", true);
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                                                                 seller.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seller.Email = __value, seller.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n                            <br>\n                            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-label-group  mb-1");
                __builder2.AddMarkupContent(48, "\n                                ");
                __builder2.AddMarkupContent(49, "<label for=\"inputPassword\">Password</label>\n                                ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "password");
                __builder2.AddAttribute(52, "id", "inputPassword");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "placeholder", "Password");
                __builder2.AddAttribute(55, "required", true);
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                                                                       seller.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seller.Password = __value, seller.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n                            <br>\n                            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-label-group");
                __builder2.AddMarkupContent(62, "\n                                ");
                __builder2.AddMarkupContent(63, "<label for=\"inputEmail\">Address</label>\n                                ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "type", "text");
                __builder2.AddAttribute(66, "id", "address");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "placeholder", "Address");
                __builder2.AddAttribute(69, "required", true);
                __builder2.AddAttribute(70, "autofocus", true);
                __builder2.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
                                                                             seller.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seller.Address = __value, seller.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n                            <br>\n                            ");
                __builder2.AddMarkupContent(75, "<button class=\"btn btn-lg btn-primary mb-1 btn-block text-uppercase\" type=\"submit\">Register</button>\n                            <hr class=\"my-4\">\n\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n            ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\SignUpForm.razor"
 
    public class Seller
    {
        public string Email { set; get; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { set; get; }
    }

    Seller seller = new Seller();

    void FormSubmitted()
    {
        Console.WriteLine("Email " + seller.Email + "Name " + seller.Name + "Password " + seller.Password + "Address " + seller.Address);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591