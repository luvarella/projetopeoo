using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
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

namespace Projeto_PEOO_3bi
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

        private Esporte[] x = new Esporte[14];
        private int k;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Esporte y = new Esporte();
            y.SetNome(txt3.Text);
            y.SetHorarios(txt4.Text);
            y.SetMensalidade(double.Parse(txt5.Text));
            x[k] = y;
            k++;
            list.ItemsSource = null;
            list.ItemsSource = x;
        }
    }
}
