using System.Collections.Generic;
namespace RoleplayGame
{
    public class Mago: PersonajeMagico
    {
        private int vida = 100;

        private List<IItem> items = new List<IItem>();

        private List<IItemMagico> ItemsMagicos = new List<IItemMagico>();

        public Mago(string nombre)
        {
            this.Nombre = nombre;
            
            this.AddItem(new BastonMagico());
        }

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
                foreach (IItemMagico item in this.ItemsMagicos)
                {
                    if (item is IAtaqueItemMagico)
                    {
                        value += (item as IAtaqueItemMagico).Ataque;
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
                foreach (IItemMagico item in this.ItemsMagicos)
                {
                    if (item is IDefensaItemMagico)
                    {
                        value += (item as IDefensaItemMagico).Defensa;
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

        public void OfensaDeAtaque(int power)
        {
            if (this.Defensa < power)
            {
                this.Vida -= power - this.Defensa;
            }
        }

        public void Curar()
        {
            this.Vida = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void AddItem(IItemMagico item)
        {
            this.ItemsMagicos.Add(item);
        }

        public void RemoveItem(IItemMagico item)
        {
            this.ItemsMagicos.Remove(item);
        }

    }
}
