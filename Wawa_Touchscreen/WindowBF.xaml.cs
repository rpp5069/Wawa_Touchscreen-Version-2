using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wawa_Touchscreen
{
    /// <summary>
    /// Interaction logic for WindowBF.xaml
    /// </summary>
    public partial class WindowBF : Window
    {
        public WindowBF()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This funtionality is currently being developed. Please try again later.");
        }
    }
}
