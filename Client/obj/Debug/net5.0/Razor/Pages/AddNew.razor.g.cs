#pragma checksum "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fdb005e93eebce402864a59a086b6a412741b39"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddNewOne")]
    public partial class AddNew : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                  article

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                                           AddArticle

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "p");
                __builder2.AddMarkupContent(9, "<label> Category:</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                            article.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Category = __value, article.Category))));
                __builder2.AddAttribute(13, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => article.Category));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "p");
                __builder2.AddMarkupContent(16, "<label>Color:</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                            article.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Color = __value, article.Color))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => article.Color));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    \r\n    ");
                __builder2.OpenElement(22, "p");
                __builder2.AddMarkupContent(23, "<label>Price:</label>\r\n    ");
                __Blazor.BuyStarOn.Client.Pages.AddNew.TypeInference.CreateInputNumber_0(__builder2, 24, 25, 
#nullable restore
#line 16 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                              article.Price

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Price = __value, article.Price)), 27, () => article.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.OpenElement(29, "p");
                __builder2.AddMarkupContent(30, "<label>Count:</label>\r\n    ");
                __Blazor.BuyStarOn.Client.Pages.AddNew.TypeInference.CreateInputNumber_1(__builder2, 31, 32, 
#nullable restore
#line 19 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                              article.Count

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Count = __value, article.Count)), 34, () => article.Count);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n    ");
                __builder2.AddMarkupContent(36, "<button type=\"submit\">Add</button>\r\n    ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "type", "submit");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
                                      Go

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(40, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.AddMarkupContent(42, "<style>\r\nbody {background-color: #64ACCE;} \r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\FinalProject\BuyStarOn\Client\Pages\AddNew.razor"
       
    private Articles article = new Articles();
    private string error = "";
    private void Go()
    {
        NavigationManager.NavigateTo("/HoleArticles");
    }
    public async Task AddArticle()
    {
        var URL = @"http://localhost:5001/api/Clothe/AddNewClotheToDB";
        await Client.PostAsJsonAsync<Articles>(URL , article);
        NavigationManager.NavigateTo("/HoleArticles");
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager MyNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Client { get; set; }
    }
}
namespace __Blazor.BuyStarOn.Client.Pages.AddNew
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
