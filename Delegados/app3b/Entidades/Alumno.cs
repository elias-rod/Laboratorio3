using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        //CAMPOS
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;
        //MÉTODOS
        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._fotoAlumno = ruta;
            this._nombre = nombre;
        }
        //PROPIEDADES
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
        public int Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public string FotoAlumno
        {
            get
            {
                return _fotoAlumno;
            }
            set
            {
                _fotoAlumno = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }
}