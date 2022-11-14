using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using WindowsAppPubs.Models;


namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        public static PubsContext context = new PubsContext();

        public static List<Author> Lista()
        {
            List<Author> listaAuthors= new List<Author>();
            listaAuthors = context.Authors.ToList();
            return listaAuthors;
        }
        public static Author TraerUno(string id)
        {
            Author authorTU = new Author();
            authorTU = context.Authors.Find(id);
            return authorTU;
        }
        public static int Nuevo(Author author)
        {
            context.Authors.Add(author);
            int filasafectadas = context.SaveChanges();

            return filasafectadas;

        }
        public static int Modificar(Author author)
        {
            int id = Convert.ToInt32(author.au_id);
            Author authorDel = context.Authors.Find(id);
            if (authorDel != null)
            {
                authorDel=author;
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
            
        }
        public static int Eliminar(Author author)
        {
            int id = Convert.ToInt32(author.au_id);
            Author authorDel = context.Authors.Find(id);
            if (authorDel != null)
            {
                context.Authors.Remove(authorDel);
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
    }
}
