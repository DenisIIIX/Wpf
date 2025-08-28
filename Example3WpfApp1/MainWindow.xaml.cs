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

namespace Example3WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte H = (byte)(Hours?.Value ?? 8);
            if (HoursValue != null)
                HoursValue.Text = H.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Agreement.IsChecked ?? false)
            {
                MessageBox.Show("Ошибка: необходимо согласиться на обработку!", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var selectedCourses = Courses.SelectedItems
                .Cast<ListBoxItem>()
                .Select(item => item.Content.ToString())
                .ToList();

            string message = $"Студент: {StudentName.Text}\n" +
                             $"Факультет: {Faculty.Text}\n" +
                             $"Курсы: {string.Join(", ", selectedCourses)}\n" +
                             $"Форма обучения: {(Full_time.IsChecked == true ? "Очная" : "Заочная")}\n" +
                             $"Количество часов: {Hours.Value}";
            MessageBox.Show(message, "Данные отправлены", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}