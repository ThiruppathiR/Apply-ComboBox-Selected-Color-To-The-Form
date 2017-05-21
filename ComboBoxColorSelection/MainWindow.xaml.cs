
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Reflection;

namespace ComboBoxColorSelection
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

        #region Window_Loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CBox.ItemsSource = typeof(Colors).GetProperties();
        }
        #endregion
        #region SelectedColor
        private void SelectedColor(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(CBox.SelectedItem as PropertyInfo).GetValue(1, null);
            this.Background = new SolidColorBrush(selectedColor);
        }
        #endregion
    }
}
