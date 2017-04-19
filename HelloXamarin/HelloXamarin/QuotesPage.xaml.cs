using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class QuotesPage : ContentPage
    {        
        private int currentquoteindex = 0;
        private String[] quotes =
        {
            "Don't cry because it's over, smile because it happened.",
            "Be yourself; everyone else is already taken.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "So many books, so little time.",
            "A room without books is like a body without a soul."
        };        

        public QuotesPage()
        {
            InitializeComponent();
            SetCurrentQuote();            
        }

        void Next(object sender, EventArgs e)
        {
            currentquoteindex++;
            if (currentquoteindex >= quotes.Length)
                currentquoteindex = 0;
            SetCurrentQuote();
        }

        private void SetCurrentQuote()
        {
            label.Text = quotes[currentquoteindex];
        }
    }
}
