#pragma checksum "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b6d73b2276415a165ccaa28141078a26d913dd"
// <auto-generated/>
#pragma warning disable 1591
namespace appCheck.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using appCheck.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using appCheck.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\_Imports.razor"
using appCheck.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publication")]
    public partial class CreatePublication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreatePublication</h3>\r\n");
#nullable restore
#line 9 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
 if (publication_check != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "h1");
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
         publication_check.text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 12 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
} else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<h1>publication is null</h1>\r\n");
#nullable restore
#line 14 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                  publication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                               CreateNewPublication

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    \r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddMarkupContent(18, "<label>Text:</label>\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                     publication.text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => publication.text = __value, publication.text))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => publication.text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.appCheck.Client.Pages.CreatePublication.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 23 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                      () => publication.text

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.appCheck.Client.Pages.CreatePublication.TypeInference.CreateInputSelect_1(__builder2, 29, 30, "custom-select", 31, 
#nullable restore
#line 24 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                                            category_id

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category_id = __value, category_id)), 33, () => category_id, 34, (__builder3) => {
                    __builder3.AddMarkupContent(35, "\r\n");
#nullable restore
#line 25 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                 if (categories != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                     foreach (var category in categories)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(36, "                        ");
                    __builder3.OpenElement(37, "option");
                    __builder3.AddAttribute(38, "value", 
#nullable restore
#line 29 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                        category.id.ToString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(39, 
#nullable restore
#line 29 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                                                                  category.name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n");
#nullable restore
#line 30 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
                     
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(41, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.AddMarkupContent(45, "<button type=\"submit\">Create Publication</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Улан Ескендиров\source\repos\appCheck\appCheck\Client\Pages\CreatePublication.razor"
       
    Publication publication = new Publication();
    Category[] categories;
    string category_id;

    protected override async Task OnInitializedAsync()
    {
        int id = 1;
        await LoadPublication(id);
        await LoadCategories();
        StateHasChanged();
    }

    async Task CreateNewPublication()
    {
        if (category_id == null)
        {
            category_id = "1";
        }
        publication.categoryID = int.Parse(category_id);
        await Http.PostJsonAsync("publication/Create", publication);
        NavManager.NavigateTo("/");
        //await Http.SendJsonAsync(HttpMethod.Post, "publication/Create", publication);
    }

    async Task LoadCategories()
    {
        categories = await Http.GetJsonAsync<Category[]>("publication/category");
    }

    #region check
    Publication publication_check;

    async Task LoadPublication(int id)
    {
        string url = "publication/" + id;
        publication_check = await Http.GetJsonAsync<Publication>(url);
    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.appCheck.Client.Pages.CreatePublication
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
