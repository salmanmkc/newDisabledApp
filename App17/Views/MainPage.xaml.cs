using System;

using App17.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App17.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
