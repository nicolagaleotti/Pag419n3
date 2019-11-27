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

namespace Esercizio3
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double importo = double.Parse(txtImporto.Text);
            double sconto = double.Parse(txtSconto.Text);
            double impSconto;
            if (sconto == 0)
            {
                impSconto = sconto;
            }
            else
            {
                impSconto = importo / 100 * sconto;
            }
            lblSconto.Content = impSconto.ToString();
            double IVA = double.Parse(txtIVA.Text);
            double impIVA;
            if (IVA == 0)
            {
                impIVA = sconto;
            }
            else
            {
                impIVA = importo / 100 * IVA;
            }
            lblIVA.Content = impIVA.ToString();
            double lordo = importo - impSconto + impIVA;
            txtLordo.Text = lordo.ToString();
        }
    }   
}
