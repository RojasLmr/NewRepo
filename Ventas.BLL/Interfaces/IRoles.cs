using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.BLL.Interfaces
{
    internal interface IRoles
    {
       
            void Agregar(Roles roles);
            void Actualizar(Roles roles);
            List<Roles> ListarRoles();
            Roles Buscar(int Id);
            List<Roles> FiltroNombre(string nombre);
        }
    }


