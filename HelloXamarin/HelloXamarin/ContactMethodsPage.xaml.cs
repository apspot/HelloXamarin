using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ContactMethodsPage : ContentPage
    {
        public ListView ContactMethods { get { return listView; } }

        public ContactMethodsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
        }
    }
}

