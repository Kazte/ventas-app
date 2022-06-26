using System.Collections.Generic;

namespace tienda_mayorista_app
{
    public class Tienda
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public List<Prenda> Prendas { get; private set; }

        public Tienda(int id, string nombre, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}