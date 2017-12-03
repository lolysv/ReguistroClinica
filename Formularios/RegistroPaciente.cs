using System;
using System.Collections;
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
    public partial class frmRegistroPaciente : Form
    {

        ArrayList Pacientes = new ArrayList();

        public frmRegistroPaciente()
        {

            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Paciente paciente1 = new Paciente();
            paciente1.Codigo = "0001";
            paciente1.Nombres = "Alejandra";
            paciente1.Apellidos = "Zanchez";
            paciente1.Direccion = "Col el Rosal 5a Av N pasaje 56";
            paciente1.FechaNacimiento = new DateTime(1995, 5, 21);
            paciente1.Edad = 22;
            paciente1.Telefono = "76853324";
            paciente1.User = "AleZanchez95";
            paciente1.Pass = "1234";

            Pacientes.Add(paciente1);

            Paciente paciente2 = new Paciente();
            paciente2.Codigo = "0002";
            paciente2.Nombres = "Jose";
            paciente2.Apellidos = "Flores";
            paciente2.Direccion = "Residencial Monte Carmelo Av. 234 Pasaje 13";
            paciente2.FechaNacimiento = new DateTime(1990, 2, 14);
            paciente2.Edad = 32;
            paciente2.Telefono = "70005674";
            paciente2.User = "JF90";
            paciente2.Pass = "112233";

            Pacientes.Add(paciente2);

            dtgListado.DataSource = Pacientes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodPa.Text == "")
            {
                errorProvider1.SetError(txtCodPa, "Ingrese un Codigo de Paciente");
                txtCodPa.Focus();
                return;
            }
            errorProvider1.SetError(txtCodPa, "");
            

            if (Existe(txtCodPa.Text))
            {
                errorProvider1.SetError(txtCodPa, "El Codigo Paciente ya a sido Registrado");
                txtCodPa.Focus();
                return;
            }
            errorProvider1.SetError(txtCodPa, "");
            


            if (txtNombrePa.Text == "")
            {
                errorProvider1.SetError(txtNombrePa, "Ingrese Nombre del Paciente");
                txtNombrePa.Focus();
                return;
            }
            errorProvider1.SetError(txtNombrePa, "");

            if (txtApellidosPa.Text == "")
            {
                errorProvider1.SetError(txtApellidosPa, "Ingrese Apellidos del Paciente");
                txtApellidosPa.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidosPa, "");


            if (txtDireccionPa.Text == "")
            {
                errorProvider1.SetError(txtDireccionPa, "Ingrese la Residencia del Paciente");
                txtDireccionPa.Focus();
                return;
            }
            errorProvider1.SetError(txtDireccionPa, "");

            if (nupEdad.Value == 0)
            {
                errorProvider1.SetError(nupEdad, "Ingrese una edad valida");
                nupEdad.Focus();
                return;
            }
            errorProvider1.SetError(nupEdad, "");

            if (txtTelefonoPa.Text == "")
            {
                errorProvider1.SetError(txtTelefonoPa, "Ingrese un Telefono");
                txtTelefonoPa.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefonoPa, "");

            if (txtTelefonoPa.Text.Trim().Length != 8)
            {
                errorProvider1.SetError(txtTelefonoPa, "Ingrese un Telefono de 8 digitos");
                return; 
            }
            errorProvider1.SetError(txtTelefonoPa,"");

            
            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Ingrese un User");
                txtUser.Focus();
                return;
            }
            errorProvider1.SetError(txtUser, "");

            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Ingrese un Pass");
                txtPass.Focus();
                return;
            }
            errorProvider1.SetError(txtPass, "");

            Paciente miPaciente = new Paciente();
            miPaciente.Codigo = txtCodPa.Text;
            miPaciente.Nombres = txtNombrePa.Text;
            miPaciente.Apellidos = txtApellidosPa.Text;
            miPaciente.Direccion = txtDireccionPa.Text;
            miPaciente.FechaNacimiento = dtpFecha.Value;
            miPaciente.Edad = nupEdad.Value;
            miPaciente.Telefono = Convert.ToString(txtTelefonoPa);
            miPaciente.User = txtUser.Text;
            miPaciente.Pass = txtPass.Text;
            Pacientes.Add(miPaciente);

            dtgListado.DataSource = null;
            dtgListado.DataSource = Pacientes;

            txtCodPa.Clear();
            txtNombrePa.Clear();
            txtApellidosPa.Clear();
            txtDireccionPa.Clear();
            nupEdad.Value = 0;
            txtTelefonoPa.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtCodPa.Focus();
        }

        private bool Existe(string Codigo)
        {
            foreach (Paciente Paciente in Pacientes)
            {
                if (Paciente.Codigo == Codigo) return true;
            }
            return false;

        }

        private void txtTelefonoPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);

        }

        private void txtCodPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
