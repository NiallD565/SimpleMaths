﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathsGame.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary> 

    public sealed partial class PlaySingle : Page
    {
        private int staticNumA, staticNumB, staticResult, staticRandomResult, Score = 0, State = 1, mode;
        private DispatcherTimer dispatcherTimer;

        private void setupProgressBar()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Start();

            progressBar.Value = 9999;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += PlaySingle_BackRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested -= PlaySingle_BackRequested;
            dispatcherTimer = null;

            Playing();
        }

        private void DispatcherTimer_Tick(object sender, object e)
        {
            progressBar.Value -= SimpleMaths.Maths.speed;
            if (progressBar.Value <= 0)
            {
                dispatcherTimer.Stop();
                dispatcherTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());
            }
        }

        private async void PlaySingle_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            e.Handled = true;
            dispatcherTimer.Stop();
            dispatcherTimer = null;

            var msg = new MessageDialog("Are you handsome?");
            var okBtn = new UICommand("Yes");
            var kindaBtn = new UICommand("Kinda");
            msg.Commands.Add(okBtn);
            msg.Commands.Add(kindaBtn);
            IUICommand result = await msg.ShowAsync();

            if (result != null && result.Label.Equals("Yes"))
            {
                //Application.Current.Exit();
                Frame.Navigate(typeof(GameOver), Score.ToString()); // Navigate to game over screen and send score 
            }
        }

        private void btnTrue_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 1) // mode - 1 so correct answer is True
            {
                txtScore.Text = String.Format("Score: {0}".ToUpper(), ++Score);
                txtState.Text = String.Format("{0}", ++State);
                dispatcherTimer.Stop();
                dispatcherTimer = null;
                Playing();
            }
            else
            {
                dispatcherTimer.Stop();
                dispatcherTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());
            }
        }

        private void Playing()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 4);
            if (value == 1)// +
            {
                staticNumA = rnd.Next(1, 9);
                staticNumB = rnd.Next(0, staticNumA - 1);
                staticResult = staticNumA + staticNumB;
                staticRandomResult = rnd.Next(0, 99);

                mode = rnd.Next(0, 1);// Random Mode show answer if mode = 0 show incorrect answer

                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} + {1} = {2}", staticNumA, staticNumB, staticRandomResult);
                }
                else
                    txtMath.Text = String.Format("{0} + {1} = {2}", staticNumA, staticNumB, staticResult);
            }
            if (value == 2)// -
            {
                staticNumA = rnd.Next(1, 9);
                staticNumB = rnd.Next(0, staticNumA - 1);
                staticResult = staticNumA - staticNumB;
                staticRandomResult = rnd.Next(0, 99);

                mode = rnd.Next(0, 1);// Random Mode show answer if mode = 0 show incorrect answer

                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} - {1} = {2}", staticNumA, staticNumB, staticRandomResult);
                }
                else
                    txtMath.Text = String.Format("{0} - {1} = {2}", staticNumA, staticNumB, staticResult);
            }
            if (value == 3)// *
            {
                staticNumA = rnd.Next(1, 9);
                staticNumB = rnd.Next(0, staticNumA - 1);
                staticResult = staticNumA * staticNumB;
                staticRandomResult = rnd.Next(0, 99);

                mode = rnd.Next(0, 1);// Random Mode show answer if mode = 0 show incorrect answer

                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} * {1} = {2}", staticNumA, staticNumB, staticRandomResult);
                }
                else
                    txtMath.Text = String.Format("{0} * {1} = {2}", staticNumA, staticNumB, staticResult);
            }
            if (value == 4)// /
            {
                staticNumA = rnd.Next(1, 9);
                staticNumB = rnd.Next(1, staticNumA); // cant divide by 0
                staticResult = staticNumA / staticNumB;
                staticRandomResult = rnd.Next(0, 99);

                mode = rnd.Next(0, 1);// Random Mode show answer if mode = 0 show incorrect answer

                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} / {1} = {2}", staticNumA, staticNumB, staticRandomResult);
                }
                else
                    txtMath.Text = String.Format("{0} / {1} = {2}", staticNumA, staticNumB, staticResult);
            }
            setupProgressBar();
        }

        private void btnFalse_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 1) // mode - 1 so correct answer is True
            {
                txtScore.Text = String.Format("Score: {0}".ToUpper(), ++Score);
                txtState.Text = String.Format("{0}", ++State);
                dispatcherTimer.Stop();
                dispatcherTimer = null;
                Playing();
            }
            else
            {
                dispatcherTimer.Stop();
                dispatcherTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());
            }
        }
    }
}
