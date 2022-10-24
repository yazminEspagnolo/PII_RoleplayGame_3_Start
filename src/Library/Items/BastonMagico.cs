namespace RoleplayGame
{
    public class BastonMagico : IItemAtaque, IItemDefensa
    {
        public int Ataque 
        {
            get
            {
                return 100;
            } 
        }

        public int Defensa
        {
            get
            {
                return 100;
            }
        }
    }
}