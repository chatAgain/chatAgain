﻿using System;
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

namespace chatAgain
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class jiexi : Page
    {
        public jiexi()
        {
            this.InitializeComponent();
        }


        private void HamClick(object sender, RoutedEventArgs e)
        {
            SpVi.IsPaneOpen = !SpVi.IsPaneOpen;
        }

        private void listChange(object sender, SelectionChangedEventArgs e)
        {
            if (chat.IsSelected)
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(chatPage));
                }
            }
            else if (practice.IsSelected)
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(practicePage));
                }
            }
            else if (main.IsSelected)
            {
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(MainPage));
                }
            }
        }

        private void MediaElement_Tapped(object sender, TappedRoutedEventArgs e)
        {
            vedio.Pause();
            rec.Visibility = Visibility.Visible;
        }

        private void rec_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rec.Visibility = Visibility.Collapsed;
            vedio.Play();
        }

        private void vedio_MediaEnded(object sender, RoutedEventArgs e)
        {
            rec.Visibility = Visibility.Visible;
        }
    }
}
