using System.Collections.Generic;

namespace RoleplayGame
{
    public class LibroDeHechizos : IDefensaItemMagico, IAtaqueItemMagico
    {
        private List<IHechizo> hechizos = new List<IHechizo>();
        
        public int Ataque
        {
            get
            {
                int value = 0;
                foreach (IHechizo hechizo in this.hechizos)
                {
                    value += hechizo.Ataque;
                }
                return value;
            }
        }

        public int Defensa
        {
            get
            {
                int value = 0;
                foreach (IHechizo hechizo in this.hechizos)
                {
                    value += hechizo.Defensa;
                }
                return value;
            }
        }

         public void AddHechizo(IHechizo hechizo)
        {
            this.hechizos.Add(hechizo);
        }

        public void RemoveSpell(IHechizo hechizo)
        {
            this.hechizos.Remove(hechizo);
        }
    }
}