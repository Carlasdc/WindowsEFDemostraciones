using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmPubs : Form
    {
        PubsContext context = new PubsContext();
        public frmPubs()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //creamos la instancia
            Publisher publisher = new Publisher() { pub_id= "2245", pub_name="MGMg", city="New York", country="USA", state="NY"};

            //DBset
            context.Publishers.Add(publisher);

            //Guardar en la tabla

            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ingresado");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //buscar shipper
            string id = txtId.Text;
            Publisher publisherDB = context.Publishers.Find(id);

            //Modificación del objeto
            if (publisherDB != null)
            {
                publisherDB.pub_name = "Four Lakes Publishing";
                publisherDB.city = "New York";

            }

            //Guadar en la DB
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificado");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            //Buscar el objeto en la DB

            var publisherDb = context.Publishers.Find(id);

            if (publisherDb != null)
            {
                // remover
                context.Publishers.Remove(publisherDb);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminado");
                }

            }


        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            List<Publisher> lista = context.Publishers.ToList();//conectar db, select..., cierra conexion

            dataGridPubs.DataSource = lista;

        }
    }
}
