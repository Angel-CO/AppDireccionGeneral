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
using System.Text.RegularExpressions;


namespace AppDireccionGeneral.vista
{
    /// <summary>
    /// Interaction logic for FormularioDelegacion.xaml
    /// </summary>
    public partial class FormularioDelegacion : Window
    {
        private bool esNuevo;
        private Delegacion delegacionEdicion;
        private List<Municipio> municipios;
        public FormularioDelegacion()
        {
            InitializeComponent();
            this.lbTitulo.Content = "Registrar delegación";
            cargarMunicipios();
            cargarTipoDelegaciones();
            esNuevo = true;
        }

        public FormularioDelegacion(Delegacion delegacion): this()
        {
            delegacionEdicion = delegacion;
            this.lbTitulo.Content = "Modificar delegación";
            cargarDatosDelegacion();
            esNuevo = false;
        }

        private void cargarMunicipios()
        {
            municipios = MunicipioDAO.getAllMunicipios();
            cbMunicipio.DisplayMemberPath = "Nombre";
            cbMunicipio.ItemsSource = municipios;
        }

        private void cargarTipoDelegaciones()
        {
            List<String> tipoDelegaciones = new List<String>();
            tipoDelegaciones.Add("Municipal");
            tipoDelegaciones.Add("General");
            this.cbTipoDelegacion.ItemsSource = tipoDelegaciones;
        }

        private bool validarDatos()
        {
            bool datosValidos = true;
            string erTelefono = @"[0-9]{10}$";
            string erCodigoPostal = @"[0-9A-Z]{5}$";

            if (!tbNombre.Text.Equals(""))
            {
                tbNombre.BorderBrush = Brushes.Green;
            }
            else
            {
                tbNombre.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (!tbCalle.Text.Equals(""))
            {
                tbCalle.BorderBrush = Brushes.Green;
            }
            else
            {
                tbCalle.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (!tbNumero.Text.Equals(""))
            {
                tbNumero.BorderBrush = Brushes.Green;
            }
            else
            {
                tbNumero.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (!tbColonia.Text.Equals(""))
            {
                tbColonia.BorderBrush = Brushes.Green;
            }
            else
            {
                tbColonia.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbCodigoPostal.Text, erCodigoPostal))
            {
                tbCodigoPostal.BorderBrush = Brushes.Green;
            }
            else
            {
                tbCodigoPostal.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (Regex.IsMatch(tbTelefono.Text, erTelefono))
            {
                tbTelefono.BorderBrush = Brushes.Green;
            }
            else
            {
                tbTelefono.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if (!tbCorreo.Text.Equals(""))
            {
                tbCorreo.BorderBrush = Brushes.Green;
            }
            else
            {
                tbCorreo.BorderBrush = Brushes.Red;
                datosValidos = false;
            }

            if(!(cbMunicipio.SelectedIndex >= 0))
            {
                datosValidos = false;
            }

            if (!(cbTipoDelegacion.SelectedIndex >= 0))
            {
                datosValidos = false;
            }

            return datosValidos;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                if (esNuevo)
                {
                    DelegacionDAO.registrarDelegacion(crearDelegacion());
                    MessageBox.Show("Delegación registrada");
                }
                else
                {
                    DelegacionDAO.modificarDelegacion(crearDelegacion());
                    MessageBox.Show("Delegacion modificada");
                }
                CrudDelegacion crudDelegacion = new CrudDelegacion();
                crudDelegacion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private Delegacion crearDelegacion()
        {
            Delegacion delegacion = new Delegacion();

            if (!esNuevo)
            {
                delegacion.IdDelegacion = delegacionEdicion.IdDelegacion;
            }

            delegacion.Nombre = tbNombre.Text;
            delegacion.Calle = tbCalle.Text;
            delegacion.Numero = tbNumero.Text;
            delegacion.Colonia = tbColonia.Text;
            delegacion.CodigoPostal = tbCodigoPostal.Text;
            delegacion.Telefono = tbTelefono.Text;
            delegacion.Correo = tbCorreo.Text;
            delegacion.TipoDelegacion = (String)cbTipoDelegacion.SelectedItem;
            delegacion.IdMunicipio = ((Municipio)cbMunicipio.SelectedItem).IdMunicipio;

            return delegacion;
        }

        private void cargarDatosDelegacion()
        {
            tbNombre.Text = delegacionEdicion.Nombre;
            tbCalle.Text = delegacionEdicion.Calle;
            tbNumero.Text = delegacionEdicion.Numero;
            tbColonia.Text = delegacionEdicion.Colonia;
            tbCodigoPostal.Text = delegacionEdicion.CodigoPostal.ToString();
            tbTelefono.Text = delegacionEdicion.Telefono.ToString();
            tbCorreo.Text = delegacionEdicion.Correo;
            cbMunicipio.SelectedIndex = delegacionEdicion.IdMunicipio -1;
            cbTipoDelegacion.SelectedItem = delegacionEdicion.TipoDelegacion;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            CrudDelegacion crudDelegacion = new CrudDelegacion();
            crudDelegacion.Show();
            this.Close();
        }
    }
}
