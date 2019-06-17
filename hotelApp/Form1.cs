using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hotelApp
{
    public partial class Form1 : Form
    {
        dataBase db = new dataBase();
        List<char> listIDS = new List<char>();
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            asignarTablaCuartos();
            asignarTablaClientes();
            llenarIDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoForm();
        }

        public void llenarIDS()
        {
            String query = "select id from cliente where id<>0";
            String data = db.query1Columna(query);
            foreach (char c in data)
            {
                listIDS.Add(c);
            }
        }

        public void nuevoForm()
        {
            
        }

        public void asignarTablaCuartos()
        {
            listCuartos.View = View.Details;
            String query2 = "select * from cuarto";
            String[] data = db.query4Columnas(query2).Split('\n');
            for (int i=0;i<data.Length;i++) {
                String[] aux = data[i].Split('_');
                if (aux.Length == 1) return;
                ListViewItem item = new ListViewItem(new[] { aux[0], aux[1], aux[2], aux[3] });
                listCuartos.Items.Add(item);

            }
        }

        public void asignarTablaClientes()
        {
            listClientes.View = View.Details;
            String query2 = "select id,nombre from cliente";
            String[] data = db.query2Columnas(query2).Split('\n');
            for (int i = 1; i < data.Length; i++)
            {
                String[] aux = data[i].Split('_');
                String[] aux2 = aux[0].Split(' ');
                if (aux2.Length == 1) return;
                ListViewItem item = new ListViewItem(new[] { aux2[0], aux2[1]});
                listClientes.Items.Add(item);

            }
        }

        private void listCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Boolean validarCliente(String id)
        {
            try
            {
                int aux = Convert.ToInt16(id);
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(listCuartos.SelectedItems[0].SubItems[0].Text);
            String estado = listCuartos.SelectedItems[0].SubItems[2].Text.Replace(" ","");
            String idcl;
            //while()
            if (estado.Equals("libre"))
            {
                String query = "update Cuarto set desc_estado='ocupado' where numero="+numero;
                db.querySinRespuesta(query);
                MessageBox.Show("Cuarto tomado exitosamente!","Info");
                listCuartos.Items.Clear();
                asignarTablaCuartos();
            }
            else
            {
                MessageBox.Show("El cuarto no se encuentra Libre!","Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre;
            while (!validarNombreCliente(nombre=Interaction.InputBox("Ingrese el nombre del cliente")))
            {
                MessageBox.Show("Nombre ingresado invalido!");
            }
            String query = "insert into cliente(nombre,operacion) values('"+nombre+"','vacio')";
            db.querySinRespuesta(query);
            MessageBox.Show("Usuario Añadido exitosamente!");
            listClientes.Items.Clear();
            asignarTablaClientes();
        }

        public Boolean validarNombreCliente(String nombre)
        {
            if(nombre.Equals("") || nombre.Equals(" ") || nombre == null)
            {
                return false;
            }
            try
            {
                Convert.ToDouble(nombre[0]);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Entro");
            }
            
            return true;
        }
    }
}
