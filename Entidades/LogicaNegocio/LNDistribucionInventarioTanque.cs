using Entidades;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNDistribucionInventarioTanque{

        public void insertarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            objeto.insertarDistribucionInventarioTanque(distribucion_Inventario_Tanque);
        }

        public void actualizarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            objeto.actualizarDistribucionInventarioTanque(distribucion_Inventario_Tanque);
        }

        public void eliminarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            objeto.eliminarDistribucionInventarioTanque(Id_Distribucion_Inventario_Tanque);
        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            return objeto.buscarDistribucionInventarioTanque(Id_Distribucion_Inventario_Tanque);

        }

        public List<Distribucion_Inventario_Tanque> listarDistribucionInventarioTanque(){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            return objeto.listarDistribucionInventarioTanque();

        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionPorTanque(int Numero_Tanque){

            ADDistribucionInventarioTanque objeto = new ADDistribucionInventarioTanque();
            return objeto.buscarDistribucionPorTanque(Numero_Tanque);

        }

    }
}
