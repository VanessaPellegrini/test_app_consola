using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_app_consola
{
    public class Stock

    {
        public int ID;
        public int s_precio;
        public int s_cantidad;

        public String s_n_producto;

        public String s_descripcion;

        //public DateTime fecha_ingreso;

        public Stock()
        {}

        //setter

        public void setID(int id) { this.ID = id; }

        public void setPrecioStock(int precio) { this.s_precio = precio; }

        public void setCantidadStock (int cantidad) { this.s_cantidad = cantidad; }

        public void setNombreProducto(String n_producto) { this.s_n_producto = n_producto; }

        public void setDescripcionStock(String descripcion) { this.s_descripcion = descripcion; }



        public List<Stock> listarStock()
        {
            List<Stock> ListaStock = new List<Stock>();

            //instanciar objeto

            Stock alimento_perro = new Stock();
            Stock premio_perro = new Stock();
            Stock alimento_medicado_perro = new Stock();
            Stock alimento_humedo_perro = new Stock();
            Stock alimento_cachorro_perro = new Stock();

            /*Stock alimento_gato = new Stock();
            Stock premio_gato = new Stock();
            Stock alimento_medicado_gato = new Stock();
            Stock alimento_humedo_gato = new Stock();
            Stock alimento_gatito_gato = new Stock();*/


            alimento_perro.setID(1);
            alimento_perro.setPrecioStock(29990);
            alimento_perro.setCantidadStock(30);
            alimento_perro.setNombreProducto("Royal Canin Mini Adulto");
            alimento_perro.setDescripcionStock("Presentación 7kg");

            premio_perro.setID(2);
            premio_perro.setPrecioStock(3000);
            premio_perro.setCantidadStock(45);
            premio_perro.setNombreProducto("LITTLE JACS");
            premio_perro.setDescripcionStock("Little Jacs son unos deliciosos premios y snacks para perros pequeños");


            alimento_medicado_perro.setID(3);
            alimento_medicado_perro.setPrecioStock(40000);
            alimento_medicado_perro.setCantidadStock(30);
            alimento_medicado_perro.setNombreProducto("Pro Plan HA HYPOALLERGENIC CANINE");
            alimento_medicado_perro.setDescripcionStock("Pro Plan Veterinary Diets HA Hipoallergenic está indicado para perros con hipersensibilidad alimentaria");


            alimento_humedo_perro.setID(4);
            alimento_humedo_perro.setPrecioStock(2430);
            alimento_humedo_perro.setCantidadStock(30);
            alimento_humedo_perro.setNombreProducto("PRO PLAN ADULT POLLO & ARROZ LATA");
            alimento_humedo_perro.setDescripcionStock("PRO PLAN® Adult Pollo & Arroz es un alimento húmedo en lata para perros adultos. Formulado con pollo como primer ingrediente. ");

            alimento_cachorro_perro.setID(5);
            alimento_cachorro_perro.setPrecioStock(55800);
            alimento_cachorro_perro.setCantidadStock(30);
            alimento_cachorro_perro.setNombreProducto("TASTE OF THE WILD PACIFIC STREAM PUPPY FORMULA");
            alimento_cachorro_perro.setDescripcionStock("Taste of the Wild Pacific Stream Puppy es una comida para cachorros libre de grano que proporciona energía digestiva y una nutrición excelente para su cachorro en crecimiento. ");


            ListaStock.Add(alimento_perro);
            ListaStock.Add(premio_perro);
            ListaStock.Add(alimento_medicado_perro);
            ListaStock.Add(alimento_humedo_perro);
            ListaStock.Add(alimento_cachorro_perro);

            return ListaStock;

        }
    }

}
