using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;


            //if (Device.RuntimePlatform == Device.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}

            //int padding = 0;
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.Android:
            //        padding = 10;
            //        break;
            //    case Device.iOS:
            //        padding = 20;
            //        break;
            //    default:
            //        break;
            //}

            //Padding = new Thickness(0, padding, 0, 0);
        }
    }
}