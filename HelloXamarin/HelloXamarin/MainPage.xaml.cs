using HelloXamarin.Model;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<MainMenuItemGroup>
            {
                new MainMenuItemGroup("Excercises")
                {
                    new MainMenuItem("XAML essentials excercise (quotes)", () => { return new QuotesPage(); }),
                    new MainMenuItem("Stack layout excercise 1", () => { return new StackExcercise1Page(); }),
                    new MainMenuItem("Stack layout excercise 2", () => { return new StackExcercise2Page(); }),
                    new MainMenuItem("Grid excercise 1", () => { return new GridExcercise1Page(); }),
                    new MainMenuItem("Grid excercise 2", () => { return new GridExcercise2Page(); }),
                    new MainMenuItem("Absolute excercise 1", () => { return new AbsoluteExcercise1Page(); }),
                    new MainMenuItem("Image excercise", () => { return new ImageExcercise(); })
                },
                new MainMenuItemGroup("Layouts")
                {
                    new MainMenuItem("Stack layout", () => { return new StackPage(); }),
                    new MainMenuItem("Grid layout", () => { return new GridPage(); }),
                    new MainMenuItem("Absolute layout", () => { return new AbsolutePage(); }),
                    new MainMenuItem("Relative layout", () => { return new RelativePage(); })
                },
                new MainMenuItemGroup("Image")
                {
                    new MainMenuItem("Image", () => { return new ImagePage(); }),
                    new MainMenuItem("Rounded image", () => { return new RoundedImagePage(); }),
                    new MainMenuItem("Image excercise", () => { return new ImageExcercise(); })
                },
                new MainMenuItemGroup("List")
                {
                    new MainMenuItem("List page", () => { return new ListPage(); }),
                    new MainMenuItem("List page 2", () => { return new ListPage2(); }),
                    new MainMenuItem("Custom cell", () => { return new ListWithCustomCellPage(); }),
                    new MainMenuItem("Group", () => { return new ListGroupPage(); }),
                    new MainMenuItem("Selections", () => { return new ListSelectionsPage(); }),
                    new MainMenuItem("Context actions", () => { return new ListContextActionsPage(); }),
                    new MainMenuItem("Pull to refresh", () => { return new ListPullToRefreshPage(); }),
                    new MainMenuItem("Search bar", () => { return new ListSearchBarPage(); })
                },
                new MainMenuItemGroup("Navigation")
                {
                    new MainMenuItem("Hierarchical", () =>
                    {
                        return new NavigationPage(new NavHierarchicalPage1())
                        {
                            BarBackgroundColor = Color.Gray,
                            BarTextColor = Color.White
                        };
                    }),
                    new MainMenuItem("Simple master-detail", () => { return new NavSimpleMasterPage(); }),
                    new MainMenuItem("Master-detail", () => { return new NavMasterDetailPage(); }),
                    new MainMenuItem("Tab", () => { return new TabPage(); }),
                    new MainMenuItem("Carousel", () => { return new CarouselTestPage(); }),
                    new MainMenuItem("Popups", () => { return new PopupsPage(); }),
                    new MainMenuItem("Toolbar items", () => { return new ToolbarItemsPage(); })
                },
                new MainMenuItemGroup("Forms & setting pages")
                {
                    new MainMenuItem("Controls", () => { return new ControlsPage(); }),
                    new MainMenuItem("Table", () => { return new TablePage(); })
                },
                new MainMenuItemGroup("Data access")
                {
                    new MainMenuItem("Application properties", () => { return new ApplicationPropertiesPage(); }),
                    new MainMenuItem("File system", () => { return new FileSystemPage(); }),
                    new MainMenuItem("SQLite", () => { return new SQLitePage(); }),
                    new MainMenuItem("Restful service", () => { return new RestfulPage(); })
                },
                new MainMenuItemGroup("Other")
                {
                    new MainMenuItem("Greet page", () => { return new GreetPage(); }),
                    new MainMenuItem("MVVM playlist page", () => { return new MvvmPlaylistsPage(); }),
                    new MainMenuItem("Resource dictionary", () => { return new ResourceDictionaryPage(); }),
                    new MainMenuItem("Styles", () => { return new StylesPage(); }),
                    new MainMenuItem("Messaging center", () => { return new MessagingCenterPage(); })
                }
            };
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var menuitem = (MainMenuItem)e.Item;
            Navigation.PushAsync(menuitem.Method());
        }
    }
}
