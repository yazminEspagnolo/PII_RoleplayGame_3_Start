using System.Collections.Generic;
namespace RoleplayGame
{
    public class Enano: Heroe
    {
        public Enano(string nombre)
        {
            this.Nombre = nombre;

            this.AddItem(new Hacha());
            this.AddItem(new Escudo());
            this.AddItem(new Casco());
        }

    }
}
