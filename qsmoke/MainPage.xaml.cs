using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using qSmoke.Resources;
using System.Windows.Media;
using Windows.Foundation;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.Synthesis;


namespace qSmoke
{
    public partial class MainPage : PhoneApplicationPage
    {
                                        // When this is true, we will continue to recognize 
     //   Dictionary<string, a> _colorBrushes;   
      //  SpeechRecognizer recognizer;    
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("/Question.xaml", UriKind.Relative));  
          //  test.Text = "hello";
        }
        
    }
}