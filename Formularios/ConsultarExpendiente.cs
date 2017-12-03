using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Formularios
{
    public partial class frmConsultarExpediente : Form
    {
        string codigo;
        int indice;

        bool B = false, auxiliar = false;
        ArrayList objCodigo = new ArrayList();
        ArrayList objNombres = new ArrayList();
        ArrayList objApellidos = new ArrayList();
        ArrayList objEdad = new ArrayList();
        ArrayList objDui = new ArrayList();
        ArrayList objDomicilio = new ArrayList();
        ArrayList objTelefono = new ArrayList();
        ArrayList objDiagnostico = new ArrayList();
        static DataTable objDataView = new DataTable();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = txtCodigo.Text.ToString().Trim();
                while (dgtLista.RowCount > 1)
                {
                    dgtLista.Rows.Remove(dgtLista.CurrentRow);
                }
                dgtLista.Refresh();

                if (objCodigo.Contains(codigo) == true)
                {
                    indice = objCodigo.IndexOf(codigo);
                    txtCodigo.Text = objCodigo[indice].ToString();
                    //Llenando con la busqueda por codigo
                    DataRow N_Busqueda = objDataView.NewRow();
                    N_Busqueda["Codigo"] = objCodigo[indice].ToString();
                    N_Busqueda["Nombres"] = objNombres[indice].ToString();
                    N_Busqueda["Apellidos"] = objApellidos[indice].ToString();
                    N_Busqueda["Edad"] = objEdad[indice].ToString();
                    N_Busqueda["DUI"] = objDui[indice].ToString();
                    N_Busqueda["Domicilio"] = objDomicilio[indice].ToString();
                    N_Busqueda["Telefono"] = objTelefono[indice].ToString();
                    N_Busqueda["Diagnostico"] = objDiagnostico[indice].ToString();
                    //Asignacion
                    objDataView.Rows.Add(N_Busqueda);
                    dgtLista.DataSource = objDataView;
                }
                else
                {
                    MessageBox.Show("Error el Codigo del paciente no existe!");
                    Limpieza();
                    dgtLista.DataSource = null;
                }
            }
            catch
            {

            }
        }


        public frmConsultarExpediente()
        {
            InitializeComponent();
            Limpieza();
            llenar();
            objDataView.Columns.Add("Codigo");
            objDataView.Columns.Add("Nombres");
            objDataView.Columns.Add("Apellidos");
            objDataView.Columns.Add("Edad");
            objDataView.Columns.Add("DUI");
            objDataView.Columns.Add("Domicilio");
            objDataView.Columns.Add("Telefono");
            objDataView.Columns.Add("Diagnostico");
            dgtLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtLista.AllowUserToAddRows = false;
            dgtLista.RowHeadersVisible = false;
            dgtLista.ReadOnly = true;
        }

        public void llenar()
        {
            objCodigo.Add("0001");
            objCodigo.Add("0002");
            objCodigo.Add("0003");
            objNombres.Add("Claudia Berenice");
            objNombres.Add("Jose Antonio");
            objNombres.Add("Alex Noe");
            objApellidos.Add("Chacon Oliva");
            objApellidos.Add("Rivas Domingues");
            objApellidos.Add("Estrada Menjivar");
            objEdad.Add("14");
            objEdad.Add("21");
            objEdad.Add("30");
            objDui.Add("024567881-9");
            objDui.Add("09784417-1");
            objDui.Add("03778946-4");
            objDomicilio.Add("Calle Don Bosco Av. Manuel Gallardo casa 1, santa Tecla");
            objDomicilio.Add(" Calle a Plan del Pino, pasaje 2, Soyapango");
            objDomicilio.Add(" Av. Sur, Barrio El Ángel, Cantón Loma Alta, Santa Ana");
            objTelefono.Add("2222-0000");
            objTelefono.Add("2211-0033");
            objTelefono.Add("2525-6777");
            objDiagnostico.Add("Riesgo de embarazo");
            objDiagnostico.Add("Diarrea");
            objDiagnostico.Add("Sindrome de Down");
        }

        public void Limpieza()
        {
            txtCodigo.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
