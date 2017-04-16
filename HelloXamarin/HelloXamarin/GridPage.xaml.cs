﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 20
            };
            var label = new Label { Text = "Label 1" };
            grid.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
        }
    }
}
