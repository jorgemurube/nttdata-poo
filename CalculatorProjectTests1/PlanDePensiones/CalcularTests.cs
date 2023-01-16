using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PlanDePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones.Tests
{
    [TestClass()]
    public class CalcularTests
    {
        [DataRow(12449f, 1500f, 8500f, 8100f)]
        [DataRow(20000f, 700f, 1000f, 1292f)]
        [DataRow(25000f, 1500f, 8500f, 7000f)]
        [DataRow(50000f, 1500f, 8500f, 6300f)]
        [DataRow(70000f, 1500f, 8500f, 5500f)]
        [DataTestMethod()]
        public void calcularDesgravacionTest(float num1, float num2, float num3, float result)
        {
            var model = new Model(num1, num2, num3);

            Assert.IsTrue(Calcular.calcularDesgravacion(model)==result);
        }
    }
}