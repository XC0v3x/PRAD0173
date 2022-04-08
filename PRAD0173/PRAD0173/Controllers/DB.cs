using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRAD0173.Models;

namespace PRAD0173.Controllers
{
    public static class DB
    {
        public static SQLiteAsyncConnection dbconexion;
        // Procedimiento Estatico
        public static void conexion(String dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);

            // Procedemos a crear las tablas de la base de datos
            dbconexion.CreateTableAsync<PagosModel>();
        }
    }
}
