
namespace RoleplayGame
{
    public class Esqueleto: Enemigo
    {
        public Esqueleto(string nombre)
        {
            this.Nombre = nombre;
            this.VP = 10; 
            this.AddItem(new Arco());

        }

    }
}