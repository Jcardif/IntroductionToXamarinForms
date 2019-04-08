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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogInBtn_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(emailEntry.Text) ||string.IsNullOrEmpty(passwordEntry.Text))
            {
                DisplayAlert("Empty Fields", "One or more fields is empty", "Ok");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}