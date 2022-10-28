using System.Collections.Generic;
namespace RoleplayGame
{
    public class Elfo: Heroe
    {
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            
            this.AddItem(new BastonMagico());
            this.AddItem(new Capa());
            this.AddItem(new Arco());
        }
    

    }
}
