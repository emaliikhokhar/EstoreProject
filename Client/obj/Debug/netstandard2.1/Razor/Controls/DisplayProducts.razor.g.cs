#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa905483e25d4fd631d92b55853dface78a969d5"
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
#line 1 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
    public partial class DisplayProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">All Products</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-group text-center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddAttribute(6, "style", "width: 18rem;");
            __builder.AddMarkupContent(7, "\r\n        <img src=\"/images/football.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 27 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "h6");
            __builder.AddContent(16, "Category: ");
            __builder.AddContent(17, 
#nullable restore
#line 28 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, "Price: ");
            __builder.AddContent(22, 
#nullable restore
#line 29 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<button class=\"btn btn-warning btn-block text-uppercase\" type=\"submit\">Update</button>\r\n            ");
            __builder.AddMarkupContent(26, "<button class=\"btn btn-danger btn-block text-uppercase\" type=\"submit\">Delete</button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card col");
            __builder.AddAttribute(31, "style", "width: 18rem;");
            __builder.AddMarkupContent(32, "\r\n        <img src=\"/images/LED.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-body");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "h5");
            __builder.AddAttribute(37, "class", "card-title");
            __builder.AddContent(38, 
#nullable restore
#line 37 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "h6");
            __builder.AddContent(41, "Category: ");
            __builder.AddContent(42, 
#nullable restore
#line 38 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "p");
            __builder.AddAttribute(45, "class", "card-text");
            __builder.AddContent(46, "Price: ");
            __builder.AddContent(47, 
#nullable restore
#line 39 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, "<button class=\"btn btn-warning btn-block text-uppercase\" type=\"submit\">Update</button>\r\n            ");
            __builder.AddMarkupContent(51, "<button class=\"btn btn-danger btn-block text-uppercase\" type=\"submit\">Delete</button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card col");
            __builder.AddAttribute(56, "style", "width: 18rem;");
            __builder.AddMarkupContent(57, "\r\n        <img src=\"/images/AC.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-body");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "h5");
            __builder.AddAttribute(62, "class", "card-title");
            __builder.AddContent(63, 
#nullable restore
#line 47 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "h6");
            __builder.AddContent(66, "Category: ");
            __builder.AddContent(67, 
#nullable restore
#line 48 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "class", "card-text");
            __builder.AddContent(71, "Price: ");
            __builder.AddContent(72, 
#nullable restore
#line 49 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.AddMarkupContent(75, "<button class=\"btn btn-warning btn-block text-uppercase\" type=\"submit\">Update</button>\r\n            ");
            __builder.AddMarkupContent(76, "<button class=\"btn btn-danger btn-block text-uppercase\" type=\"submit\">Delete</button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "card col");
            __builder.AddAttribute(81, "style", "width: 18rem;");
            __builder.AddMarkupContent(82, "\r\n        <img src=\"/images/Mobile.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "card-body");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "h5");
            __builder.AddAttribute(87, "class", "card-title");
            __builder.AddContent(88, 
#nullable restore
#line 57 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "h6");
            __builder.AddContent(91, "Category: ");
            __builder.AddContent(92, 
#nullable restore
#line 58 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "p");
            __builder.AddAttribute(95, "class", "card-text");
            __builder.AddContent(96, "Price: ");
            __builder.AddContent(97, 
#nullable restore
#line 59 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.AddMarkupContent(100, "<button class=\"btn btn-warning btn-block text-uppercase\" type=\"submit\">Update</button>\r\n            ");
            __builder.AddMarkupContent(101, "<button class=\"btn btn-danger btn-block text-uppercase\" type=\"submit\">Delete</button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Controls\DisplayProducts.razor"
       
    [Parameter]
    public string Title { set; get; }

    [Parameter]
    public string Category { set; get; }

    [Parameter]
    public int Price { set; get; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
