#pragma checksum "C:\DEV\BlazorPomodoro\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c97f6a717256be65a9dfbe6e86d741094bbef3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoYoutube.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DEV\BlazorPomodoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DEV\BlazorPomodoro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DEV\BlazorPomodoro\_Imports.razor"
using BlazorDemoYoutube;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DEV\BlazorPomodoro\_Imports.razor"
using BlazorDemoYoutube.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DEV\BlazorPomodoro\_Imports.razor"
using BlazorDemoYoutube.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\DEV\BlazorPomodoro\Pages\Settings.razor"
       
    private PomodoroSetttings _pomodoroSettings = new PomodoroSetttings();

    protected override async Task OnInitializedAsync()
    {

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        var json = await localStorage.GetItemAsync<string>("pomodoroSettings");

        if(json != null)
        {
            _pomodoroSettings = System.Text.Json.JsonSerializer.Deserialize<PomodoroSetttings>(json);
            StateHasChanged();
        }
    }

    private async Task FormSubmit()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(_pomodoroSettings);
        await localStorage.SetItemAsync("pomodoroSettings", json);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
