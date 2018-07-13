using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using LogicaNegocio;

namespace WCFUsuario{
    
    public class Usuario : IUsuario{

        public void actualizarUsuario(Entidades.Usuario usuario){
            LogicaNegocio.LNUsuario objeto = new LogicaNegocio.LNUsuario();
            objeto.actualizarUsuario(usuario);
        }

        public List<Entidades.Usuario> buscarUsuario(int Id_Usuario){
            LogicaNegocio.LNUsuario objeto = new LogicaNegocio.LNUsuario();
            return objeto.buscarUsuario(Id_Usuario);
        }

        public void eliminarUsuario(int Id_Usuario){
            LogicaNegocio.LNUsuario objeto = new LogicaNegocio.LNUsuario();
            objeto.eliminarUsuario(Id_Usuario);
        }

        public void insertarUsuario(Entidades.Usuario usuario){
            LogicaNegocio.LNUsuario objeto = new LogicaNegocio.LNUsuario();
            objeto.insertarUsuario(usuario);
        }

        public List<Entidades.Usuario> listarUsuario(){
            LogicaNegocio.LNUsuario objeto = new LogicaNegocio.LNUsuario();
            return objeto.listarUsuario();
        }

    }
}
