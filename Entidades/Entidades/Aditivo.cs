using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Aditivo{

        public int Id_Aditivo { get; set; }
        public int FK_Id_Proceso_BP_BJC { get; set; }
        public Double Jugo_Limon { get; set; }
        public Double Ascorbico { get; set; }
        public Double Citrico { get; set; }
        public Double Liquiseb_RL_Concentrado { get; set; }
        public Double Liquiseb_APL { get; set; }
        public Double Sebamyl_GL400 { get; set; }
        public Double Sebamyl_BAL100 { get; set; }
        public Double Flora_Clair { get; set; }
        public Double Gelatina { get; set; }
        public Double Bevasyl { get; set; }
        public Double Bentonita { get; set; }
        public Double Carbon { get; set; }
        public Double Celite { get; set; }
        public Double HS_4000 { get; set; }
        public Double Shenck_DD { get; set; }
        public Double HS_1000 { get; set; }
        public Double HS_1600 { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Aditivo(int Id_Aditivo, int FK_Id_Proceso_BP_BJC, Double Jugo_Limon,
                               Double Ascorbico, Double Citrico, Double Liquiseb_RL_Concentrado,
                               Double Liquiseb_APL, Double Sebamyl_GL400, Double Sebamyl_BAL100,
                               Double Flora_Clair, Double Gelatina, Double Bevasyl,
                               Double Bentonita, Double Carbon,
                               Double Celite, Double HS_4000,
                               Double Shenck_DD, Double HS_1000, Double HS_1600, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Aditivo = Id_Aditivo;
            this.FK_Id_Proceso_BP_BJC = FK_Id_Proceso_BP_BJC;
            this.Jugo_Limon = Jugo_Limon;
            this.Ascorbico = Ascorbico;
            this.Citrico = Citrico;
            this.Liquiseb_RL_Concentrado = Liquiseb_RL_Concentrado;
            this.Liquiseb_APL = Liquiseb_APL;
            this.Sebamyl_GL400 = Sebamyl_GL400;
            this.Sebamyl_BAL100 = Sebamyl_BAL100;
            this.Flora_Clair = Flora_Clair;
            this.Gelatina = Gelatina;
            this.Bevasyl = Bevasyl;
            this.Bentonita = Bentonita;
            this.Carbon = Carbon;
            this.Celite = Celite;
            this.HS_4000 = HS_4000;
            this.Shenck_DD = Shenck_DD;
            this.HS_1000 = HS_1000;
            this.HS_1600 = HS_1600;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Aditivo() { }

    }
}
