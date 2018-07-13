using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using LogicaNegocio;

namespace WCFDistribucionInventarioTanque {

    public class DistribucionInventarioTanque : IDistribucionInventarioTanque{

        public void actualizarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            objeto.actualizarDistribucionInventarioTanque(distribucion_Inventario_Tanque);
        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            return objeto.buscarDistribucionInventarioTanque(Id_Distribucion_Inventario_Tanque);
        }

        public void eliminarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            objeto.eliminarDistribucionInventarioTanque(Id_Distribucion_Inventario_Tanque);
        }

        public void insertarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            objeto.insertarDistribucionInventarioTanque(distribucion_Inventario_Tanque);
        }

        public List<Distribucion_Inventario_Tanque> listarDistribucionInventarioTanque(){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            return objeto.listarDistribucionInventarioTanque();
        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionPorTanque(int Numero_Tanque){
            LNDistribucionInventarioTanque objeto = new LNDistribucionInventarioTanque();
            return objeto.buscarDistribucionPorTanque(Numero_Tanque);
        }

    }
}
