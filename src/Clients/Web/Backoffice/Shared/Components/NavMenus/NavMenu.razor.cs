using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace SkiResortManager.Backoffice.Shared.Components.NavMenus
{
    public partial class NavMenu
    {
        [Inject]
        NavigationManager NavigationManager { get; init; }

        private string _baseRelativePath;

        protected override void OnInitialized()
        {
            NavigationManager.LocationChanged += LocationChanged;
            UpdatePaths();
        }

        private void LocationChanged(object sender, LocationChangedEventArgs e) => UpdatePaths();

        private void UpdatePaths()
        {
            _baseRelativePath = NavigationManager.ToBaseRelativePath(NavigationManager.Uri);
            StateHasChanged();
        }
    }
}
