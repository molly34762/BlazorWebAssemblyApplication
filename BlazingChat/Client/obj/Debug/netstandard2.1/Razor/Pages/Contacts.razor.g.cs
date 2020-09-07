#pragma checksum "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463a52eb90960ecb104cd65815adf942f43f1a7f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingChat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
using BlazingChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
     foreach (var contact in ContactList) 
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "href", "/chat");
            __builder.AddAttribute(6, "class", "list-group-item list-group-item-action flex-column align-items-start");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
                                                                                                      contact.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddMarkupContent(9, "<span> </span> ");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
                                                                                                                                        contact.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 10 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Projects\BlazorWebAssemblyApplication\BlazingChat\Client\Pages\Contacts.razor"
       
    private WeatherForecast[] forecasts;
    private List<Contact> ContactList { get; set; } = new List<Contact>();

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        ContactList.Add(new Contact(1, "Julius", "Caesar"));
        ContactList.Add(new Contact(1, "Molly", "Liang"));
    }

    private void NavigateToChat()
    {
        NavigationManager.NavigateTo("/chat");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
