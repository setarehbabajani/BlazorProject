#pragma checksum "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ba7de317676a6b98efb3170d473e60190ae550"
// <auto-generated/>
#pragma warning disable 1591
namespace BuyStarOn.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
using BuyStarOn.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FinalProject\BuyStarOn\Client\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\nbody {background-color: #30BDCB;} \r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered");
            __builder.AddMarkupContent(3, "<thead><tr><th>Number of clothes you chosed</th>\r\n            <th>Price</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 28 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(7, number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 29 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(10, price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                                         Finish

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Finish The Buy");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, " \r\n\r\n");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-bordered");
            __builder.AddMarkupContent(20, "<thead><tr><th>Catagory</th>\r\n            <th>Number</th>\r\n            <th>Color</th>\r\n            <th>Price</th>\r\n            <th>Add to chart</th>\r\n            <th>Delete</th>\r\n            <th>Update</th></tr></thead>");
#nullable restore
#line 47 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
     if(Clothes != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
         foreach (var item in Clothes)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tbody");
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
#nullable restore
#line 53 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(24, item.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 54 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(27, item.Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 55 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(30, item.Color);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 56 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
__builder.AddContent(33, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                                              (()=>append(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                                              (() => DeleteArticle(item.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                                              (()=>UpdateArticle(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Update the Number");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, " \r\n");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                         GoAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Add New");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
                                         GoAdd2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "First Page");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\FinalProject\BuyStarOn\Client\Pages\HoleArticles.razor"
 
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
