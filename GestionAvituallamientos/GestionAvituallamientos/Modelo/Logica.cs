using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{
    public class Logica
    {
        public ObservableCollection<Producto> ListaProductos { get; set; }
        public ObservableCollection<Carrera> ListaCarreras { get; set; }

        public Logica()
        {
            ListaCarreras = new ObservableCollection<Carrera>();
            ListaProductos = new ObservableCollection<Producto>();
        }

        public void modificarProducto(Producto p, int posicion)
        {
            ListaProductos[posicion] = p;

        }

        public void modificarAvituallamiento(ClaseAvituallamiento a, int posCarrera, int posAvi)
        {
            ListaCarreras[posCarrera].ListaAvituallamiento[posAvi] = a;
        }
    }
}
