using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
	public partial class presentacion : Form
	{
		Persona p = new Persona();
		public presentacion()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
				try
				{
					p.Nombre = tNombre.Text;
					p.Apellido = tApellido.Text;
					p.Edad = int.Parse(tEdad.Text);
					p.Fechanacimiento = DateTime.Parse(tFechaNacimiento.Text);
					p.Direccion = tDireccion.Text;
					p.Provincia = tProvincia.Text;
					p.Pais = tPais.Text;
					p.Telefono = tTelefono.Text;
					p.Celular = tCelular.Text;

					MessageBox.Show("Los datos se ingresaron correctamente");



				}
				catch (Exception error)
				{
					MessageBox.Show("Ingrese los datos Correctamente...");
				}
			
			limpiar();
			ver();
		}

		void ver()
		{
			try {
				DataGridViewRow fila = new DataGridViewRow();
				fila.CreateCells(dataGridView1);
				fila.Cells[0].Value = p.Nombre;
				fila.Cells[1].Value = p.Apellido;
				fila.Cells[2].Value = p.Edad;
				fila.Cells[3].Value = p.Fechanacimiento;
				fila.Cells[4].Value = p.Direccion;
				fila.Cells[5].Value = p.Provincia;
				fila.Cells[6].Value = p.Pais;
				fila.Cells[7].Value = p.Telefono;
				fila.Cells[8].Value = p.Celular;

				dataGridView1.Rows.Add(fila);
			} catch (Exception error) {
				MessageBox.Show(error.Message);
			}
			
		}
		void limpiar()
		{
			tNombre.Clear();
			tApellido.Clear();
			tEdad.Clear();
			tFechaNacimiento.Clear();
			tDireccion.Clear();
			tProvincia.Clear();
			tPais.Clear();
			tTelefono.Clear();
			tCelular.Clear();
		}

		private void presentacion_Load(object sender, EventArgs e)
		{
			ver();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
		}
	}
}
