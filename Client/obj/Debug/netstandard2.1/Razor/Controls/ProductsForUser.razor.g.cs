#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3eaa982093028d2a5e957068b027882b0ca975d"
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
    public partial class ProductsForUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-4 col-sm-6");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "small-box-c");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "small-img-b");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "/productpage/" + (
#nullable restore
#line 4 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                                   id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, " ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 4 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                                                   imageAddress(image)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "dit-t clearfix");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "left-ti");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, 
#nullable restore
#line 8 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                     ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, "Under ");
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, 
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                                Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/");
            __builder.AddAttribute(34, "tabindex", "0");
            __builder.AddContent(35, "$");
            __builder.AddContent(36, 
#nullable restore
#line 11 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                                       Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "prod-btn");
            __builder.AddMarkupContent(41, "\n            ");
            __builder.AddMarkupContent(42, "<a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n            ");
            __builder.AddMarkupContent(43, "<a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n            ");
            __builder.OpenElement(44, "p");
            __builder.AddContent(45, 
#nullable restore
#line 16 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
                Ratings

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(46, " likes");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Controls\ProductsForUser.razor"
       
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


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
