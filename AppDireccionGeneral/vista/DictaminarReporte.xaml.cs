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
    /// Interaction logic for DictaminarReporte.xaml
    /// </summary>
    public partial class DictaminarReporte : Window
    {
        private Reporte reporte;
        List<Usuario> peritos;
        public DictaminarReporte(Reporte reporte)
        {
            InitializeComponent();
            this.reporte = reporte;
            cargarDatosReporte();
            cargarPeritos();
        }

        private void btnDictaminar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                DateTime fechaHoraActual = DateTime.Now;

                DictamenDAO.registrarDicatmen(crearDictamen());
                ReporteDAO.cambiarEsatusReporte(this.reporte);

                MessageBox.Show("Reporte dictaminado a las " + fechaHoraActual.ToString("hh:mm tt") + " el día " + fechaHoraActual.ToString("dd/MM/yyyy"));
                
                ListaReportes listaReportes = new ListaReportes();
                listaReportes.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private bool validarDatos()
        {
            bool datosValidos = true;
            if(tbDescripcion.Text.Length == 0)
            {
                datosValidos = false;
                tbDescripcion.BorderBrush = Brushes.Red;
            }
            else
            {
                tbDescripcion.BorderBrush = Brushes.Black;
            }
            if(cbPerito.SelectedIndex < 0)
            {
                datosValidos = false;
                lbPerito.Foreground = Brushes.Red;
            }
            else
            {
                lbPerito.Foreground = Brushes.Black;
            }
            return datosValidos;
        }

        private void cargarDatosReporte()
        {
            tbFolio.Text = reporte.IdReporte.ToString();
            dpFecha.SelectedDate = reporte.FechaHora;
            tbDelegacion.Text = reporte.NombreDelegacion;
            tbDireccion.Text = reporte.DireccionSiniestro;
        }

        private void cargarPeritos()
        {
            peritos = UsuarioDAO.getPeritos();
            cbPerito.DisplayMemberPath = "NombreCompleto";
            cbPerito.ItemsSource = peritos;
        }


        private Dictamen crearDictamen()
        {
            Dictamen dictamen = new Dictamen();
            dictamen.Descripcion = tbDescripcion.Text;
            dictamen.FechaHora = DateTime.Now;
            dictamen.IdReporte = this.reporte.IdReporte;
            dictamen.IdUsuario = ((Usuario)cbPerito.SelectedItem).IdUsuario;
            return dictamen;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaReportes listaReportes = new ListaReportes();
            listaReportes.Show();
            this.Close();
        }
    }
}
