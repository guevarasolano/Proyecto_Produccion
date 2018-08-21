using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNBrix{

        public void insertarBrix(Entidades.Brix brix){

            ADBrix objeto = new ADBrix();
            objeto.insertarBrix(brix);
        }

        public void actualizarBrix(Entidades.Brix brix){

            ADBrix objeto = new ADBrix();
            objeto.actualizarBrix(brix);
        }

        public void eliminarBrix(int Id_Brix){

            ADBrix objeto = new ADBrix();
            objeto.eliminarBrix(Id_Brix);
        }

        public List<Entidades.Brix> buscarBrix(int Id_Brix){

            ADBrix objeto = new ADBrix();
            return objeto.buscarBrix(Id_Brix);
        }

        public List<Entidades.Brix> listarBrix(){

            ADBrix objeto = new ADBrix();
            return objeto.listarBrix();
        }

    }
}
