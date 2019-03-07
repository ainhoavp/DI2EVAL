using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{
    public class PersonaContacto : IDataErrorInfo, INotifyPropertyChanged, ICloneable
    {
        private String nombre;
        public String Nombre
        {
            get { return nombre; }

            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        private int telefono;
        public int Telefono
        {

            get { return telefono; }

            set
            {
                this.telefono = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Telefono"));
            }
        }

        public PersonaContacto()
        {
        }

        public PersonaContacto(String nombre, int telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
        }


        public override string ToString()
        {
            return "Nombre: " + Nombre + " teléfono de contacto: " + Telefono;
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
                        resultado = "Error: El nombre no puede ser vacío";
                }

                if (columnName == "Telefono")
                {
                    if (Telefono == 0)
                        resultado = "Error: El telefono no puede ser 0.";
                }
                return resultado;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
