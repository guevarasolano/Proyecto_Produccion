using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNUsuario{

        public void insertarUsuario(Entidades.Usuario usuario){

            ADUsuario objeto = new ADUsuario();
            objeto.insertarUsuario(usuario);
        }

        public void actualizarUsuario(Entidades.Usuario usuario){

            ADUsuario objeto = new ADUsuario();
            objeto.actualizarUsuario(usuario);
        }

        public void eliminarUsuario(int Id_Usuario){

            ADUsuario objeto = new ADUsuario();
            objeto.eliminarUsuario(Id_Usuario);
        }

        public List<Entidades.Usuario> buscarUsuario(int Id_Usuario){

            ADUsuario objeto = new ADUsuario();
            return objeto.buscarUsuario(Id_Usuario);
        }

        public List<Entidades.Usuario> listarUsuario(){

            ADUsuario objeto = new ADUsuario();
            return objeto.listarUsuario();
        }

    }
}
