using MenuComponent.Components.Menu;

namespace MenuComponent.Data
{
    public class MenuSourceService
    {
        public Task<List<IMenuItem>> GetMenuItemstAsync()
        {
            return Task.FromResult( new List<IMenuItem>()
            {
                new MenuElement(){Title="element 1", Link="/1"},
                new MenuGroup()
                {
                    Title ="Group 1",
                    Childs = new List<IMenuItem>()
                    {
                        new MenuElement(){Title="element 1-1", Link="/1/1"},
                        new MenuElement(){Title="element 1-2", Link="/1/2"},
                        new MenuElement(){Title="element 1-3", Link="/1/3"},
                        new MenuGroup()
                        {
                            Title = "group 2",
                            Childs = new List<IMenuItem>()
                            {
                                new MenuElement(){Title="element 2-1", Link="/2/1"},
                                new MenuElement(){Title="element 2-2", Link="/2/2"},
                                new MenuElement(){Title="element 2-3", Link="/2/3"},
                                new MenuGroup()
                                {
                                    Title = "group 3",
                                    Childs = new List<IMenuItem>()
                                    {
                                        new MenuElement(){Title="element 3-1", Link="/3/1"},
                                        new MenuElement(){Title="element 3-2", Link="/3/2"},
                                        new MenuElement(){Title="element 3-3", Link="/3/3"},
                                    }
                                }
                            }
                        },
                        new MenuElement(){Title="element 1-4", Link="/1/4"},
                        new MenuElement(){Title="element 1-5", Link="/1/5"},
                        new MenuElement(){Title="element 1-6", Link="/1/6"}
                    }
                },
                new MenuElement(){Title="element 3", Link="/3"}
            }
            );
        }
    }
}