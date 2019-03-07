using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{
    public class Carrera : IDataErrorInfo
    {

        public String Nombre { get; set; }
        public ObservableCollection<ClaseAvituallamiento> ListaAvituallamiento { get; set; }


        public Carrera(String nombre)
        {
            this.Nombre = nombre;
            ListaAvituallamiento = new ObservableCollection<ClaseAvituallamiento>();
        }

        public Carrera()
        {
            ListaAvituallamiento = new ObservableCollection<ClaseAvituallamiento>();
        }


        public override string ToString()
        {
            return "Nombre carrera: " + ", numero de avituallamientos: " + ListaAvituallamiento.Count;

        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string resultado = "";

                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                    {
                        resultado = "El nombre de la carrera no puede ser vacío";
                    }

                }
                return resultado;
            }
        }
    }
}
