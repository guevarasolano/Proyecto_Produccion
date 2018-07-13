using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNRol{

        public void insertarRol(Entidades.Rol rol){

            ADRol objeto = new ADRol();
            objeto.insertarRol(rol);
        }

        public void actualizarRol(Entidades.Rol rol){

            ADRol objeto = new ADRol();
            objeto.actualizarRol(rol);
        }

        public void eliminarRol(int Id_Rol){

            ADRol objeto = new ADRol();
            objeto.eliminarRol(Id_Rol);
        }

        public List<Entidades.Rol> buscarRol(int Id_Rol){

            ADRol objeto = new ADRol();
            return objeto.buscarRol(Id_Rol);
        }

        public List<Entidades.Rol> listarRol(){

            ADRol objeto = new ADRol();
            return objeto.listarRol();
        }

    }
}
