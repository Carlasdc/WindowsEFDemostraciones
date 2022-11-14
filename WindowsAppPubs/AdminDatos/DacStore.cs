using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        public static PubsContext context = new PubsContext();
        public static List<Store> Lista()
        {
            List<Store> listaStore = new List<Store>();
            listaStore = context.Stores.ToList();
            return listaStore;
        }
        public static Store TraerUno(string id)
        {
            Store store = new Store();
            store = context.Stores.Find(id);
            return store;
        }
        public static int Nuevo(Store store)
        {
            context.Stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static int Modificar(Store store)
        {
            string id = store.stor_id;
            Store storeFind = context.Stores.Find(id);

            if (storeFind != null)
            {

                storeFind = store;

            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static int Eliminar(Store store)
        {
            string id = store.stor_id;
            Store storeFind = context.Stores.Find(id);

            if (storeFind != null)
            {

                context.Stores.Remove(storeFind);


            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
    }
}
