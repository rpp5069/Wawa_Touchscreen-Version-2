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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wawa_Touchscreen
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

        private void bfTab_Click(object sender, RoutedEventArgs e)
        {
            WindowBF window1 = new WindowBF();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void ldTab_Click(object sender, RoutedEventArgs e)
        {
            WindowLD window1 = new WindowLD();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void hcdtab_Click(object sender, RoutedEventArgs e)
        {
            WindowHCD window1 = new WindowHCD();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void ssTab_Click(object sender, RoutedEventArgs e)
        {
            WindowSS window1 = new WindowSS();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void sbTab_Click_1(object sender, RoutedEventArgs e)
        {
            WindowSB window1 = new WindowSB();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        /*
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            this.Visibility = Visibility.Hidden;
            window2.Show();
        }
        */
    }
}
