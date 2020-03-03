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

namespace JJBa
{
    /// <summary>
    /// Логика взаимодействия для MParent.xaml
    /// </summary>
    public partial class MParent : Window
    {
        public MParent()
        {
            InitializeComponent();
        }
        Good mn = new Good();
        public Main mns = new Main();
        List<Label> lbs = new List<Label>();
        public int id=-1;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = this;
            lbs.Add(mn.L1);
            forma.Content = mn.Mtop;
        }
        public void load(string s)
        {
            lbs[0].Content = lbs[0].Content + s+"!";

        }
    }
}
