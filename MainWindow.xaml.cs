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

namespace PR1_KNIGA
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
        private string Password = "Клиент";
        private string Login = "123";
        private void But1_Click_1(object sender, RoutedEventArgs e)
        {
            if (Password == Password1.Text && Login == Login1.Text)
            {
                var myWindows = Window.GetWindow(this);
                Catalog window1 = new Catalog();
                window1.Show();
                myWindows.Close();
            }
            else if (Password != Password1.Text && Login == Login1.Text)
            {
                MessageBox.Show("Не верный логин");
            }
            else if (Login != Login1.Text && Login != Login1.Text)
            {
                MessageBox.Show("Не верный пароль");
            }
        }      
    }
}

