// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.RenderTree;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
  
    var output = string.Empty;
    if (__builder == null) output = "Builder is null!";
    else output = "Builder is not null!";

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Output: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
                output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
