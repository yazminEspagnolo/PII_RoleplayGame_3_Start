using System.Collections.Generic;
namespace RoleplayGame
{ 
    public abstract class Personaje
    {   
        private int vida = 100;

        public List<IItem> items = new List<IItem>();
        public string Nombre { get; set; }  
        public int Ataque
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IItemAtaque)
                    {
                        value += (item as IItemAtaque).Ataque;
                    }
                }
                return value;
            }
        }

        public int Defensa
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IItemDefensa)
                    {
                        value += (item as IItemDefensa).Defensa;
                    }
                }
                return value;
            }
        }
        public int Vida
        {
            get
            {
                return this.vida;
            }
            private set
            {
                this.vida = value < 0 ? 0 : value;
            }
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void Curar()
        {
        this.Vida = 100;
        }

        public void OfensaDeAtaque(int power)
        {
            if (this.Defensa < power)
            {
                this.Vida -= power - this.Defensa;
            }
        }
    }
}

    

