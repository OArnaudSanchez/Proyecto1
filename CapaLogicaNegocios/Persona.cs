using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
	public class Persona
	{

		private string nombre;
		private string apellido;
		private int edad;
		private DateTime fechaNacimiento;
		private string direccion;
		private string provincia;
		private string pais;
		private string telefono;
		private string celular;

		//Propiedades
		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public string Apellido {
			get {
				return apellido;
			}
			set {
				apellido = value;
			}
		}

		public int Edad {
			get {
				return edad;
			}
			set {
				if (value > 0)
				{
					edad = value;
				}
				else {
					edad = 000;
				}
			}
		}

		public DateTime Fechanacimiento {
			get {
				return fechaNacimiento;
			}
			set {
				fechaNacimiento = value;
			}
		}

		public string Direccion {
			get {
				return direccion;
			}
			set {
				direccion = value;
			}
		}

		public string Provincia {
			get {
				return provincia;
			}
			set {
				provincia = value;
			}
		}

		public string Pais {
			get {
				return pais;
			}
			set {
				pais = value;
			}
		}

		public string Telefono {
			get {
				return telefono;
			}
			set {
				telefono = value;
			}
		}

		public string Celular {
			get {
				return celular;
			}
			set {
				celular = value;
			}
		}
	}
}

