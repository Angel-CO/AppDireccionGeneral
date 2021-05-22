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
    /// Interaction logic for MenuUsuarios.xaml
    /// </summary>
    public partial class MenuUsuarios : Window
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
            this.Close();
        }

        private void Btn_Consultar_Click(object sender, RoutedEventArgs e)
        {
            ConsultarUsuario consultarUsuario = new ConsultarUsuario();
            consultarUsuario.Show();
            this.Close();
        }

        private void Btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            eliminarUsuario.Show();
            this.Close();
        }

        private void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarUsuario modificarUsuario = new ModificarUsuario();
            modificarUsuario.Show();
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
