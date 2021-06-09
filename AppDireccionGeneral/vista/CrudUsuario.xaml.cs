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
    /// Interaction logic for CrudUsuario.xaml
    /// </summary>
    public partial class CrudUsuario : Window
    {
        List<Usuario> usuarios;
        public CrudUsuario()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            cargarDatosUsuarios();
        }

        private void Btn_Registrar_Click(object sender, RoutedEventArgs e)
        {
            FormularioUsuario formularioUsuario = new FormularioUsuario();
            formularioUsuario.Show();
            this.Close();
        }

        private void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            FormularioUsuario formularioUsuario = new FormularioUsuario((Usuario)listaUsuarios.SelectedItem);
            formularioUsuario.Show();
            this.Close();
        }

        private void Btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = (Usuario)listaUsuarios.SelectedItem;
            MessageBoxResult resultado = MessageBox.Show("¿Esta seguro de eliminar el usuario: " +
            usuario.NombreUsuario + "?", "Confirmar acción", MessageBoxButton.OKCancel);
            if (resultado == MessageBoxResult.OK)
            {
                UsuarioDAO.eliminarUsuario(usuario);
                cargarDatosUsuarios();
                MessageBox.Show("Usuario eliminado");
            }
        }

        private void Btn_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void listaUsuarios_Seleccionados(object sender, SelectionChangedEventArgs e)
        {
            Btn_Modificar.IsEnabled = true;
            Btn_Eliminar.IsEnabled = true;
        }

        private void cargarDatosUsuarios()
        {
            usuarios = UsuarioDAO.getAllUsuarios();
            this.listaUsuarios.ItemsSource = usuarios;
        }
    }
}
