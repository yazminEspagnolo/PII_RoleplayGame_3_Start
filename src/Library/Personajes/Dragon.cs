
namespace RoleplayGame
{
    public class Dragon: Enemigo
    {
        public Dragon(string nombre)
        {
            this.Nombre = nombre;
            this.VP = 10; 
            this.AddItem(new BolaDeFuego());

        }

    }
}