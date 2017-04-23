using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Model
{
    public class Activity
    {
        public int UserId { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get { return "http://lorempixel.com/100/100/people/" + UserId; } }
    }
}
