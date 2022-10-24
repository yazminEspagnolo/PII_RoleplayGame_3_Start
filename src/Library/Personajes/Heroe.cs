
namespace RoleplayGame
{
    public abstract class Heroe: Personaje
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

        public void SubirVP(int Vp_enemigo)
        {   
            if(Vp_enemigo>5)
            {
                this.Curar();
            }
            this.VP=VP+Vp_enemigo;
        }
        

    }

}