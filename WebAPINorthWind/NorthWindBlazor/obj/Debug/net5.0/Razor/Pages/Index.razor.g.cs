#pragma checksum "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74e75c03100de57367827d57f2259b8d65622f6"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthWindBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using NorthWindBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using NorthWindBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-field");
            __builder.AddMarkupContent(4, "<label>ID: </label>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "id", "id");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                              Product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.Id = __value, Product.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-field");
            __builder.AddMarkupContent(14, "<label>Nombre: </label>\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "id", "id");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                              Product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.Name = __value, Product.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-field");
            __builder.AddMarkupContent(24, "<label>Precio Unitario: </label>\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "id", "id");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                              Product.UnitPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.UnitPrice = __value, Product.UnitPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          AddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddMarkupContent(37, "\r\n            Agregar un producto\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          ShowProducts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddMarkupContent(44, "\r\n            Mostrar productos\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          FindById

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddMarkupContent(51, "\r\n            Buscar por ID\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          UpdateProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddMarkupContent(58, "\r\n            Actualizar un producto\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          DeleteProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddMarkupContent(65, "\r\n            Eliminar un producto\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddContent(68, 
#nullable restore
#line 46 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
          Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "id", "products");
            __builder.AddAttribute(73, "class", "table table-bordered table-striped table-hover table-sm");
            __builder.AddMarkupContent(74, "<thead><tr><th>Id</th>\r\n                    <th>Name</th>\r\n                    <th>Price</th></tr></thead>\r\n            ");
            __builder.OpenElement(75, "tbody");
            __builder.AddContent(76, 
#nullable restore
#line 56 "C:\Users\migue\Desktop\ITPN\8vo_semestre\diseno_implementacion_sitios_web\Taller2\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                    TBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591