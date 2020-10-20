using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Shared.Buttons
{
    public partial class MatIconButton
    {
        [Parameter]
        public string MatIcon { get; set; }

        [Parameter]
        public string AriaLabel { get; set; }
    }
}
