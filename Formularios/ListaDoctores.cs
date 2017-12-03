using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmListaDoctores : Form
    {

        public string NombreDoctor { get; set; }

        public frmListaDoctores(string[] doctores)
        {
            InitializeComponent();

            //listView1.Columns.Add("Nombre de Doctor");
            listView1.View = View.List;

            foreach (string doc in doctores)
            {
                var item = new ListViewItem(doc);
                //item.SubItems.Add(doc);
                listView1.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seleccionados = listView1.SelectedItems;

            NombreDoctor = seleccionados[0].Text;

            this.Hide();
        }

        private void ListaDoctores_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
