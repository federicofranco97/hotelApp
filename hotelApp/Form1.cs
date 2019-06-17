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
            llenarIDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query2 = "select * from cuarto";
            String []data=db.query4Columnas(query2).Split('\n');
            MessageBox.Show(data[0]);
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
    }
}
