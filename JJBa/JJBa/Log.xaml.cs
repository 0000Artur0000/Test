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

namespace JJBa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Log : Window
    {
        public Log()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            T1.MaxLength = 25;
            T2.MaxLength = 20;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(T1.Text) || String.IsNullOrEmpty(T2.Password))
                MessageBox.Show("Введите данные!");
            else
            {
                string jo = Connect.connect(T1.Text, T2.Password);
                if (!String.IsNullOrEmpty(jo))
                {
                    //MessageBox.Show(jo);
                    MParent main = new MParent();
                    main.Show();
                    main.load(jo.Split(':')[1].Replace("  ", " "));
                    main.id = Int16.Parse(jo.Split(':')[0]);
                    this.Hide();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль!");
            }
            

        }


    }
}
