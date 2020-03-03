using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            T1.MaxLength = 10;
            T2.MaxLength = 10;
            T3.MaxLength = 10;
            T4.MaxLength = 10;
            T5.MaxLength = 10;
            T6.MaxLength = 10;
            T7.MaxLength = 10;
            T8.MaxLength = 10;
            T9.MaxLength = 10;
            loaddb();

        }
        private void loaddb()
        {


            idc.Items.Clear();
            ds.Tables.Clear();
            ds.Tables.Add(Connect.read("RabDB"));
            Gr.ItemsSource = ds.Tables[0].AsDataView();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                idc.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            idc.SelectedIndex = 0;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void idc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextUpdate();
        }

        private void TextUpdate()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (idc.SelectedIndex != -1)
            {
                T1.Text = Math.Round(Double.Parse(ds.Tables[0].Rows[idc.SelectedIndex][1].ToString()), 2).ToString();
                T2.Text = Math.Round(Double.Parse(ds.Tables[0].Rows[idc.SelectedIndex][2].ToString()), 2).ToString();
                T3.Text = Math.Round(Double.Parse(ds.Tables[0].Rows[idc.SelectedIndex][3].ToString()), 2).ToString();
                T4.Text = ds.Tables[0].Rows[idc.SelectedIndex][4].ToString();
                T5.Text = ds.Tables[0].Rows[idc.SelectedIndex][5].ToString();
                T6.Text = ds.Tables[0].Rows[idc.SelectedIndex][6].ToString();
                T7.Text = ds.Tables[0].Rows[idc.SelectedIndex][7].ToString();
                T8.Text = ds.Tables[0].Rows[idc.SelectedIndex][8].ToString();
                T9.Text = ds.Tables[0].Rows[idc.SelectedIndex][9].ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            DataRow dr = ds.Tables[0].NewRow();
            bool doDoHasDoHasMesh = true;
            try
            {
                dr[0] = Int16.Parse(idc.Text);
                dr[1] = Double.Parse(T1.Text.Replace(',', '.'));
                dr[2] = Double.Parse(T2.Text.Replace(',', '.'));
                dr[3] = Double.Parse(T3.Text.Replace(',', '.'));
                dr[4] = Double.Parse(T4.Text.Replace(',', '.'));
                dr[5] = Double.Parse(T5.Text.Replace(',', '.'));
                dr[6] = Double.Parse(T6.Text.Replace(',', '.'));
                dr[7] = Double.Parse(T7.Text.Replace(',', '.'));
                dr[8] = Double.Parse(T8.Text.Replace(',', '.'));
                dr[9] = Double.Parse(T9.Text.Replace(',', '.'));
            }
            catch (Exception ex)
            {
                doDoHasDoHasMesh = false;
                MessageBox.Show("Проверьте правильность данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            //MessageBox.Show(dr[0] + ", " + dr[1] + ", " + dr[2] + ", " + dr[3] + ", " + dr[4] + ", " + dr[5] + ", " + dr[6] + ", " + dr[7] + ", " + dr[8] + ", " + dr[9]);
            if (doDoHasDoHasMesh)
            {
                Connect.load(dr);
                loaddb();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
