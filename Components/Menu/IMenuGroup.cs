namespace MenuComponent.Components.Menu
{
    public interface IMenuGroup: IMenuItem
    {
        List<IMenuItem> Childs { get; set; }
    }

}
