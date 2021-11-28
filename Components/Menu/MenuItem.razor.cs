using Microsoft.AspNetCore.Components;

namespace MenuComponent.Components.Menu
{
    public partial class MenuItem
    {
        [Parameter]
        public IMenuItem Item { get; set; }
        bool _isHidden = false;
    }
}
