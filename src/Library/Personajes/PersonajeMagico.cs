using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class PersonajeMagico: Heroe
    {
        private List<IItemMagico> ItemsMagicos = new List<IItemMagico>();
        
        public new int Ataque  
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
                    if (item is IItemAtaque)
                    {
                        value += (item as IAtaqueItemMagico).Ataque;
                    }
                }
                return value;
            }
        }
        public new int Defensa
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
      
        public void AddItemMagico(IItemMagico item)
        {
            this.ItemsMagicos.Add(item);
        }

        public void RemoveItemMagico(IItemMagico item)
        {
            this.ItemsMagicos.Remove(item);
        }
    }
}

/* namespace RoleplayGame
{
    public abstract class PersonajeMagico: Personaje
    {
        void AddItem(IItemMagico item);

        void RemoveItem(IItemMagico item);
    }
}
 */