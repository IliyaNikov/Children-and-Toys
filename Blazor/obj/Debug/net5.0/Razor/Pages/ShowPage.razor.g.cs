#pragma checksum "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e34fcd6b074c68d9431aaea3601dfa167564bbf1"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowPage")]
    public partial class ShowPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Show Children and Toys</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-2");
            __builder.AddMarkupContent(7, "<p>Filter by Gender: </p>\r\n            ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                           genderFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => genderFilter = __value, genderFilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", "M");
            __builder.AddContent(16, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "F");
            __builder.AddContent(20, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-outline-dark");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                                                            FilterData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Apply");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-md-2");
            __builder.AddMarkupContent(29, "<p>Filter by Favourite Toys: </p>\r\n            ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                           favoriteFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => favoriteFilter = __value, favoriteFilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "0");
            __builder.AddContent(38, "Not Favourite");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "1");
            __builder.AddContent(42, "Favourite");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-outline-dark");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                                                            FilterFavouriteData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Apply");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
 if (childrenToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<p><em>Loading children</em></p>");
#nullable restore
#line 36 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
}
else if (!childrenToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<p><em>No children to show</em></p>");
#nullable restore
#line 42 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
}
else {
    foreach(var child in childrenToShow)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "p");
            __builder.AddContent(51, 
#nullable restore
#line 46 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
            child.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " is ");
            __builder.AddContent(53, 
#nullable restore
#line 46 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                           child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, " years old and has:");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "table");
            __builder.AddMarkupContent(58, "<thead><tr><th>Name</th>\r\n                <th>Color</th>\r\n                <th>Condition</th>\r\n                <th>Favorite</th>\r\n                <th>Remove</th></tr></thead>\r\n            ");
            __builder.OpenElement(59, "tbody");
#nullable restore
#line 58 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
             foreach (var toy in toysToShow)
            {
                if(child.Id == toy.OwnerId)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "tr");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 63 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                             toy.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 64 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                             toy.Color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 65 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                             toy.Condition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 66 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                             toy.IsFavourite

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "td");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                                                () => RemoveToy(toy.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "<i class=\"oi oi-trash\" style=\"color:#ff0000\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\iliya\RiderProjects\DNPExam-281346\Blazor\Pages\ShowPage.razor"
       
    private IList<Toy> toysToShow;
    private IList<Toy> allToys;
    private IList<Child> allChildren;
    private IList<Child> childrenToShow;
    private string genderFilter;
    private int favoriteFilter;


    protected override async Task OnInitializedAsync()
    {
        allChildren = await ChildDataService.GetChildrenAsync();
        allToys = await ToyService.GetAllToysAsync();
        
        childrenToShow = allChildren;
        toysToShow = allToys;
    }

    public async Task RemoveToy(int id)
    {
        Toy toRemove = allToys.First(t => t.Id == id);
        ToyService.DeleteToyAsync(id);
        allToys.Remove(toRemove);
        toysToShow.Remove(toRemove);
    }

    public void FilterData()
    {
        childrenToShow = allChildren.Where(c =>
            !genderFilter.Equals("") && c.Gender.Equals(genderFilter) || genderFilter.Equals("")).ToList();
      
    }

    public void FilterFavouriteData()
    {
        bool chosen = true;
        if (favoriteFilter == 0)
        {
            chosen = false;
            toysToShow = allToys.Where(t =>
                chosen == t.IsFavourite).ToList();
        } 
        else if (favoriteFilter == 1)
        {
            chosen = true;
            toysToShow = allToys.Where(t =>
                chosen == t.IsFavourite).ToList();
        }
        else
        {
            toysToShow = allToys;

        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IChildService ChildDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IToyService ToyService { get; set; }
    }
}
#pragma warning restore 1591
