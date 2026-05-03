namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Teclado", 19.99m));*/

            /*var p = new Problema2();
            Console.WriteLine(p.CrearResumenVenta(100, "Mouse", 2, 1500));*/

            /*var prod = new Product("Mouse");
            var p3 = new Problema3();

            Console.WriteLine(p3.CompararCopias(10, prod));*/

            var p5 = new Problema5();

            Sale s1 = new RetailSale(1000);
            Sale s2 = new WholesaleSale(1000);

            Console.WriteLine(p5.ObtenerImporteFinal(s1));
            Console.WriteLine(p5.ObtenerImporteFinal(s2)); 

        }
    }
}
