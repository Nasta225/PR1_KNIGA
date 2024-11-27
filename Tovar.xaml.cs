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

namespace PR1_KNIGA
{
    /// <summary>
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    public partial class Tovar : Window
    {
        public Tovar()
        {
            InitializeComponent();
        }  
        private void But4_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Window2 window2 = new Window2();
            window2.Show();
            myWindows.Close();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Window1 window1 = new Window1();
            window1.Show();
            myWindows.Close();
        }

    }
}
