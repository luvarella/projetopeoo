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



        Academia a;
        private void clique(object sender, RoutedEventArgs e)
        {
            a = new Academia(txt1.Text, txt2.Text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Esporte y = new Esporte();
            y.SetNome(txt3.Text);
            y.SetHorarios(txt4.Text);
            y.SetMensalidade(double.Parse(txt5.Text));
            a.Inserir(y);
        }

        private void clique2(object sender, RoutedEventArgs e)
        {
            /*for(int i = 0; i < k; i++)
            {
                caixa.Text += $"{x[i].ToString()}\n";
            }*/
            foreach (Esporte z in a.Listar())
            {
                caixa.Text += $"{z.ToString()}\n";
            }
            caixa.Text += $"A mensalidade média foi de {a.MediaMensalidade()}";


        }
    }
}

