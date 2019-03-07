using GestionAvituallamientos.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para ModificarProducto.xaml
    /// </summary>
    public partial class ModificarProducto : Window
    {
        Logica Logica { get; set; }
        public Producto ProductoModificar { get; set; }
        private int Posicion { get; set; }
        public ObservableCollection<String> listaProductos { get; set; }

        public ModificarProducto(Logica logica, int posicion)
        {
            InitializeComponent();
            this.Logica = logica;
            Producto productoSinModificar = logica.ListaProductos[posicion];
            listaProductos = new ObservableCollection<string>() { "Bebida", "Comida", "Material sanitario" };
            ProductoModificar = new Producto(productoSinModificar.Nombre, productoSinModificar.TipoProducto, productoSinModificar.Precio);
            this.Posicion = posicion;
            tbNombreNuevo.DataContext = ProductoModificar;
            tbPrecioNuevo.DataContext = ProductoModificar;
            cbTipo.DataContext = this;
            
        }

        private void bttAceptar_Click(object sender, RoutedEventArgs e)
        {
            Logica.modificarProducto(ProductoModificar, Posicion);
            this.Close();
        }

        private void bttCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbNombreNuevo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
