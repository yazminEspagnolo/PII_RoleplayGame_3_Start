
namespace RoleplayGame
{
    public abstract class Enemigo: Personaje
    {
        private int vp=0; 
        public int VP
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp=value;
            }
        }
    }
}
