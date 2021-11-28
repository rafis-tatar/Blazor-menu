using Microsoft.AspNetCore.Components;

namespace MenuComponent.Components.Menu
{
    public partial class Menu
    {
        /// <summary>
        /// Источник данных для построения меню
        /// </summary>
        [Parameter]
        public List<IMenuItem> Source { get; set; }
    }
}
