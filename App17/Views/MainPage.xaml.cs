using System;

using App17.ViewModels;
using Windows.UI;
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

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add "using Windows.UI;" for Color and Colors.
            string colorName = e.AddedItems[0].ToString();
            Color color;
            switch (colorName)
            {
                case "Yellow":
                    color = Colors.Yellow;
                    break;
                case "Green":
                    color = Colors.Green;
                    break;
                case "Blue":
                    color = Colors.Blue;
                    break;
                case "Red":
                    color = Colors.Red;
                    break;
            }
            
            //colorRectangle.Fill = new SolidColorBrush(color);
        }

        private void ColorComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            GenderPrompt.Text = "";
            GenderCheckBox.IsChecked = true;
        }
    }
}
