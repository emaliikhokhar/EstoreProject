#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\EstoreProject\EstoreProject\Client\Pages\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd47e1addd2afeed37e7cd275d3edb0a9fefd403"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""modal fade lug"" id=""myModal"" role=""dialog"">
         <div class=""modal-dialog"">
             Modal content
            <div class=""modal-content"">
               <div class=""modal-header"">
                  <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                  <h4 class=""modal-title"">Change</h4>
               </div>
               <div class=""modal-body"">
                  <ul>
                     <li><a href=""#""><img src=""images/flag-up-1.png"" alt> United States</a></li>
                     <li><a href=""#""><img src=""images/flag-up-2.png"" alt> France </a></li>
                  </ul>
               </div>
            </div>
         </div>
      </div>
      ");
            __builder.AddMarkupContent(1, @"<div id=""sidebar"" class=""top-nav"">
         <ul id=""sidebar-nav"" class=""sidebar-nav"">
            <li><a href=""#"">Help</a></li>
            <li><a href=""#"">How it works</a></li>
            <li><a href=""#"">Chamb for Business</a></li>
         </ul>
      </div>
      ");
            __builder.AddMarkupContent(2, @"<div class=""furniture-box"">
         <div class=""terms-title"">
            <div class=""container"">
               <div class=""row"">
                  <ol class=""breadcrumb"">
                     <li><a href=""#"">Forntpage </a></li>
                     <li class=""active"">Furniture</li>
                  </ol>
               </div>
            </div>
         </div>
      </div>
      ");
            __builder.AddMarkupContent(3, "<div class=\"furniture-box\">\n         <div class=\"container\">\n            <div class=\"row\">\n               <div class=\"furniture-main\">\n                  <h2>Furniture</h2>\n                  <div class=\"col-md-3 col-sm-4\">\n                     <div class=\"furniture-left\">\n                        <h3>Filter Products</h3>\n                        <div class=\"by-box\">\n                           <h5>By price</h5>\n                           <div id=\"slider-range\"></div>\n                           <p>\n                              <input type=\"text\" id=\"amount\" readonly style>\n                           </p>\n                        </div>\n                        <div class=\"by-com\">\n                           <h5>By company</h5>\n                           <div class=\"list-b\">\n                              <div id=\"boxscroll\">\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox1\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox1\">\n                                    Adana Cimento\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox2\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox2\">\n                                    Akbank\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox3\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox3\">\n                                    Alvimedica\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox4\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox4\">\n                                    Arcelik\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox5\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox5\">\n                                    Askam\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox6\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox6\">\n                                    Salcano\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox7\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox7\">\n                                    Sedona\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox8\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox8\">\n                                    Sisecam\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox9\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox9\">\n                                    Su Marine Yachts\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox10\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox10\">\n                                    Beko\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox11\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox11\">\n                                    Kale Celik Esya\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox12\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox12\">\n                                    Default\n                                    </label>\n                                 </div>\n                                 <div class=\"form-check\">\n                                    <input id=\"checkbox13\" class=\"filled-in chk-col-blue\" type=\"checkbox\">\n                                    <label for=\"checkbox13\">\n                                    Default\n                                    </label>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                        <div class=\"left-list-f\">\n                           <div class=\"panel-group\" id=\"accordion\">\n                              <div class=\"panel panel-default\">\n                                 <div class=\"panel-heading\">\n                                    <h4 data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse1\" class=\"panel-title expand\">\n                                       <div class=\"right-arrow pull-right\"><span class=\"caret\"></span></div>\n                                       <a href=\"#\">Sort by</a>\n                                    </h4>\n                                 </div>\n                                 <div id=\"collapse1\" class=\"panel-collapse collapse\">\n                                    <div class=\"panel-body\">Lorem ipsum dolor sit amet,</div>\n                                 </div>\n                              </div>\n                              <div class=\"panel panel-default\">\n                                 <div class=\"panel-heading\">\n                                    <h4 data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse2\" class=\"panel-title expand\">\n                                       <div class=\"right-arrow pull-right\"><span class=\"caret\"></span></div>\n                                       <a href=\"#\">Ships from(country)</a>\n                                    </h4>\n                                 </div>\n                                 <div id=\"collapse2\" class=\"panel-collapse collapse\">\n                                    <div class=\"panel-body\">Lorem ipsum dolor sit amet,</div>\n                                 </div>\n                              </div>\n                              <div class=\"panel panel-default\">\n                                 <div class=\"panel-heading\">\n                                    <h4 data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse3\" class=\"panel-title expand\">\n                                       <div class=\"right-arrow pull-right\"><span class=\"caret\"></span></div>\n                                       <a href=\"#\">Style</a>\n                                    </h4>\n                                 </div>\n                                 <div id=\"collapse3\" class=\"panel-collapse collapse\">\n                                    <div class=\"panel-body\">Lorem ipsum dolor sit amet,</div>\n                                 </div>\n                              </div>\n                              <div class=\"panel panel-default\">\n                                 <div class=\"panel-heading\">\n                                    <h4 data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse4\" class=\"panel-title expand\">\n                                       <div class=\"right-arrow pull-right\"><span class=\"caret\"></span></div>\n                                       <a href=\"#\">Pattern type</a>\n                                    </h4>\n                                 </div>\n                                 <div id=\"collapse4\" class=\"panel-collapse collapse\">\n                                    <div class=\"panel-body\">Lorem ipsum dolor sit amet,</div>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                     </div>\n                  </div>\n                  <div class=\"col-md-6 col-sm-8\">\n                     <div class=\"furniture-middle\">\n                        <div class=\"big-box\">\n                           <div class=\"big-img-box\">\n                              <img src=\"images/lag-60.png\" alt=\"#\">\n                           </div>\n                           <div class=\"big-dit-b clearfix\">\n                              <div class=\"col-md-6\">\n                                 <div class=\"left-big\">\n                                    <h3>Etiam sit amet urna semper, auctor arcu id</h3>\n                                    <p>By <span>Kale Celik Esya</span> under <span>Chairs</span></p>\n                                    <div class=\"prod-btn\">\n                                       <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                       <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                       <p>23 likes</p>\n                                    </div>\n                                 </div>\n                              </div>\n                              <div class=\"col-md-6\">\n                                 <div class=\"right-big-b\">\n                                    <div class=\"tight-btn-b clearfix\">\n                                       <a class=\"view-btn\" href=\"#\">View</a>\n                                       <a href=\"#\">$320</a>\n                                    </div>\n                                    <div class=\"like-list\">\n                                       <ul>\n                                          <li>\n                                             <div class=\"im-b\"><img class src=\"images/list-img-01.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-02.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-03.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-04.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-05.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-06.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><i class=\"fa fa-ellipsis-h\" aria-hidden=\"true\"></i></div>\n                                          </li>\n                                       </ul>\n                                    </div>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                        <div class=\"row cat-pd\">\n                           <div class=\"col-md-6 col-sm-6\">\n                              <div class=\"small-box-c\">\n                                 <div class=\"small-img-b\">\n                                    <img src=\"images/tr1.png\" alt=\"#\">\n                                 </div>\n                                 <div class=\"dit-t clearfix\">\n                                    <div class=\"left-ti\">\n                                       <h4>Aenean luctus lacus</h4>\n                                       <p>By <span>Beko</span> under <span>Lights</span></p>\n                                    </div>\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\n                                 </div>\n                                 <div class=\"prod-btn\">\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                    <p>23 likes</p>\n                                 </div>\n                              </div>\n                           </div>\n                           <div class=\"col-md-6 col-sm-6\">\n                              <div class=\"small-box-c\">\n                                 <div class=\"small-img-b\">\n                                    <img src=\"images/tr2.png\" alt=\"#\">\n                                 </div>\n                                 <div class=\"dit-t clearfix\">\n                                    <div class=\"left-ti\">\n                                       <h4>Sed vestibulum</h4>\n                                       <p>By <span>Beko</span> under <span>Chairs</span></p>\n                                    </div>\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\n                                 </div>\n                                 <div class=\"prod-btn\">\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                    <p>23 likes</p>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                        <div class=\"big-box\">\n                           <div class=\"big-img-box\">\n                              <img src=\"images/lag-61.png\" alt>\n                           </div>\n                           <div class=\"big-dit-b clearfix\">\n                              <div class=\"col-md-6\">\n                                 <div class=\"left-big\">\n                                    <h3>Aenean luctus lacus</h3>\n                                    <p>By <span>Kale Celik Esya</span> under <span>Chairs</span></p>\n                                    <div class=\"prod-btn\">\n                                       <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                       <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                       <p>23 likes</p>\n                                    </div>\n                                 </div>\n                              </div>\n                              <div class=\"col-md-6\">\n                                 <div class=\"right-big-b\">\n                                    <div class=\"tight-btn-b clearfix\">\n                                       <a class=\"view-btn\" href=\"#\">View</a>\n                                       <a href=\"#\">$320</a>\n                                    </div>\n                                    <div class=\"like-list\">\n                                       <ul>\n                                          <li>\n                                             <div class=\"im-b\"><img class src=\"images/list-img-01.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-02.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-03.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-04.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-05.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><img src=\"images/list-img-06.png\" alt></div>\n                                          </li>\n                                          <li>\n                                             <div class=\"im-b\"><i class=\"fa fa-ellipsis-h\" aria-hidden=\"true\"></i></div>\n                                          </li>\n                                       </ul>\n                                    </div>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                        <div class=\"row cat-pd\">\n                           <div class=\"col-md-6 col-sm-6\">\n                              <div class=\"small-box-c\">\n                                 <div class=\"small-img-b\">\n                                    <img src=\"images/tr3.png\" alt=\"#\">\n                                 </div>\n                                 <div class=\"dit-t clearfix\">\n                                    <div class=\"left-ti\">\n                                       <h4>Sed vestibulum</h4>\n                                       <p>By <span>Beko</span> under <span>Lights</span></p>\n                                    </div>\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\n                                 </div>\n                                 <div class=\"prod-btn\">\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                    <p>23 likes</p>\n                                 </div>\n                              </div>\n                           </div>\n                           <div class=\"col-md-6 col-sm-6\">\n                              <div class=\"small-box-c\">\n                                 <div class=\"small-img-b\">\n                                    <img src=\"images/tr4.png\" alt=\"#\">\n                                 </div>\n                                 <div class=\"dit-t clearfix\">\n                                    <div class=\"left-ti\">\n                                       <h4>Aenean luctus lacus</h4>\n                                       <p>By <span>Beko</span> under <span>Chairs</span></p>\n                                    </div>\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\n                                 </div>\n                                 <div class=\"prod-btn\">\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\n                                    <p>23 likes</p>\n                                    <p>23 likes</p>\n                                 </div>\n                              </div>\n                           </div>\n                        </div>\n                     </div>\n                  </div>\n                  <div class=\"col-md-3 hidden-xs\">\n                     <div class=\"furniture-right\">\n                        <h3>Subcategories</h3>\n                        <div class=\"right-list-f\">\n                           <ul>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/1.png\" alt=\"#\"> Chairs</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/2.png\" alt=\"#\"> Office chairs</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/1.png\" alt> Special chairs</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/4.png\" alt> Living room</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/5.png\" alt> Room furniture</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/2.png\" alt> Tv Furniture</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/11.png\" alt> Office Chairs</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/10.png\" alt> Special lights</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/4.png\" alt> Home office</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/10.png\" alt> Kids furniture</a></li>\n                              <li><a href=\"#\"><img width=\"32\" src=\"images/product/11.png\" alt> Accessories</a></li>\n                           </ul>\n                        </div>\n                     </div>\n                  </div>\n                  <div class=\"loding-box\">\n                     <a href=\"#\">\n                        <div class=\"sk-wave\">\n                           <div class=\"sk-rect sk-rect1\"></div>\n                           <div class=\"sk-rect sk-rect2\"></div>\n                           <div class=\"sk-rect sk-rect3\"></div>\n                           <div class=\"sk-rect sk-rect4\"></div>\n                           <div class=\"sk-rect sk-rect5\"></div>\n                        </div>\n                        <span>Loding more awesome products...</span>\n                     </a>\n                  </div>\n               </div>\n            </div>\n         </div>\n      </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591