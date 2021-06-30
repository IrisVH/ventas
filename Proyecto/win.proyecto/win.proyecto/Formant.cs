using BL.proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win.proyecto
{
    public partial class Formant : Form
    {
        mantenimientoBL _mantenimient;
        public Formant()
        {
            InitializeComponent();

            _mantenimient = new mantenimientoBL();
            mantenimientoBL_manteniBindingSource.DataSource = _mantenimient.obtenermantenimientos();
        }

        private void mantenimientoBL_manteniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Formant_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoBL_manteniBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void horaLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void horaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void horaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mantenimientoBL_manteniBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
