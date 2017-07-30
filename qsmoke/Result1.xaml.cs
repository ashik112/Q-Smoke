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
    public partial class Result1 : PhoneApplicationPage
    {
        public Result1()
        {
            
            InitializeComponent();
            
        }
        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            
            
            base.OnNavigatedTo(e);
             int numberCig = Convert.ToInt32(NavigationContext.QueryString["parameter1"]);
            int price = Convert.ToInt32(NavigationContext.QueryString["parameter2"]);
             int totalDays = Convert.ToInt32(NavigationContext.QueryString["parameter3"]);
             calculate(numberCig, price, totalDays);

        }

        

        private void click(object sender, RoutedEventArgs e)
        {
           // NavigationService.Navigate(new Uri("/Health.xaml", UriKind.Relative)); 
        }
        private void calculate(int n,int p,int d)
        {

            int mWasted = n * p *d;
            int tCig=n *d;
            moneyWasted.Text = Convert.ToString(mWasted+" $");
            totalSmoked.Text = Convert.ToString(tCig + " Cigerettes");
            nConsumed.Text = Convert.ToString(tCig * 0.9 + "~" + tCig + " mg");
            lifeReduction.Text = Convert.ToString(tCig*11+" minutes");

        }

    }
}