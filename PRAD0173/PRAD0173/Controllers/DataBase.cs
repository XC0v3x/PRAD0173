using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRAD0173.Models;
using PRAD0173.Controllers;
using System.Threading.Tasks;

namespace PRAD0173.Controllers
{
    public static class DataBase
    {
        // Procedimientos

        // Retorna todas las filas de la tabla Pagos
        public static Task<List<PagosModel>> ObtenerListaPagos()
        {
            return DB.dbconexion.Table<PagosModel>().ToListAsync();
        }

        // INSERT, SELECT, UPDATE, DELETE 

        // CREATE - UPDATE
        public static Task<int> AddPago(PagosModel Pago)
        {
            if (Pago.ID != 0)
            {
                // Ejecutamos el procedimiento de Actualizacion UPDATE
                return DB.dbconexion.UpdateAsync(Pago);
            }
            else
            {
                // Ejectuamos el procedimiento de INSERCCION de UNA PERSONA
                return DB.dbconexion.InsertAsync(Pago);
            }
        }

        // Obtenemos por el ID un registro de una persona
        public static Task<PagosModel> ObtenerPago(int pid)
        {
            return DB.dbconexion.Table<PagosModel>()
                .Where(i => i.ID == pid)
                .FirstOrDefaultAsync();
        }

        // Eliminamos el registro de una persona
        public static Task<int> DelPago(PagosModel Pago)
        {
            return DB.dbconexion.DeleteAsync(Pago);
        }
    }
}
