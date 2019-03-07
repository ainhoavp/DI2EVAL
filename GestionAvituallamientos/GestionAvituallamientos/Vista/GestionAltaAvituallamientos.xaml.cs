using GestionAvituallamientos.Modelo;
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

namespace GestionAvituallamientos.Vista
{
    /// <summary>
    /// Lógica de interacción para GestionAltaAvituallamientos.xaml
    /// </summary>
    public partial class GestionAltaAvituallamientos : Window
    {
        public Logica Logica { get; set; }
        public Carrera Carrera { get; set; }
        public Carrera CarreraSeleccionada { get; set; }
        public ClaseAvituallamiento AvituallamientoSeleccionado { get; set; }
        public int PosicionAvituallamiento { get; set; }
        public int PosicionCarrera { get; set; }
        private int contadorErrores;



        public GestionAltaAvituallamientos(Logica logica)
        {
            InitializeComponent();
            this.Logica = logica;
            Carrera = new Carrera();
            tbNombreCarrera.DataContext = this.Carrera;
            dgAvituallamientosCarrera.DataContext = this.CarreraSeleccionada;
            DataContext = this;
            if (this.Logica.ListaCarreras.Count == 0)
            {
                btAddAvituallamiento.IsEnabled = false;
                buttonModificarAvituallamiento.IsEnabled = false;
                buttonBorrarAvituallamiento.IsEnabled = false;
                bttBorrarCarrera.IsEnabled = false;
            }
            else
            {
                btAddAvituallamiento.IsEnabled = true;
                buttonModificarAvituallamiento.IsEnabled = true;
                buttonBorrarAvituallamiento.IsEnabled = true;
                bttBorrarCarrera.IsEnabled = true;
            }
        }

        private void btAddAvituallamiento_Click(object sender, RoutedEventArgs e)
        {

            VentanaAvituallamiento vAvituallamiento = new VentanaAvituallamiento(Logica, CarreraSeleccionada);
            vAvituallamiento.ShowDialog();

        }

        private void btAltaCarrera_Click(object sender, RoutedEventArgs e)
        {
            Logica.ListaCarreras.Add(Carrera);
            Carrera = new Carrera();
            tbNombreCarrera.DataContext = this.Carrera;
            if (Logica.ListaCarreras.Count != 0)
            {
                btAddAvituallamiento.IsEnabled = true;
                buttonModificarAvituallamiento.IsEnabled = true;
                buttonBorrarAvituallamiento.IsEnabled = true;
                bttBorrarCarrera.IsEnabled = true;
            }

        }

        private void dgCarrerasExistentes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CarreraSeleccionada = (Carrera)dgCarrerasExistentes.SelectedItem;
            dgAvituallamientosCarrera.DataContext = this.CarreraSeleccionada;
        }

        private void btGestionarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgAvituallamientosCarrera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.AvituallamientoSeleccionado = (ClaseAvituallamiento)dgAvituallamientosCarrera.SelectedItem;
            this.PosicionAvituallamiento = dgAvituallamientosCarrera.SelectedIndex;
        }

        private void buttonModificarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {
            this.PosicionCarrera = dgCarrerasExistentes.SelectedIndex;
            this.PosicionAvituallamiento = dgAvituallamientosCarrera.SelectedIndex;
            this.AvituallamientoSeleccionado = (ClaseAvituallamiento)dgAvituallamientosCarrera.SelectedItem;
            VentanaAvituallamiento vAvituallamiento = new VentanaAvituallamiento(Logica, PosicionCarrera, this.AvituallamientoSeleccionado, PosicionAvituallamiento);
            vAvituallamiento.Show();
        }

        private void bttBorrarCarrera_Click(object sender, RoutedEventArgs e)
        {
            int indexCarrera = dgCarrerasExistentes.SelectedIndex;
            Logica.ListaCarreras.RemoveAt(indexCarrera);
            if (Logica.ListaCarreras.Count == 0)
            {
                btAddAvituallamiento.IsEnabled = false;
                buttonModificarAvituallamiento.IsEnabled = false;
                buttonBorrarAvituallamiento.IsEnabled = false;
                bttBorrarCarrera.IsEnabled = false;
            }
        }

        private void buttonBorrarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {
            Carrera c = (Carrera)dgCarrerasExistentes.SelectedItem;
         
                int indexAvituallamiento = dgAvituallamientosCarrera.SelectedIndex;

                if (indexAvituallamiento==0 || indexAvituallamiento >0)
                {
                    c.ListaAvituallamiento.RemoveAt(indexAvituallamiento);
                   
                }
                else
                {
                     MessageBox.Show("No hay avituallamientos disponibles para borrar.");
            }
        }



        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                contadorErrores++;
            }
            else
            {
                contadorErrores--;
            }

            if (contadorErrores == 0)
            {
                labelError.Content = "";
                btAltaCarrera.IsEnabled = true;
            }
            else
            {
                labelError.Content = "Error: El nombre de la carrera no puede ser vacío";
                btAltaCarrera.IsEnabled = false;
            }
        }


    }
}
