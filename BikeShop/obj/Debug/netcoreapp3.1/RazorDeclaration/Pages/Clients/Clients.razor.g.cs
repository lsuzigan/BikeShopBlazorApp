#pragma checksum "C:\my-codes\BikeShop\BikeShop\Pages\Clients\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9916ebdfa4f0fa54ceac06340f669e4a46cf4795"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BikeShop.Pages.Clients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using BikeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using BikeShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\my-codes\BikeShop\BikeShop\Pages\Clients\Clients.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\my-codes\BikeShop\BikeShop\Pages\Clients\Clients.razor"
using BikeShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\my-codes\BikeShop\BikeShop\Pages\Clients\Clients.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\my-codes\BikeShop\BikeShop\Pages\Clients\Clients.razor"
       
    List<Client> allClients;

    protected override async Task OnInitializedAsync()
    {
        string sql = "select id, name, document, phoneNumber, email from client;";
        allClients = await _db.LoadData<Client, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _db { get; set; }
    }
}
#pragma warning restore 1591
