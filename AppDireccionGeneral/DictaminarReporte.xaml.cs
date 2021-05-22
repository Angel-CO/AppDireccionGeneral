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
    /// Interaction logic for DictaminarReporte.xaml
    /// </summary>
    public partial class DictaminarReporte : Window
    {
        public DictaminarReporte()
        {
            InitializeComponent();
        }
        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaReportes listaReportes = new ListaReportes();
            listaReportes.Show();
            this.Close();
        }
    }
}
