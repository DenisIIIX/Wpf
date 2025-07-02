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

namespace WpfExample1App3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double width =  0;
        private double height = 0;  
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Button button = sender as Button;
            width = rnd.Next(0, (int)(MainGrid.ActualWidth-RunnigButton.Width));
            height = rnd.Next(0, (int)(MainGrid.ActualHeight-RunnigButton.Height));
            RunnigButton.Margin = new Thickness(width, height, 0, 0);
        }
    }
}