using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BLL.Interfaces;
using Ventas.DAL;
using Ventas.Entities;

namespace Ventas.BLL
{
    public class RolesBLL : IRoles
    {
        VentasContextoBD db = new VentasContextoBD();

        public List<Roles> ListarRoles()
        {
            return db.roles.ToList();
        }

        public void Actualizar(Roles roles)
        {
            db.Entry(roles).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Roles roles)
        {
            db.roles.Add(roles);
            db.SaveChanges();
        }



        public Roles Buscar(int Id)
        {
            var Bus = db.roles.Find(Id);
            return Bus;
        }

        public List<Roles> FiltroNombre(string nombre)
        {
            var query = from x in db.roles
                        where x.Nombre.Contains(nombre)
                        select x;
            return query.ToList();
        }
    }
}

    


    