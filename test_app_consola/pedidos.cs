using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test_app_consola
{
    public class Pedidos
    {
        /*Declarar variables*/
        public int ID;
        public int precioTotal;
        public string nombrePedido;

        public Boolean estadoDelPedido;
        public string nombreCliente;
        public string fecha;
        //falta agregar cantidad


        public Pedidos()
        {
        }

        public void setID(int id) { this.ID = id; }

        public void setPrecioPedido(int precio) { this.precioTotal = precio; }

        public void setNombrePedido(String n_pedido) { this.nombrePedido = n_pedido; }

        public void setEstado(Boolean estadoPedido ) { this.estadoDelPedido = estadoPedido; }

        public void setNombreCliente(string nombreCliente) { this.nombreCliente = nombreCliente; }

        public void setDate(string fecha) { this.fecha = fecha; }

        public List<Pedidos> listarPedidos()
        {
            List<Pedidos> ListarPedidos = new List<Pedidos>();

            Pedidos cliente_01 = new Pedidos();
            Pedidos cliente_02 = new Pedidos();
            Pedidos cliente_03 = new Pedidos();
            Pedidos cliente_04 = new Pedidos();
            Pedidos cliente_05 = new Pedidos();
            Pedidos cliente_06 = new Pedidos();
            Pedidos cliente_07 = new Pedidos();

            cliente_01.setID(1);
            cliente_01.setPrecioPedido(29990);
            cliente_01.setNombrePedido("Alimento perro Royal Canin Mini Adulto");
            cliente_01.setEstado(false);
            cliente_01.setNombreCliente("Carla Calvo");
            cliente_01.setDate("25/06/2020");

            cliente_02.setID(2);
            cliente_02.setPrecioPedido(29990);
            cliente_02.setNombrePedido("Alimento perro Royal Canin Mini Adulto");
            cliente_02.setEstado(false);
            cliente_02.setNombreCliente("Adrian Pellegrini");
            cliente_02.setDate("25/06/2020");

            cliente_03.setID(3);
            cliente_03.setPrecioPedido(9000);
            cliente_03.setNombrePedido("Snack para perros Royal LITTLE JACS");
            cliente_03.setEstado(false);
            cliente_03.setNombreCliente("Maria Lumita");
            cliente_03.setDate("22/06/2020");

            cliente_04.setID(4);
            cliente_04.setPrecioPedido(29990);
            cliente_04.setNombrePedido("Alimento perro Royal Canin Mini Adulto");
            cliente_04.setEstado(true);
            cliente_04.setNombreCliente("Lucia Fuentes");
            cliente_04.setDate("22/06/2020");

            cliente_05.setID(5);
            cliente_05.setPrecioPedido(55800);
            cliente_05.setNombrePedido("TASTE OF THE WILD PACIFIC STREAM PUPPY FORMULA");
            cliente_05.setEstado(true);
            cliente_05.setNombreCliente("Maria Torres");
            cliente_05.setDate("20/06/2020");

            cliente_06.setID(6);
            cliente_06.setPrecioPedido(4860);
            cliente_06.setNombrePedido("PRO PLAN ADULT POLLO & ARROZ LATA");
            cliente_06.setEstado(true);
            cliente_06.setNombreCliente("Laura Miraflores");
            cliente_06.setDate("20/06/2020");

            cliente_07.setID(7);
            cliente_07.setPrecioPedido(29990);
            cliente_07.setNombrePedido("Alimento perro Royal Canin Mini Adulto");
            cliente_07.setEstado(true);
            cliente_07.setNombreCliente("Carla Calvo");
            cliente_07.setDate("20/05/2020");


            ListarPedidos.Add(cliente_01);
            ListarPedidos.Add(cliente_02);
            ListarPedidos.Add(cliente_03);
            ListarPedidos.Add(cliente_04);
            ListarPedidos.Add(cliente_05);
            ListarPedidos.Add(cliente_06);
            ListarPedidos.Add(cliente_07);

            return ListarPedidos;
        }
    }
}
