#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27629c309e1fdc663b28c364b8e97a669fee0cd6"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Controls
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
#line 11 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-4 col-sm-6");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "small-box-c");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "small-img-b");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "/");
            __builder.AddContent(11, " ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 8 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                                    imageAddress(image)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "dit-t clearfix");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "left-ti");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, 
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                     ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, "Under ");
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, 
#nullable restore
#line 13 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                                Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/");
            __builder.AddAttribute(34, "tabindex", "0");
            __builder.AddContent(35, "$");
            __builder.AddContent(36, 
#nullable restore
#line 15 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                                       Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "prod-btn");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<button type=\"submit\" class=\"btn btn-warning\">Update</button>\r\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddAttribute(46, "value", "Delete");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                                                                                 ()=>Delete(id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "p");
            __builder.AddContent(50, 
#nullable restore
#line 20 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
                Ratings

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, " likes");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\Products.razor"
        [Parameter]
            public string ProductName { set; get; }

            [Parameter]
            public string Category { set; get; }

            [Parameter]
            public string Price { set; get; }

            [Parameter]
            public int Ratings { set; get; }

            [Parameter]
            public int id { set; get; }

            [Parameter]
            public string image { get; set; }

            string imageAddress(string image)
            {
                string temp = "images/" + image + ".png";
                return temp;
            }



            private async Task Delete(int id)
            {
                var status = await svc.DeleteProduct(id);
                if (status.IsSuccessStatusCode)
                {
                  

                    NavigationManager.NavigateTo("/profile");


                }
                else
                {

                    NavigationManager.NavigateTo("/loginForm");

                }
            }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591
