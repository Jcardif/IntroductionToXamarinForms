using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroductionToXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise1 : ContentPage
    {
        private int count = 0;
        private readonly string[] quotes = { "Imagination is more important than knowledge",
            "Life is like riding a bicycle. To keep your balance you must keep moving",
            "If you can't explain it simply, you don't understand it well enough.",
            "In the middle of difficulty lies opportunity." };
        public Exercise1()
        {
            InitializeComponent();
            quotelable.Text = quotes[1];
        }

        private void NextBtn_Clicked(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
                count = 0;
            quotelable.Text = quotes[count];
        }
    }
}