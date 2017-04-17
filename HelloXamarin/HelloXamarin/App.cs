using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            /*var content = new ContentPage
            {
                Title = "HelloXamarin",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);*/
            //MainPage = new GreetPage();
            //MainPage = new StackPage();
            //MainPage = new GridPage();
            //MainPage = new AbsolutePage();
            //MainPage = new RelativePage();
            //MainPage = new ImagePage();
            //MainPage = new RoundedImagePage();
            //MainPage = new ImageExcercise();
            //MainPage = new ListPage();
            //MainPage = new ListPage2();
            //MainPage = new ListWithCustomCellPage();
            //MainPage = new ListGroupPage();
            //MainPage = new ListSelectionsPage();
            //MainPage = new ListContextActionsPage();
            //MainPage = new ListPullToRefreshPage();
            //MainPage = new ListSearchBarPage();
            /*MainPage = new NavigationPage(new NavHierarchicalPage1())
            {
                BarBackgroundColor = Color.Gray,
                BarTextColor = Color.White
            };*/
            //MainPage = new NavigationPage(new NavSimpleMasterPage());
            //MainPage = new NavMasterDetailPage();
            //MainPage = new TabPage();
            //MainPage = new CarouselTestPage();
            //MainPage = new PopupsPage();
            //MainPage = new NavigationPage(new ToolbarItemsPage());
            //MainPage = new NavigationPage(new ControlsPage());
            //MainPage = new NavigationPage(new TablePage());
            //MainPage = new ApplicationPropertiesPage();
            //MainPage = new FileSystemPage();
            //MainPage = new SQLitePage();
            //MainPage = new RestfulPage();
            MainPage = new NavigationPage(new MvvmPlaylistsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private const String TitleKey = "Name";
        public String Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
                Application.Current.SavePropertiesAsync();
            }
        }

        private const String NotificationsEnabledKey = "NotificationsEnabled";
        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];
                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
                Application.Current.SavePropertiesAsync();
            }
        }
    }
}
