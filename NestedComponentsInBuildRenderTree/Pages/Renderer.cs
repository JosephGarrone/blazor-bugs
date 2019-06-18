using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Layouts;
using Microsoft.AspNetCore.Components.RenderTree;

namespace NestedComponentsInBuildRenderTree.Pages
{
    public class Renderer : LayoutComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent(1, typeof(SomeControl));
            // Comment out lines to remove error
            builder.OpenComponent(2, typeof(SomeControl));
            builder.CloseComponent();
            // End of lines to comment out
            builder.CloseComponent();
        }
    }
}
