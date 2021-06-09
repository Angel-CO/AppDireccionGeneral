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
    /// Interaction logic for FormularioUsuario.xaml
    /// </summary>
    public partial class FormularioUsuario : Window
    {
        private Usuario usuarioEdicion;
        private Boolean esNuevo = true;
        private List<String> cargos;
        private List<Delegacion> delegaciones;
        public FormularioUsuario()
        {
            usuarioEdicion = new Usuario();
            InitializeComponent();
            cargarCargos();
            cargarDelegaciones();
        }

        public FormularioUsuario(Usuario usuario) : this()
        {
            this.usuarioEdicion = usuario;
            esNuevo = false;
            llenarCampos();
        }
        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            CrudUsuario crudUsuario = new CrudUsuario();
            crudUsuario.Show();
            this.Close();
        }
        private void Btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                if (esNuevo)
                {
                    UsuarioDAO.agregarUsuario(usuarioEdicion);
                    MessageBox.Show("Usuario registrado");
                }
                else
                {
                    UsuarioDAO.modificarUsuario(usuarioEdicion);
                    MessageBox.Show("Usuario modificado");
                }
                CrudUsuario crudUsuario = new CrudUsuario();
                crudUsuario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void cargarCargos()
        {
            cargos = new List<string>();
            cargos.Add("Administrativo");
            cargos.Add("Soporte");
            cargos.Add("Agente de Tránsito");
            cargos.Add("Perito");
            cbCargo.ItemsSource = cargos;
        }

        private void cargarDelegaciones()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            cbDelegacion.DisplayMemberPath = "Nombre";
            cbDelegacion.ItemsSource = delegaciones;
        }


        private bool validarCampos()
        {
            return (tbUsuario.Text == "" ||
                tbContrasenia.Text == "" ||
                tbNombre.Text == "" ||
                tbApellidoPaterno.Text == "" ||
                tbApellidoMaterno.Text == "" ||
                cbCargo.SelectedItem == null ||
                cbDelegacion.SelectedItem == null) ? false : true;
        }

        private void llenarCampos()
        {
            tbUsuario.Text = usuarioEdicion.NombreUsuario;
            tbNombre.Text = usuarioEdicion.Nombre;
            tbApellidoPaterno.Text = usuarioEdicion.ApellidoPaterno;
            tbApellidoMaterno.Text = usuarioEdicion.ApellidoMaterno;
            cbCargo.SelectedItem = usuarioEdicion.Cargo;
            cbDelegacion.SelectedItem = usuarioEdicion.Delegacion;
        }

    }
}
