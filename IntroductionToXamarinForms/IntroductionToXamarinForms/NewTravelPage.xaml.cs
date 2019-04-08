using IntroductionToXamarinForms.Model;
using SQLite;
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
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void SaveToolBarItem_Clicked(object sender, EventArgs e)
        {
            var post = new Post
            {
                Experience = experienceEntry.Text
            };

            var conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            var rows=conn.Insert(post);
            conn.Close();

            if (rows > 0)
                DisplayAlert("Success", "The experience was successfully inserted", "Ok");
            else
                DisplayAlert("Failure", "The experience was not inserted", "Ok");


        }
    }
}