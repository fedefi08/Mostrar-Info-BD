using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexcionBdDiscos
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            dtDiscos.AutoGenerateColumns = true; // Habilitar generación automática
        }

        private void btnCargarDiscos_Click(object sender, EventArgs e)
        {
            VisualizarDiscos ViDiscos = new VisualizarDiscos();

            try
            {
                List<Discos> listaDiscos = ViDiscos.Listar();
                if (listaDiscos.Count > 0)
                {
                    dtDiscos.DataSource = listaDiscos;
                }
                else
                {
                    MessageBox.Show("No se encontraron discos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar discos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
