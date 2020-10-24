using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Shared.Components.Toolbars
{
    public partial class ActionToolbar
    {
        [Parameter]
        public RenderFragment Title { get; set; }

        [Parameter]
        public RenderFragment Actions { get; set; }
    }
}
