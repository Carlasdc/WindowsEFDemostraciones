using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmStore : Form
    {
        PubsContext context = new PubsContext();
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            List<Store> lista = DacStore.Lista();

            dataGridTraer.DataSource = lista;
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            Store storeTU = DacStore.TraerUno(id);
            List<Store> store = new List<Store>();
            store.Add(storeTU);
            if (storeTU == null)
            {
                MessageBox.Show("No se encontro el autor");
            }
            
            dataGridTraer.DataSource = store;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { stor_id = "8044", city= "New York", state="US", stor_name="Starbucks", stor_address="5 street", zip="95870" };

            int filasAfectadas = DacStore.Nuevo(store);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Nuevo Store Insertado");
            }
            else
            {
                MessageBox.Show(" El Store no existe o no fue insertado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //buscar shipper
            string id = txtId.Text;
            Store store = context.Stores.Find(id);

            //Modificación del objeto
            if (store != null)
            {

                store.stor_id = "8045";
                store.stor_name = "Cafe Marinez";
                store.stor_address = "5 street 50";
                

            }
            //Guadar en la DB
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Store modificado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            //Buscar el objeto en la DB

            var store1 = context.Stores.Find(id);

            if (store1 != null)
            {
                // remover
                context.Stores.Remove(store1);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Store eliminado");
                }

            }
            else
            {
                MessageBox.Show("No se encuentra el store para eliminar");
            }
        }
    }
}
