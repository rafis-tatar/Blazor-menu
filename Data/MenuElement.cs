using MenuComponent.Components.Menu;

namespace MenuComponent.Data
{
    public class MenuElement : IMenuElement
    {
        public string Link { get; set; } = "#";
        public string Title { get; set; } = "menu element";
    }
}