using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_app_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stock> ListaStock = new List<Stock>();
            Stock alimento = new Stock();
            ListaStock = alimento.listarStock();
            List<Pedidos> ListaPedidos = new List<Pedidos>();
            Pedidos _pedido = new Pedidos();
            ListaPedidos = _pedido.listarPedidos();
            menu(ListaStock, ListaPedidos);

        }

        static void menu(List<Stock> ListaStock, List<Pedidos> ListaPedidos)
        {
            for (; ; )
            {
                Console.Clear();
                Console.Write("*******Bienvenido a En Tu Barrio App ********\n\n\n");
                Console.Write("*******Tienda de venta de alimentos: AlimenPet ********\n\n\n");
                Console.Write("1... Revisa tu stock\n");
                Console.Write("2... Ingresa un nuevo stock\n");
                Console.Write("3... Modifica tu stock\n");
                Console.Write("4... Elimina el stock antiguo\n\n");
                Console.Write("5... Revisa tu lista de pedidos\n\n");
                Console.Write("0... Salir \n\n");
                Console.Write("Ingresa una opcion : ");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.KeyChar)
                {
                    case '1':
                        ListarStock(ListaStock);
                        Console.WriteLine("\n Presione Enter para volver al menu ...");
                        Console.ReadKey();
                        break;
                    case '2':
                        AgregarStock(ListaStock);
                        break;
                    case '3':
                        ListarStock(ListaStock);
                        ModStock(ListaStock);
                        break;
                    case '4':
                        ListarStock(ListaStock);
                        EliminarStock(ListaStock);
                        break;
                    case '5':
                        ListarPedidos(ListaPedidos);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void ListarStock(List<Stock> ListaStock)
        {
            foreach (var alimento in ListaStock)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n CODIGO : {0}", alimento.ID);
                Console.WriteLine("\n PRECIO : {0}", alimento.s_precio);
                Console.WriteLine("\n CANTIDAD EN STOCK : {0}", alimento.s_cantidad);
                Console.WriteLine("\n NOMBRE DEL PRODUCTO : {0}", alimento.s_n_producto);
                Console.WriteLine("\n DESCRIPCION : {0}", alimento.s_descripcion);
                Console.WriteLine("\n ************** ------- **************");
            }

            //Console.WriteLine("\n Presione Enter para volver al menu ...");
            //Console.ReadKey();
        }

        public static void ListarPedidos(List<Pedidos> ListaPedidos)
        {
            foreach (var cliente in ListaPedidos)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n CODIGO : {0}", cliente.ID);
                Console.WriteLine("\n PRECIO TOTAL: {0}", cliente.precioTotal);
                Console.WriteLine("\n NOMBRE DEL PEDIDO : {0}", cliente.nombrePedido);
                Console.WriteLine("\n ESTADO DEL PEDIDO: {0}", cliente.estadoDelPedido);
                Console.WriteLine("\n NOMBRE DEL CLIENTE : {0}", cliente.nombreCliente);
                Console.WriteLine("\n FECHA DE COMPRA : {0}", cliente.fecha);
                Console.WriteLine("\n ************** ------- **************");
            }

            //Console.WriteLine("\n Presione Enter para volver al menu ...");
            //Console.ReadKey();
        }

        public static void AgregarStock(List<Stock> ListaStock)
        {
            Stock add_alimento = new Stock();
            string s_n_producto;
            string s_descripcion;
            int ID;
            int s_precio;
            int s_cantidad;


            try
            {

                Console.Clear();
                Console.Write("******* Revision de stock ********\n\n\n");
                Console.Write("\n Ingresa el ID : ");
                ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Ingresa el nombre del producto : ");
                s_n_producto = Console.ReadLine();
                Console.Write("\n Ingresa la descripcion : ");
                s_descripcion = Console.ReadLine();
                Console.Write("\n Ingresa la cantidad del stock disponible : ");
                s_cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Ingresa el precio : ");
                s_precio = Convert.ToInt32(Console.ReadLine());

                add_alimento.ID = ID;
                add_alimento.s_precio = s_precio;
                add_alimento.s_cantidad = s_cantidad;
                add_alimento.s_n_producto = s_n_producto;
                add_alimento.s_descripcion = s_descripcion;


                ListaStock.Add(add_alimento);

            }
            catch (Exception ex) //bloque catch para captura de error
            {
                Console.WriteLine("\n {0} Error en los datos ingresados :", ex);
            }

            //Console.WriteLine("El texto introducido es: {0},{1},{2} ",titulo, genero,duracion);
            Console.WriteLine("\n Presione Enter para confirmar ...");
            Console.ReadKey();
        }


        public static void EliminarStock(List<Stock> ListaStock)
        {
            int ID;
            bool flag = false;

            Stock _stock = new Stock();

            //Console.Clear();
            //Console.Write("******* AlimenPet ********\n\n\n");
            Console.Write("\n Ingresa el id del stock que quieres eliminar : ");
            ID = Convert.ToInt32(Console.ReadLine());


            foreach (Stock stock in ListaStock)
            {
                if (_stock.ID == ID)
                {
                    _stock = stock;
                    flag = true;
                }
            }

            if (flag)
            {
                ListaStock.Remove(_stock);
                Console.Write("\n Stock eliminado correctamente ");
            }

        }

        public static void ModStock(List<Stock> ListaStock)
        {
            string s_n_producto;
            string s_descripcion;
            int ID;
            int s_precio;
            int s_cantidad;

            bool flag = false;

            Stock _stock = new Stock();

            Console.Write("\n Ingresa el id del stock que quieres modificar : : ");
            ID = Convert.ToInt32(Console.ReadLine());


            foreach (Stock element in ListaStock)
            {
                if (element.ID == ID)
                {
                    Console.Clear();
                    Console.Write("******* AlimenPet ********\n\n\n");
                    Console.Write("\n Ingresa el ID : ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Ingresa el nombre del producto : ");
                    s_n_producto = Console.ReadLine();
                    Console.Write("\n Ingresa la descripcion : ");
                    s_descripcion = Console.ReadLine();
                    Console.Write("\n Ingresa la cantidad del stock disponible : ");
                    s_cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Ingresa el precio : ");
                    s_precio = Convert.ToInt32(Console.ReadLine());

                    element.ID = ID;
                    element.s_precio = s_precio;
                    element.s_cantidad = s_cantidad;
                    element.s_n_producto = s_n_producto;
                    element.s_descripcion = s_descripcion;


                    flag = true;

                }
            }

            if (flag)
            {
                Console.Write("\n Stock Actualizado Correctamente ");
            }

        }

    }
}
