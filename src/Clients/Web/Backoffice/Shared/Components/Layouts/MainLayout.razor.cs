using Microsoft.AspNetCore.Components;
using SkiResortManager.Backoffice.Shared.Events;

namespace SkiResortManager.Backoffice.Shared.Components.Layouts
{
    public partial class MainLayout
    {
        [Inject]
        public LockPageEvent LockPageEvent { get; set; }

        private bool _pageLocked = false;

        protected override void OnInitialized()
        {
            LockPageEvent.OnPageLock += () => LockPage(true);
            LockPageEvent.OnPageUnlock += () => LockPage(false);
        }

        private void LockPage(bool lockPage)
        {
            _pageLocked = lockPage;
            StateHasChanged();
        }
    }
}
