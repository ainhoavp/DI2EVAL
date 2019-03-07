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
    /// Lógica de interacción para VentaListaProductosDeAlta.xaml
    /// </summary>
    public partial class VentaListaProductosDeAlta : Window
    {
        public Logica Logica { get; set; }
        public ClaseAvituallamiento AvituallamientoCreado { get; set; }
        public Producto ProductoSeleccionado {get; set;}
        public ProductoAvituallamiento ProductoAvituallamiento { get; set; }

        public VentaListaProductosDeAlta(Logica logica, ClaseAvituallamiento avituallamientoCreado)
        {
            InitializeComponent();
            this.Logica = logica;
            this.AvituallamientoCreado = avituallamientoCreado;
            this.ProductoAvituallamiento = new ProductoAvituallamiento();
            DataContext = this;
            
        }

        private void btAddProducto_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridProductosDisponibles.SelectedIndex != -1)
            {
                AvituallamientoCreado.MaterialDisponible.Add(this.ProductoAvituallamiento);
            }
            else {
                MessageBox.Show("No hay productos disponibles, primero debes agregarlos.");
            }
            this.Close();
        }

        

     
    }
}
