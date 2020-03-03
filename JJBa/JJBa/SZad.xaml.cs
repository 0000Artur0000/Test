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
    /// Логика взаимодействия для SZad.xaml
    /// </summary>
    public partial class SZad : UserControl
    {
        public SZad()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MParent mp = (MParent)Application.Current.Windows[1];
            mp.forma.Content = mp.mn.Mtop;
        }


    }
}
