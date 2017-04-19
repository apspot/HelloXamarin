using System.Collections.Generic;

namespace HelloXamarin.Model
{
    class MainMenuItemGroup : List<MainMenuItem>
    {
        public string Title { get; set; }
        public MainMenuItemGroup(string title)
        {
            Title = title;
        }
    }
}
