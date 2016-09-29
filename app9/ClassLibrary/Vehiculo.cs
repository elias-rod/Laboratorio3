using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Vehiculo
    {
        //FIELDS
        private eColores _color;
        private string _marca;
        private string _patente;
        //PROPERTIES
        public eColores Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        public string Patente
        {
            get
            {
                return _patente;
            }
            set
            {
                _patente = value;
            }
        }
        //METHODS
        public Vehiculo()
        {

        }
        public Vehiculo(string patente, string marca, eColores color)
        {
            _color = color;
            _marca = marca;
            _patente = patente;
        }
        public int OrdenarPorPatente(Vehiculo aux1, Vehiculo aux2)
        {
            return string.Compare(aux1._patente, aux2._patente, true);
        }
        public override string ToString()
        {
            StringBuilder sbVehiculo = new StringBuilder();
            sbVehiculo.AppendLine("Patente: " + _patente + "/");
            sbVehiculo.Append("Marca: " + _marca + "/");
            sbVehiculo.Append("Color: " + _color.ToString() + "/");
            return sbVehiculo.ToString();
        }
    }
}
