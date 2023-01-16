using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class Calcular
    {
        

        public static float calcularDesgravacion(Model model)
        {
            var desgravacion=0.00f;
            if (model.BaseImponible>=0 && model.BaseImponible <= 12449)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.81f;
  
            }
            else if(model.BaseImponible >= 12500 && model.BaseImponible <= 20199)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.76f;
            }
            else if (model.BaseImponible >= 20200 && model.BaseImponible <= 35199)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.70f;
            }
            else if (model.BaseImponible >= 35200 && model.BaseImponible <= 59999)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.63f;
            }
            else if (model.BaseImponible >= 60000 && model.BaseImponible <= 299999)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.55f;
            }
            else if (model.BaseImponible >= 300000)
            {
                desgravacion = (model.AportacionPersonaFisicaPlanPensiones + model.AportacionEmpresaPlanPensiones) * 0.53f;
            }
            else if(model.BaseImponible<0)
            {
                Console.WriteLine("Numero no válido");
            }
            Console.WriteLine("Te has desgravado: " + desgravacion);
            return desgravacion;
        }
    }
}
