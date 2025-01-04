using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using WpfApp.Classes;
using Newtonsoft.Json;

namespace WpfApp
{
    public partial class PopUp : Window
    {
        private LoadColor loadColor = new LoadColor();

        private static List<PopUp> openPopups = new List<PopUp>();

        private bool isBouncing = true;

        public PopUp()
        {
            InitializeComponent();
            this.Opacity = 0;
            loadColor.LoadColorsFromJson("Main");

            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Loaded += (sender, args) =>
            {
                double screenWidth = SystemParameters.PrimaryScreenWidth;
                double screenHeight = SystemParameters.PrimaryScreenHeight;
                this.Left = (screenWidth - this.ActualWidth) / 2;
                this.Top = ((screenHeight / 4) - (this.ActualHeight / 2)) - screenHeight / 8;
            };
        }

        public void ShowPopUp(string message)
        {
            if (openPopups.Count >= 4)
            {
                PopUp oldestPopUp = openPopups[0];
                openPopups.RemoveAt(0);
                oldestPopUp.Close();
            }

            PopUp newPopUp = new PopUp();
            newPopUp.MainTextBlock.Text = message;
            newPopUp.Show();

            openPopups.Add(newPopUp);

            var fadeIn = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };

            var translateTransform = new TranslateTransform();
            newPopUp.RenderTransform = translateTransform;

            var slideInFromTop = new DoubleAnimation
            {
                From = -50,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };

            newPopUp.BeginAnimation(OpacityProperty, fadeIn);
            translateTransform.BeginAnimation(TranslateTransform.YProperty, slideInFromTop);

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(5)
            };

            timer.Tick += (sender, args) =>
            {
                var fadeOut = new DoubleAnimation
                {
                    From = 1,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };

                var slideDown = new DoubleAnimation
                {
                    From = 0,
                    To = 50,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };

                fadeOut.Completed += (s, e) =>
                {
                    newPopUp.Close();
                    openPopups.Remove(newPopUp);
                };

                newPopUp.BeginAnimation(OpacityProperty, fadeOut);
                translateTransform.BeginAnimation(TranslateTransform.YProperty, slideDown);

                timer.Stop();
            };
            timer.Start();
        }

        private void StartBounceAnimation(PopUp newPopUp)
        {
            var translateTransform = new TranslateTransform();
            newPopUp.RenderTransform = translateTransform;

            var bounceAnimation = new DoubleAnimation
            {
                From = 0,
                To = -15,
                Duration = new Duration(TimeSpan.FromMilliseconds(100)),
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(2)
            };

            translateTransform.BeginAnimation(TranslateTransform.YProperty, bounceAnimation);
        }
    }
}
