using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Persona
    {
        private int idPersona;
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private string direccion;
        private DateTime fechaNacimiento;
        private string rol;
        private string clave;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public int IdPersona
        {
            get { return idPersona; }
            set
            {
                if (value >= 0)
                    idPersona = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    apellido = value;
            }
        }

        public string DNI
        {
            get { return dni; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    dni = value;
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    telefono = value;
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    direccion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                if (value <= DateTime.Now)
                    fechaNacimiento = value;
            }
        }

        public string Rol
        {
            get { return rol; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    rol = value;
            }
        }
        // Constructor vacío (opcional)
        public Persona() { }

        // Constructor con parámetros (opcional)
        public Persona(int idPersona, string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaNacimiento, string rol, string clave)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
            this.rol = rol;
            this.clave = clave;
        }
    }
}
