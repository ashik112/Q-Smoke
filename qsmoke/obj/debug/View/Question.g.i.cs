﻿#pragma checksum "C:\Users\tanvi_000\Dropbox\qSmoke\qSmoke\qSmoke\View\Question.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35028800C39BC85805D7215670A9AE16"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace qSmoke {
    
    
    public partial class Question : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox year;
        
        internal System.Windows.Controls.TextBox month;
        
        internal System.Windows.Controls.TextBox day;
        
        internal System.Windows.Controls.TextBlock error;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/qSmoke;component/View/Question.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.year = ((System.Windows.Controls.TextBox)(this.FindName("year")));
            this.month = ((System.Windows.Controls.TextBox)(this.FindName("month")));
            this.day = ((System.Windows.Controls.TextBox)(this.FindName("day")));
            this.error = ((System.Windows.Controls.TextBlock)(this.FindName("error")));
        }
    }
}

