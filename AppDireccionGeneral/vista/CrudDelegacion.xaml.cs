using AppDireccionGeneral.modelo.poco;
using AppDireccionGeneral.modelo.dao;
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
    /// Interaction logic for CrudDelegacion.xaml
    /// </summary>
    public partial class CrudDelegacion : Window
    {
        List<Delegacion> delegaciones;
        public CrudDelegacion()
        {
            InitializeComponent();
            cargarDelegaciones();
        }

        private void cargarDelegaciones()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            lvDelegaciones.ItemsSource = delegaciones;
        }

        private void lvDelegaciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.btnModificar.IsEnabled = true;
            this.btnEliminar.IsEnabled = true;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            FormularioDelegacion formularioDelegacion = new FormularioDelegacion();
            formularioDelegacion.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
