using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Moto : Vehiculo, ISerializable
    {
        //FIELDS
        private Single _cilindrada;
        //PROPERTIES
        public Single Cilindrada
        {
            get
            {
                return _cilindrada;
            }
            set
            {
                _cilindrada = value;
            }
        }
        //METHODS
        public Moto()
        {

        }
        public Moto(string patente, string marca, eColores color, Single cilindrada) : base(patente, marca, color){
            this._cilindrada = cilindrada;
        }
        public bool Serializar(string ruta)
        {
            try
            {
                XmlTextWriter miEscritor = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializador = new XmlSerializer(typeof(Moto));
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
                XmlSerializer serializador = new XmlSerializer(typeof(Moto));
                Moto miMoto = (Moto)serializador.Deserialize(miLector);
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
            StringBuilder sbMoto = new StringBuilder();
            sbMoto.AppendLine("MOTO");
            sbMoto.Append(base.ToString());
            sbMoto.Append("Cilindrada: " + _cilindrada + "/");
            return sbMoto.ToString();
        }
    }
}
