using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Shared.NavMenus
{
    public partial class NavMenuAccordion
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool ChildNavActive { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        private bool _collapsed;

        protected override void OnInitialized()
        {
            _collapsed = !ChildNavActive;
        }

        void Toggle()
        {
            _collapsed = !_collapsed;
        }
    }
}
