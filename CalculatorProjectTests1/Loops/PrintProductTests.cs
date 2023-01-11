using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops.Tests
{
    
    [TestClass()]
    public class PrintProductTests
    {
       

        [TestMethod()]
        public void GetProductsGreatterthan30WithForTest()
        {
            if (PrintProduct.listaProductos.Count == 0)
                PrintProduct.CreateListProduct();
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithFor()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithFor()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreatterthan30WithForEachTest()
        {
            if (PrintProduct.listaProductos.Count == 0)
                PrintProduct.CreateListProduct();
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithForEach().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithForEach()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithForEach()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreatterthan30WithWhileTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithWhile().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithWhile()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithWhile()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreatterthan30WithLinqTest()
        { 
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithLinq().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithLinq()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreatterthan30WithLinq()[1].Name == "Juego");
        }
    }
}