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
    /// Логика взаимодействия для Good.xaml
    /// </summary>
    public partial class Good : UserControl
    {
        public Good()
        {
            InitializeComponent();
        }
        Window mp = Application.Current.MainWindow;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //mp.forma.Content = null;
            MParent mp1 = (MParent)mp;
            mp1.forma.Content = mp1.mns.gtop;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
