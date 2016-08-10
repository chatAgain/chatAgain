﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace chatAgain
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class qingjing1 : Page
    {
        public qingjing1()
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

        private void image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/button_start-02.png"));
            textBlock.Text = "跟读中……";
        }

        private void image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/button_start-01.png"));
            textBlock.Text = "评估中，请稍后……";

            TimeSpan delay = TimeSpan.FromSeconds(2);
            ThreadPoolTimer DelayTimer =
                ThreadPoolTimer.CreateTimer(async (source) =>
                {
                    await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                    {
                        if (this.Frame != null)
                        {
                            this.Frame.Navigate(typeof(result));
                        }
                    }
                    );

                }, delay);
        }
    }
}
