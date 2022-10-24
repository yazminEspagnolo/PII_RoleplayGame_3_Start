
namespace RoleplayGame
{
    public class TortugaNinja: Enemigo
    {
        public TortugaNinja(string nombre)
        {
            this.Nombre = nombre;
            this.VP = 10; 
            this.AddItem(new Frisbee());

        }

    }
}