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
    /// Interaction logic for MenuDelegacionMunicipal.xaml
    /// </summary>
    public partial class MenuDelegacionMunicipal : Window
    {
        public MenuDelegacionMunicipal()
        {
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarDelegacion registrarDelegacion = new RegistrarDelegacion();
            registrarDelegacion.Show();
            this.Close();
        }

        private void Btn_Consultar_Click(object sender, RoutedEventArgs e)
        {
            ConsultarDelegacion consultarDelegacion = new ConsultarDelegacion();
            consultarDelegacion.Show();
            this.Close();
        }

        private void Btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarDelegacion eliminarDelegacion = new EliminarDelegacion();
            eliminarDelegacion.Show();
            this.Close();
        }

        private void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarDelegacion modificarDelegacion = new ModificarDelegacion();
            modificarDelegacion.Show();
            this.Close();
        }

        private void Btn_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
