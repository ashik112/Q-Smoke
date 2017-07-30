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
    public partial class Question : PhoneApplicationPage
    {
        public Question()
        {
            InitializeComponent();
        }
        double totalDays;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int y = Convert.ToInt32(year.Text);
                int m = Convert.ToInt32(month.Text);
                int d = Convert.ToInt32(day.Text);
                 totalDays = (y * 365) + (m * 30) + d;
                
            }
            catch(Exception )
            {
                error.Text = "Invalid Input";
                return;
            }
            NavigationService.Navigate(new Uri("/Question1.xaml?totalDays=" + totalDays, UriKind.Relative));
             
        }
    }
}