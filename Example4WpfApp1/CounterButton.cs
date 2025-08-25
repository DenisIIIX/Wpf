using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Example4WpfApp1
{
    public class CounterButton : Button
    {
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register(
                nameof(IsToggled),
                typeof(bool),
                typeof(CounterButton),
                new FrameworkPropertyMetadata(true,
                    OnClickCountChanged));

        public bool IsToggled
        {
            get => (bool)GetValue(IsToggledProperty);
            set => SetValue(IsToggledProperty, value);
        }

        private static void OnClickCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (CounterButton)d;
            bool newValue = (bool)e.NewValue;

            button.Content = newValue == true
                ? "ON"
                : "OFF";

            button.Background = newValue == true
                ? Brushes.Green
                : Brushes.Red;
        }

        public CounterButton()
        {
            Content = "ON";
            Background = Brushes.Green;
            Click += (sender, e) => IsToggled = !IsToggled;
        }
    }
}
