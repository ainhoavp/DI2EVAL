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

    public partial class VentanaProducto : Window
    {
        public Logica Logica { get; set; }
        public Producto P { get; set; }
        public ObservableCollection<String> listaProductos { get; set; }
        private int contadorErrores;

        public VentanaProducto(Logica logica)
        {
            InitializeComponent();
            this.Logica = logica;
            P = new Producto();
            listaProductos = new ObservableCollection<string>() { "Bebida", "Comida", "Material sanitario" };
            InicializarProducto();
        }

        private void InicializarProducto()
        {
            dgProductosDadosDeAlta.DataContext = Logica;
            tbNombreProducto.DataContext = P;
            tbPrecioProducto.DataContext = P;
            cbTipoProducto.DataContext = this;
        }

        private void botonAniadir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddProducto_Click(object sender, RoutedEventArgs e)
        {
            Logica.ListaProductos.Add(new Producto(P.Nombre,P.TipoProducto,P.Precio));
            LimpiarCampos();
            //P = new Producto();
            //InicializarProducto();
        }

        private void LimpiarCampos()
        {
            P.Nombre = string.Empty;
            P.TipoProducto = string.Empty;
            P.Precio = 0;
        }

        private void bttModificarProducto_Click(object sender, RoutedEventArgs e)
        {
            int posicion = dgProductosDadosDeAlta.SelectedIndex;
            ModificarProducto dialogoModificar = new ModificarProducto(Logica, posicion);
            dialogoModificar.Show();

        }

        private void bttBorrarProducto_Click(object sender, RoutedEventArgs e)
        {
            int posicion = dgProductosDadosDeAlta.SelectedIndex;
            string pos = posicion.ToString();
            Producto pborrar = (Producto)dgProductosDadosDeAlta.SelectedItem;
            if (Logica.ListaCarreras.Count == 0)
            {
                Logica.ListaProductos.RemoveAt(posicion);
            }
            else
            {
                foreach (Carrera carrera in Logica.ListaCarreras)
                {
                    foreach (ClaseAvituallamiento avituallamientoCarrera in carrera.ListaAvituallamiento)
                    {
                        foreach (ProductoAvituallamiento prod in avituallamientoCarrera.MaterialDisponible)
                        {
                            if (prod.Producto.Nombre == pborrar.Nombre)
                            {
                                labelMensaje.Content = "No se puede borrar este producto.\nForma parte de algun avituallamiento";
                            }
                            else
                            {
                                Logica.ListaProductos.RemoveAt(posicion);
                            }
                        }
                    }

                }
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
                AddProducto.IsEnabled = true;
            }
            else
            {
                AddProducto.IsEnabled = false;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }





    }

}

