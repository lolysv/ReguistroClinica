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
    public partial class frmInicioSesion : Form
    {
        

        ArrayList usuario1 = new ArrayList();
        ArrayList usuario2 = new ArrayList();
        ArrayList usuario3 = new ArrayList();
        ArrayList pass1 = new ArrayList();
        ArrayList pass2 = new ArrayList();
        ArrayList pass3 = new ArrayList();
        //ArrayList nivel = new ArrayList();

        DataTable datos = new DataTable();

        int i = 0;
       
       
        public frmInicioSesion()
        {
            InitializeComponent();
           
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            //Creo las columans en el DataTable
            llenar();
            datos.Columns.Add("Usuario");
            datos.Columns.Add("Pass");
            //datos.Columns.Add("Nivel");

        }
         private void listar() 
         {
            //Cuenta la cantidad de registros que hay en el arraylist 'carnet'
            //while (i < nivel.Count)
            {
                //Crea un DataRow para el DataTable 'datos'
                DataRow fila = datos.NewRow();
                //Le asigna a cada fila por columna, el valor de la casilla del ArrayList por el índice
                fila["Usuario"] = usuario1[i].ToString();
                fila["Usuario"] = usuario2[i].ToString();
                fila["Usuario"] = usuario3[i].ToString();
                fila["Pass"] = pass1[i].ToString();
                fila["Pass"] = pass2[i].ToString();
                fila["Pass"] = pass3[i].ToString();
                //fila["Nivel"] = nivel[i].ToString();****
                //Agrega una fila y los datos halados de los arrayist correspondientes a cada columna
                datos.Rows.Add(fila);
                //incrementa el contador del while y a la vez, el índice de los arrayList
                i++;
            }
          }


        public void llenar()
     
        {
            usuario1.Add("paciente");
            usuario2.Add("doctor");
            usuario3.Add("enfermera");
            pass1.Add("1234");
            pass2.Add("1234");
            pass3.Add("1234");

        
         }



        private void limpiar()
        {
            //rdbPaciente.Checked = true;*/***
            txtUsuario.Text = null;
            txtPass.Text = null;
        }

        //private void agregar()
        //{
        //    if (usuario.Contains(txtUsuario.Text))
        //    {
        //        MessageBox.Show("Usuario Ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    else
        //    {
        //        usuario.Add(txtUsuario.Text);
        //        pass.Add(txtPass.Text);
        //        //nivel.Add(rdbPaciente.Checked ? "Paciente" : rdbDoctor.Checked ? "Doctor" : "Enfermera");
        //        limpiar();
        //    }
        //}

    

        private void button1_Click(object sender, EventArgs e)
        {
            //string Usuario, Pass;
            //{
            //    Usuario = txtUsuario.Text.ToString().Trim();
            //    Pass = txtPass.Text.ToString().Trim();
            //    if (txtUsuario.Text == "")
            //    {
            //        errorProvider1.SetError(txtUsuario, "Ingrese un Usuario");
            //        txtUsuario.Focus();
            //        return;
            //    }
            //    errorProvider1.SetError(txtUsuario, "");
                
            //    if (txtPass.Text == "")
            //    {
            //        errorProvider1.SetError(txtPass, "Ingrese un Pass");
            //        txtPass.Focus();
            //        return;
            //    }
            //    errorProvider1.SetError(txtPass, "");


            //    //if (Usuario == "administrador" && Pass == "123")
            //    //{
            //    //    frmInicioSesion inc = new frmInicioSesion();
            //    //    inc.Show();
            //    //}
            //    //else
            //    //{
            //    //    if (Usuario != "administrador")
            //    //    {
            //    //        MessageBox.Show(this, "  Usuario  incorrecto", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }
            //    //    if (Pass != "123")
            //    //    {
            //    //        MessageBox.Show(this, "  Contraseña  incorrecta", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }

            //    //    // MessageBox.Show(this, "Usuario y/o contraeña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //}

            //    if (txtUsuario.Text != Usuario)
            //    {
            //        MessageBox.Show(this, "  Usuario  incorrecto", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (txtPass.Text != Pass)
            //    {
            //        MessageBox.Show(this, "  Contraseña  incorrecta", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    try 
            //        {
            //            if (usuario1.Contains(Usuario) && pass1.Contains(Pass))
            //                //&& rdbPaciente.Checked)
            //            {
            //                frmPaciente P = new frmPaciente();
            //                P.Show();
                            
            //            }
            //            if (usuario2.Contains(Usuario) && pass2.Contains(Pass))
            //                //&& rdbDoctor.Checked)
            //                {

            //                    frmDoctor D = new frmDoctor();

            //                    D.Show();
            //                }
            //            if (usuario3.Contains(Usuario) && pass3.Contains(Pass))
            //        //&& rdbEnfermera.Checked)
            //                {

            //                    frmEnfermera E = new frmEnfermera();

            //                    E.Show();
            //                }

            //        }
            //    catch
            //        {
            //                MessageBox.Show(this, "Usuario y/o contraeña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        }


            //}
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        
            try
            {
                //Validando Campos Vacíos
                if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Campos Vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Lamando los métodos para agregar, limpiar y listar los datos
                    //agregar();
                    listar();
                    
                }
           
            }
            catch {
                MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Usuario, Pass;
            {
                Usuario = txtUsuario.Text.ToString().Trim();
                Pass = txtPass.Text.ToString().Trim();
                if (txtUsuario.Text == "")
                {
                    errorProvider1.SetError(txtUsuario, "Ingrese un Usuario");
                    txtUsuario.Focus();
                    return;
                }
                errorProvider1.SetError(txtUsuario, "");

                if (txtPass.Text == "")
                {
                    errorProvider1.SetError(txtPass, "Ingrese un Pass");
                    txtPass.Focus();
                    return;
                }
                errorProvider1.SetError(txtPass, "");


                //if (Usuario == "administrador" && Pass == "123")
                //{
                //    frmInicioSesion inc = new frmInicioSesion();
                //    inc.Show();
                //}
                //else
                //{
                //    if (Usuario != "administrador")
                //    {
                //        MessageBox.Show(this, "  Usuario  incorrecto", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    if (Pass != "123")
                //    {
                //        MessageBox.Show(this, "  Contraseña  incorrecta", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                //    // MessageBox.Show(this, "Usuario y/o contraeña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                if (txtUsuario.Text != Usuario)
                {
                    MessageBox.Show(this, "  Usuario  incorrecto", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtPass.Text != Pass)
                {
                    MessageBox.Show(this, "  Contraseña  incorrecta", " ...ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    if (usuario1.Contains(Usuario) && pass1.Contains(Pass))
                    //&& rdbPaciente.Checked)
                    {
                        frmPaciente P = new frmPaciente();
                        P.Show();

                    }
                    if (usuario2.Contains(Usuario) && pass2.Contains(Pass))
                    //&& rdbDoctor.Checked)
                    {

                        frmDoctor D = new frmDoctor();

                        D.Show();
                    }
                    if (usuario3.Contains(Usuario) && pass3.Contains(Pass))
                    //&& rdbEnfermera.Checked)
                    {

                        frmEnfermera E = new frmEnfermera();

                        E.Show();
                    }

                }
                catch
                {
                    MessageBox.Show(this, "Usuario y/o contraeña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            
        }

     
  

       
            
        
        

    }
}
