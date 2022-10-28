using System.Collections.Generic;
namespace RoleplayGame
{
    public class Mago: PersonajeMagico
    {

        public Mago(string nombre)
        {
            this.Nombre = nombre;
            
            this.AddItem(new BastonMagico());
        }
        

    }
}
