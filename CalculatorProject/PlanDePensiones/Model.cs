using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.PlanDePensiones
{
    public class Model
    {
        public float BaseImponible { get; set; }
        public float AportacionPersonaFisicaPlanPensiones { get; set;}
        public float AportacionEmpresaPlanPensiones { get; set;}

        public Model()
        {
        }

        public Model(float BaseImponible, float AportacionPersonaFisicaPlanPensiones, float AportacionEmpresaPlanPensiones)
        {
            this.BaseImponible = BaseImponible;
            this.AportacionPersonaFisicaPlanPensiones = AportacionPersonaFisicaPlanPensiones;
            this.AportacionEmpresaPlanPensiones = AportacionEmpresaPlanPensiones;
        }

        public override string ToString()
        {
            return "Modelo:" + this.BaseImponible + ","
                + this.AportacionPersonaFisicaPlanPensiones + "," + this.AportacionEmpresaPlanPensiones;
        }
    }
    
}
