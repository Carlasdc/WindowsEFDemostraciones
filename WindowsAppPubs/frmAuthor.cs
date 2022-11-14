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
    public partial class frmAuthor : Form
    {
        PubsContext context = new PubsContext();
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            List<Author> lista = DacAuthor.Lista();

            dataGridTraer.DataSource = lista;
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
           
            string id = txtId.Text;

            Author author = DacAuthor.TraerUno(id);
            List<Author> author1 = new List<Author>();
            author1.Add(author);
            if (author == null)
            {
                MessageBox.Show("No se encontro el autor");
            }
            else {
                MessageBox.Show($"El autor es {author.au_fname}");
            }
            GridViewTraerUno.DataSource = author1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Author author1 = new Author() { au_id = "111-21-2245", au_lname = "Borges", au_fname = "Jorge Luis", phone = "442358", address="Ramos Mejia", city="Buenos Aires", state = "AR", zip="12345", contract=false};

            int filasAfectadas = DacAuthor.Nuevo(author1);

            if (filasAfectadas > 0) 
            { 
                MessageBox.Show("Nuevo Autor Insertado"); 
            }
            else
            {
                MessageBox.Show(" Autor no existe o no fue insertado");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //buscar shipper
            string id = txtId.Text;
            Author author = context.Authors.Find(id);

            //Modificación del objeto
            if (author != null)
            {
               
                author.au_lname = "Alfonsina";
                author.au_fname = "Storni";
                author.phone = "458975";
                author.address = "Constitucion 23";
                author.city = "Mar del Plata";
                author.state = "AR";
                author.zip = "23487";
                author.contract = true;

            }
            //Guadar en la DB
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Autor modificado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            //Buscar el objeto en la DB

            var authordel = context.Authors.Find(id);

            if (authordel != null)
            {
                // remover
                context.Authors.Remove(authordel);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Autor eliminado");
                }

            }
            else
            {
                MessageBox.Show("No se encuentra autor para eliminar");
            }
        }
    }
}
