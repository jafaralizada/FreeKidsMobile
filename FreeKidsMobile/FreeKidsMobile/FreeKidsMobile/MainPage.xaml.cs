using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreeKidsMobile
{
   /// <summary>WebView for MainPage</summary>

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var FreeKidsPage = new WebView();
            FreeKidsPage.Source = "https://freekids.com.tr";
            Content = FreeKidsPage;
        }
    }
}
