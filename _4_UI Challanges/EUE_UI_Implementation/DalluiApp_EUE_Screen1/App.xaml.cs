﻿using DaluiApp.Views;

namespace DalluiApp_EUE_Screen1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageGeneratorView();
        }
    }
}
