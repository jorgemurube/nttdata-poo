using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {

        public static List<Product> listaProductos = new List<Product>();    
        public static void CreateListProduct()
        {   
            if(listaProductos.Count == 0)
            {
                var potatoes = new Product
                {
                    Id = 1,
                    Name = "Patatas",
                    Price = 24.56f
                };
                listaProductos.Add(potatoes);

                var oil = new Product
                {
                    Id = 2,
                    Name = "Aceite",
                    Price = 35.27f
                };
                listaProductos.Add(oil);

                var game = new Product
                {
                    Id = 2,
                    Name = "Juego",
                    Price = 39.99f
                };
                listaProductos.Add(game);
            }
                
            
            
        }

        
        public static List<Product> GetProductsGreatterthan30WithFor()
        {
            var ListaProductosFiltrados = new List<Product>();
            for (int i=0;i< listaProductos.Count;i++)
            {
                if (listaProductos[i].Price > 30.00f)
                {

                    ListaProductosFiltrados.Add(listaProductos[i]);
                }
            }
            System.Console.WriteLine(ListaProductosFiltrados);
            return ListaProductosFiltrados;
        }

        public static List<Product> GetProductsGreatterthan30WithForEach()
        {
            var ListaProductosFiltrados = new List<Product>();
            foreach (Product products in listaProductos)
            {
                if (products.Price > 30.00f)
                {
                    ListaProductosFiltrados.Add(products);
                }
            }
            return ListaProductosFiltrados;
        }

        public static List<Product> GetProductsGreatterthan30WithWhile()
        {
            var ListaProductosFiltrados = new List<Product>();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                while (listaProductos[i].Price > 30)
                {

                    ListaProductosFiltrados.Add(listaProductos[i]);
                }
            }
            return ListaProductosFiltrados;
        }

        public static List<Product> GetProductsGreatterthan30WithLinq()
        {
             IEnumerable<Product> ListaProductosFiltradosLinq =
                                                from product in listaProductos
                                                where product.Price > 30.00f
                                                select product;  
             return ListaProductosFiltradosLinq.ToList();

            /*var listaFiltrada = listaProductos.Where(productsGreatterthan30 => productsGreatterthan30.Price > 30)
                                               .Select(productsGreatterthan30 => productsGreatterthan30.Name);
            return (List<Product>)listaFiltrada;*/
        }


    }
}
