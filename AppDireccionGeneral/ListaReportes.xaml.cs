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

namespace AppDireccionGeneral
{
    /// <summary>
    /// Interaction logic for ListaReportes.xaml
    /// </summary>
    public partial class ListaReportes : Window
    {
        public ListaReportes()
        {
            InitializeComponent();
        }
        private void cancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dictaminar_Click(object sender, RoutedEventArgs e)
        {
            DictaminarReporte dictaminarReporte = new DictaminarReporte();
            dictaminarReporte.Show();
            this.Close();
        }

        private void btn_verDetalles_Click(object sender, RoutedEventArgs e)
        {
            DetallesReporte detallesReporte = new DetallesReporte();
            detallesReporte.Show();
            this.Close();
        }
    }
}
