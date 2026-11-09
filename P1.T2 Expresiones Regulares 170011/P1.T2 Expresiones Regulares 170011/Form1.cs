using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1.T2_Expresiones_Regulares_170011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string id, nombre, apellidoP, apellidoM, telefono, correo, usuario, contraseña;
            int cont=0;
            Stack errores = new Stack();

            //id 9 digitos (XXX-XX-XXXX)
            id = txtId.Text;
            Regex exprRegId = new Regex(@"^[0-9]{3}['\-']{1}[0-9]{3}['\-']{1}[0-9]{4}$");
            if (exprRegId.IsMatch(id))
                cont++;
            else
                errores.Push("ID -");

            //nombre 10 caracteres maximo (mayusculas)
            nombre = txtNombre.Text;
            Regex exprRegNom = new Regex(@"^[A-Z]{1,10}$");
            if (exprRegNom.IsMatch(nombre))
                cont++;
            else
                errores.Push("Nombre -");

            //apellido paterno 20 caracteres maximo (mayus)
            apellidoP = txtAPaterno.Text;
            Regex exprRegAP = new Regex(@"^[A-Z]{1,20}$");
            if (exprRegAP.IsMatch(apellidoP))
                cont++;
            else
                errores.Push("Apellido Paterno -");

            //apellido materno 20 caracteres maximo (mayus)
            apellidoM = txtAMaterno.Text;
            Regex exprRegAM = new Regex(@"^[A-Z]{1,20}$");
            if (exprRegAM.IsMatch(apellidoM))
                cont++;
            else
                errores.Push("Apellido Materno -");

            //telefono 10 digitos (XXX-XXX-XXXX)
            telefono = txtTel.Text;
            Regex exprRegTel = new Regex(@"^[0-9]{3}['\-']{1}[0-9]{3}['\-']{1}[0-9]{4}$");
            if (exprRegTel.IsMatch(telefono))
                cont++;
            else
                errores.Push("Teléfono -");

            //correo (descripcion@dominio.terminacion (minuscula))
            correo = txtCorreo.Text;
            Regex exprRegCorreo = new Regex(@"^[a-zA-Z]{1,}['\@'][a-zA-Z]{1,}['\.'][a-z]{1,}$");
            if (exprRegCorreo.IsMatch(correo))
                cont++;
            else
                errores.Push("Correo -");

            //usuario 8 caracteres minimo (minusculas, simbolos_ - . letras y numeros)
            usuario = txtUsuario.Text;
            Regex exprRegUsuario = new Regex(@"([a-z]|[0-9]|[\-|\.|?_?]){8,}$");
            if (exprRegUsuario.IsMatch(usuario))
                cont++;
            else
                errores.Push("Usuario -");

            //contraseña 8 caracteres minimo (numeros, letras, mayus y minus [@ # $ - _])
            contraseña = txtContraseña.Text;
            Regex exprRegContraseña = new Regex(@"([a-zA-Z]|[0-9]|[\@|\#|\$|\-|$_$]){8,}$");
            if (exprRegContraseña.IsMatch(contraseña))
                cont++;
            else
                errores.Push("Contraseña -");

            if (cont == 8)
                MessageBox.Show("OK!");
            else
                for (int i = 0; i < 8; i++)
                    

                MessageBox.Show("Campos incorrectos:" );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtTel.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
    }
}
