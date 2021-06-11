using AppDireccionGeneral.modelo.dao;
using AppDireccionGeneral.modelo.poco;
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

namespace AppDireccionGeneral.vista
{
    /// <summary>
    /// Interaction logic for DetallesReporte.xaml
    /// </summary>
    public partial class DetallesReporte : Window
    {
        Reporte reporte;
        public DetallesReporte()
        {
            InitializeComponent();
        }

        public DetallesReporte(Reporte reporte)
        {
            this.reporte = reporte;
            cargarDatosDictamen();
        }

        private void cargarDatosDictamen()
        {
            Dictamen dictamen = DictamenDAO.getDictamen(reporte);

            tbFolio.Text = dictamen.Folio.ToString();
            tbFecha.Text = dictamen.FechaHora.ToString("dd/MM/yyyy");
            tbHora.Text = dictamen.FechaHora.ToString("hh:mm tt");
            tbPerito.Text = dictamen.NombrePerito;
            tbDescripcion.Text = dictamen.Descripcion;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaReportes listaReportes = new ListaReportes();
            listaReportes.Show();
            this.Close();
        }
    }
}
