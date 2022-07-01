// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BuyStarOn.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using BuyStarOn.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\FinalProject\BuyStarOn\Client\_Imports.razor"
using BuyStarOn.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/HoleArticles")]
    public partial class HoleArticles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "d:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
 
    public int number =0;
    public int price=0;
    List<Articles> Clothes {get; set;} 
    private Articles article = new Articles();
    public Articles array1=new Articles(){Category="Pants",Count = 2,Color="blue", Price=129000};
    public Articles array2=new Articles(){Category="T_Shirts",Count = 0,Color="black", Price=189000};
    public void append(Articles x)
    {
        if(x.Count > 0)
        {
            ShopList.ShList.Add(x);
            number++;
            x.Count--;
            price += x.Price;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        var URL = @"http://localhost:5001/api/Clothe/getAllClothes";
        Clothes = await Client.GetFromJsonAsync<List<Articles>>(URL);
    }
    private void GoAdd()
    {
        navi.NavigateTo("/AddNewOne");
    }
    private void GoAdd2()
    {
        navi.NavigateTo("/");
    }
    private void Finish()
    {
        navi.NavigateTo("/Form");
    }

    public async Task DeleteArticle(int clotheid)
    {
        var a = Clothes.First(x => x.Id == clotheid);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {a.Category} with {a.Color} Color?"))
        {
            await Client.DeleteAsync($"http://localhost:5001/api/Clothe/{clotheid}");
            await OnInitializedAsync();
        }
    }

    public Articles NewArticle(Articles a)
    {
        a.Count++;
        return a;
    }

    public async Task UpdateArticle(Articles article)
    {
        var URL = @"http://localhost:5001/api/Clothe/UpdateArticle";
        await Client.PutAsJsonAsync<Articles>(URL,NewArticle(article));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navi { get; set; }
    }
}
#pragma warning restore 1591
