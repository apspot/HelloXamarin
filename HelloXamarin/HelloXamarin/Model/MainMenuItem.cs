﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin.Model
{    
    public class MainMenuItem
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public Func<Page> Method { get; set; }

        public MainMenuItem(string name, Func<Page> method)
        {
            Name = name;
            Method = method;
        }

        public MainMenuItem(string name, string details, Func<Page> method)
        {
            Name = name;
            Details = details;
            Method = method;
        }
    }
}
