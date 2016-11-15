using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStylesChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _roast;
        private string _sweetener;
        private string _cream;
        private string _value;
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var Roast = (MenuFlyoutItem)sender;
            _roast = Roast.Text;
            display();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var Sweetener = (MenuFlyoutItem)sender;
            _sweetener = Sweetener.Text;
            display();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var Cream = (MenuFlyoutItem)sender;
            _cream = Cream.Text;
            display();
        }
        private void display()
        {
            if((_roast == "None") || string.IsNullOrEmpty(_roast))
            {
                CoffeeResultTextBlock.Text = "None";
                return;
            }
            CoffeeResultTextBlock.Text = _roast;
            if((_cream != "None") && (!string.IsNullOrEmpty(_cream)))
            {
                CoffeeResultTextBlock.Text += " + " + _cream;
            }
            if((_sweetener != "None") && !string.IsNullOrEmpty(_sweetener))
            {
                CoffeeResultTextBlock.Text += " + " + _sweetener;
            }
               
        }
    }
}