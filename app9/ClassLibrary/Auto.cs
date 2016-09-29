using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Auto : Vehiculo, ISerializable
    {
        //FIELDS
        private int _cantidadPuertas;
        //PROPERTIES
        public int CantidadPuertas
        {
            get
            {
                return _cantidadPuertas;
            }
            set
            {
                _cantidadPuertas = value;
            }
        }
        //METHODS
        public Auto()
        {

        }
        public Auto(string patente, string marca, eColores color, int cantidad) : base(patente, marca, color){
            this._cantidadPuertas = cantidad;
        }
        public bool Serializar(string ruta)
        {
            try
            {
                XmlTextWriter miEscritor = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializador = new XmlSerializer(typeof(Auto));
                serializador.Serialize(miEscritor, this);
                miEscritor.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Deserializar(string ruta)
        {
            try
            {
                XmlTextReader miLector = new XmlTextReader(ruta);
                XmlSerializer serializador = new XmlSerializer(typeof(Auto));
                Auto miAuto = (Auto)serializador.Deserialize(miLector);
                miLector.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sbAuto = new StringBuilder();
            sbAuto.AppendLine("AUTO");
            sbAuto.Append(base.ToString());
            sbAuto.Append("Puertas: " + _cantidadPuertas + "/");
            return sbAuto.ToString();
        }
    }
}
