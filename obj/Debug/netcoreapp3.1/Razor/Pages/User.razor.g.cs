#pragma checksum "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f773a065283fb5d690552b074fc5dd244d5435"
// <auto-generated/>
#pragma warning disable 1591
namespace MQ_Assign.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using MQ_Assign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\MQ_Assign\_Imports.razor"
using MQ_Assign.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
using MQ_Assign.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddUser");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span>Add New\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h3>User</h3>");
#nullable restore
#line 12 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
 if (objuc == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading.....</em></p>");
#nullable restore
#line 15 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>ID</th>\r\n                <th>User Name</th>\r\n                <th>Full Name</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 27 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
             foreach (var ur in objuc)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
                         ur.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
                         ur.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
                         ur.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "EditUsers/" + (
#nullable restore
#line 34 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
                                                             ur.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "DeleteUsers/" + (
#nullable restore
#line 37 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
                                                               ur.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\User\source\repos\MQ_Assign\Pages\User.razor"
       

    List<MQ_Assign.Data.User> objuc;

    protected override async Task OnInitializedAsync()
    {
        objuc = await Task.Run(() => objUserService.GetUsers());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService objUserService { get; set; }
    }
}
#pragma warning restore 1591
