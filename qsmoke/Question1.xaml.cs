using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace qSmoke
{
    public partial class Question1 : PhoneApplicationPage
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Result1.xaml?msg=" + +  , UriKind.Relative));
            NavigationService.Navigate(new Uri("/Result1.xaml?parameter1=" + nCig.Text + "&parameter2=" + price.Text+"&parameter3="+totalDays, UriKind.Relative));            

        }
        int totalDays;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

           
            base.OnNavigatedTo(e);
            totalDays =Convert.ToInt32( NavigationContext.QueryString["totalDays"]);
            Console.WriteLine(totalDays);
           

        }
    }
}