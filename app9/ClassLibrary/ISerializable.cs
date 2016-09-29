using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface ISerializable
    {
        //METHODS
        bool Deserializar(string ruta);
        bool Serializar(string ruta);
    }
}
