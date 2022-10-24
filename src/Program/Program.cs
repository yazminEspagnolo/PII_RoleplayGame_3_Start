using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeHechizos book =new LibroDeHechizos();
            book.AddHechizo(new Cegar());
            book.AddHechizo(new Cegar());

            Mago Istari = new Mago("Istari");
            Istari.AddItemMagico(book);

            Elfo Claus = new Elfo("Claus");

            Enano Gruñon = new Enano("Gruñon");

            Gruñon.AddItem(new Hacha());
            Gruñon.AddItem(new Casco());
            Gruñon.AddItem(new Escudo());
            

            
         /*    Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida");
            Console.WriteLine($"Istari ataca a Gruñon con {Istari.Ataque}");

            Gruñon.OfensaDeAtaque(Istari.Ataque);

            Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida");


            Console.WriteLine($"Elfo ayuda a Gruñon con {Claus.Vida}");
            Gruñon.Curar();
            Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida restaurada"); */
        

        //**------------------------Encuentro----------------------------------**//

            Dragon Chimuelo= new Dragon("Chimuelo");
            Esqueleto Huesos= new Esqueleto("Huesos");
            TortugaNinja Leonardo= new TortugaNinja("Leonardo");
            //Creo el encuentro//
            Encounter Encuentro1= new Encounter();
            //Agrego los Heroes y enemigos al encuentro//
            Encuentro1.AddHeroe(Claus);
            Encuentro1.AddHeroe(Istari);
            Encuentro1.AddHeroe(Gruñon);
            Encuentro1.AddEnemigo(Chimuelo);
            Encuentro1.AddEnemigo(Huesos);
            Encuentro1.AddEnemigo(Leonardo);
            //imprimo los equipos//
            Encuentro1.printEquipo();
            //Realizo el encuentro//
            Encuentro1.DoEncounter();
        }
    }
}
