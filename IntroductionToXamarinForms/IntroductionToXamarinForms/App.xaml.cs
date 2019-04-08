﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroductionToXamarinForms
{
    public partial class App : Application
    {
        public static string DatabaseLocation;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
        }
        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage();
            DatabaseLocation = databaseLocation;

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
    }
}
