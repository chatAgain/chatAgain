using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.System.Threading;
using Windows.UI.Core;
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
    public sealed partial class chat3 : Page
    {
        public chat3()
        {
            this.InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

      private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
      {

          Windows.Phone.UI.Input.HardwareButtons.BackPressed -=
              HardwareButtons_BackPressed;

          var rootFrame = Window.Current.Content as Frame;

          rootFrame.Navigate(typeof(chatPage));

          Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);

          Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);
          Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);

            e.Handled = true;
        }

      private void HamClick(object sender, RoutedEventArgs e) {
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

        private void orangeButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            image.Visibility = Visibility;

            sound.Play();

            TimeSpan delay = TimeSpan.FromSeconds(8);
            ThreadPoolTimer DelayTimer =
                ThreadPoolTimer.CreateTimer(async (source) =>
                {
                    await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                    {
                        image2.Visibility = Visibility;
                    }
                    );

                }, delay);
        }
    }


}
