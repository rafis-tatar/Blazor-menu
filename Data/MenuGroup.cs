using MenuComponent.Components.Menu;

namespace MenuComponent.Data
{
    public class MenuGroup : IMenuGroup
    {
        public List<IMenuItem> Childs { get; set; }
        public string Title { get; set; } = "menu group";
    }
}