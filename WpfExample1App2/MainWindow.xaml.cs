using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExample1App2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i = 2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i = (i + 1)%3;
            Red.Fill = Brushes.Gray;
            Yellow.Fill = Brushes.Gray;
            Green.Fill = Brushes.Gray;

            switch (i)
            {
                case 0:
                    Red.Fill = Brushes.Red;
                    break;
                case 1:
                    Yellow.Fill = Brushes.Yellow;
                    break;
                case 2:
                    Green.Fill = Brushes.Green;
                    break;
            }
        }
    }
}