using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFUsuario{
    
    [ServiceContract]
    public interface IUsuario{

        [OperationContract]
        void insertarUsuario(Entidades.Usuario usuario);

        [OperationContract]
        void actualizarUsuario(Entidades.Usuario usuario);

        [OperationContract]
        void eliminarUsuario(int Id_Usuario);

        [OperationContract]
        List<Entidades.Usuario> buscarUsuario(int Id_Usuario);

        [OperationContract]
        List<Entidades.Usuario> listarUsuario();

    }
}
