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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanExam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppLayout : Page
    {
        public AppLayout()
        {
            this.InitializeComponent();
        }
        private void Practical_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            Practical.IsBackEnabled = true;
            Practical.IsBackButtonVisible = NavigationViewBackButtonVisible.Visible;
            var tag = args.InvokedItemContainer.Tag.ToString();
            switch (tag)
            {
                case "addcontact":
                    ContentPage.Navigate(typeof(Pages.AddContact), args.RecommendedNavigationTransitionInfo);
                    break;
                case "searchcontact":
                    ContentPage.Navigate(typeof(Pages.SearchContact), args.RecommendedNavigationTransitionInfo);
                    break;
            }
        }
    }
}
