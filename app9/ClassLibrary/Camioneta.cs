using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Camioneta : Vehiculo, ISerializable
    {
        //FIELDS
        private double _altura;
        //PROPERTIES
        public double Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                _altura = value;
            }
        }
        //METHODS
        public Camioneta()
        {

        }
        public Camioneta(string patente, string marca, eColores color, double altura) : base(patente, marca, color){
            this._altura = altura;
        }
        public bool Serializar(string ruta)
        {
            try
            {
                XmlTextWriter miEscritor = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializador = new XmlSerializer(typeof(Camioneta));
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
                XmlSerializer serializador = new XmlSerializer(typeof(Camioneta));
                Camioneta miCamioneta = (Camioneta)serializador.Deserialize(miLector);
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
            StringBuilder sbCamioneta = new StringBuilder();
            sbCamioneta.AppendLine("CAMIONETA");
            sbCamioneta.Append(base.ToString());
            sbCamioneta.Append("Altura: " + _altura + "/");
            return sbCamioneta.ToString();
        }
    }
}
