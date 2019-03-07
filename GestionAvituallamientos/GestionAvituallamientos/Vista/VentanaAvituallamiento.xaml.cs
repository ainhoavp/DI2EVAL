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
    /// Lógica de interacción para VentanaAvituallamiento.xaml
    /// </summary>
    public partial class VentanaAvituallamiento : Window
    {
        public Logica Logica { get; set; }
        public Carrera CarreraSeleccionada { get; set; }
        public ClaseAvituallamiento Avituallamiento { get; set; }
        public int PosicionCarrera { get; set; }
        public int PosAvituallamiento { get; set; }
        private Boolean Modificar { get; set; }
        

        public VentanaAvituallamiento(Logica logica, Carrera carreraSeleccionada)
        {
            InitializeComponent();
            this.Logica = logica;
            this.CarreraSeleccionada = carreraSeleccionada;
            Avituallamiento = new ClaseAvituallamiento();
            tbPuntoKm.DataContext = this.Avituallamiento;
            tbNombrePC.DataContext = this.Avituallamiento;
            tbTel.DataContext = this.Avituallamiento;
            dtProductos.DataContext = this.Avituallamiento;
            Modificar = false;

        }

        //se sobreescribe el constructor para modificar Avituallamiento.
        public VentanaAvituallamiento(Logica logica, int posCarrera, ClaseAvituallamiento avituallamiento, int posAvituallamiento)
        {
            InitializeComponent();
            this.Logica = logica;
            this.PosicionCarrera = posCarrera;
            this.PosAvituallamiento = posAvituallamiento;
            this.Avituallamiento = avituallamiento;
            tbPuntoKm.DataContext = this.Avituallamiento;
            tbNombrePC.DataContext = this.Avituallamiento;
            tbTel.DataContext = this.Avituallamiento;
            dtProductos.DataContext = this.Avituallamiento;
            Modificar = true;

        }

        
       private void botonAdd_Click(object sender, RoutedEventArgs e)
        {
            VentaListaProductosDeAlta productosSistema = new VentaListaProductosDeAlta(Logica, Avituallamiento);
            productosSistema.ShowDialog();

        }

        private void btAceptar_Click(object sender, RoutedEventArgs e)
        {

            if (Modificar)
            {
                Logica.ListaCarreras[PosicionCarrera].ListaAvituallamiento[PosAvituallamiento] = this.Avituallamiento;
                this.Close();
            }
            else
            {

            this.CarreraSeleccionada.ListaAvituallamiento.Add(this.Avituallamiento);
            this.Close();
            }
        }

        private void bttBorrarProductos_Click(object sender, RoutedEventArgs e)
        {
            if (dtProductos.SelectedIndex != -1)
            {
                int indexProducto = dtProductos.SelectedIndex;
                Avituallamiento.MaterialDisponible.RemoveAt(indexProducto);
            }
            else
            {
                MessageBox.Show("No hay productos para borrar");
            }
        }

   
    }
}
