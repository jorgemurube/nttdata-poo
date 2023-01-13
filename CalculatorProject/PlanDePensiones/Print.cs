using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class Print
    {
        public static void PedirDatos()
        {
            Model model = new Model();
            Console.WriteLine("Introduce tu base imponible:");
            model.BaseImponible = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu aportacion de persona física:");
            model.AportacionPersonaFisicaPlanPensiones = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu aportacion de empresa:");
            model.AportacionEmpresaPlanPensiones = float.Parse(Console.ReadLine());

            Calcular.calcularDesgravacion(model);

        }

        
    }
}
