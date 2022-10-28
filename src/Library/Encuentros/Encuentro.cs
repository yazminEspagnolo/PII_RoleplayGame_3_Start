using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame

{
    public class Encounter
    {
        // Enlisto a los personajes que participan en el encuentro.
        protected List<Heroe> EquipoHeroe= new List<Heroe>();
        protected List<Enemigo> EquipoEnemigo= new List<Enemigo>(); 

        public void AddHeroe(Heroe heroe) 
        {
            this.EquipoHeroe.Add(heroe);  // Agrego un heroe al equipo de heroes.
        }
        public void AddEnemigo(Enemigo enemigo) 
        {
            this.EquipoEnemigo.Add(enemigo); // Agrego un enemigo al equipo de enemigos.
        }
        public void RemoveHeroe(Heroe heroe) 
        {
            this.EquipoHeroe.Remove(heroe); // Remuevo un heroe del equipo de heroes.
        }
        public void RemoveEnemigo(Enemigo enemigo) 
        {
            this.EquipoEnemigo.Remove(enemigo); // Remuevo un enemigo del equipo de enemigos.
        } 
        public void printEquipo()   
        {   
            Console.WriteLine("Los Heroes son");
            // Imprimo los heroes del equipo.
            foreach (Heroe h in this.EquipoHeroe) 
            {   
                Console.WriteLine(h.Nombre);  
            }
            Console.WriteLine("Los Enemigos son");
            // Imprimo los enemigos del equipo.
            foreach (Enemigo e in this.EquipoEnemigo)
            {
                Console.WriteLine(e.Nombre);
                
            }
        }

        public void EnemigoVsHeroe() 
        // Realizo el encuentro entre un enemigo y un heroe.
        {
            int objetivo=0;
            foreach(Enemigo e in this.EquipoEnemigo) // Recorro el equipo de enemigos.
            {
                EquipoHeroe[objetivo].OfensaDeAtaque(e.Ataque); // El enemigo ataca al heroe.
                if(EquipoHeroe[objetivo].Vida<1) // Si el heroe muere, se remueve del equipo.
                {
                    this.RemoveHeroe(EquipoHeroe[objetivo]); 
                }
                objetivo++;
                if(objetivo>=this.EquipoHeroe.Count()) 
                {
                    objetivo=0;
                }
            }
        }
        // Realizo el encuentro entre un heroe y un enemigo.
        public void HeroeVsEnemigo() 
        {
            int objetivo=0;
            int EnemigoFinal=this.EquipoEnemigo.Count()-1; 
            foreach(Heroe h in this.EquipoHeroe) // Recorro el equipo de heroes.
            {
                while(objetivo<= EnemigoFinal) 
                {
                    EquipoEnemigo[objetivo].OfensaDeAtaque(h.Ataque); // El heroe ataca al enemigo.
                    if(EquipoEnemigo[objetivo].Vida<1)
                    {
                        h.SubirVP(EquipoEnemigo[objetivo].VP); // El heroe sube su VP.
                        this.RemoveEnemigo(EquipoEnemigo[objetivo]); // El enemigo muere y se remueve del equipo.
                        EnemigoFinal=EnemigoFinal-1; 
                    }
                    objetivo=objetivo+1;
                }
                objetivo=0;
                EnemigoFinal=this.EquipoEnemigo.Count()-1;
            }
        }
        // Realizo el encuentro 
        public void DoEncounter() 
        {
            string Resultado="";      
            bool seguirloop=true;   
            while(seguirloop)       
            {
                this.EnemigoVsHeroe(); // El enemigo ataca al heroe.
                int N_Heroe=this.EquipoHeroe.Count(); // Cuento la cantidad de heroes.
                if(N_Heroe>0)   
                {
                    this.HeroeVsEnemigo(); // El heroe ataca al enemigo.
                    int N_Enemigo=this.EquipoEnemigo.Count(); // Cuento la cantidad de enemigos.
                    if (N_Enemigo<1) 
                    {
                        seguirloop=false;
                        Resultado="Gano el equipo de Heroes"; // Si no quedan enemigos, gana el equipo de heroes.

                    }
                }
                else
                {
                    Resultado="Gano el equipo enemigo"; // Si no quedan heroes, gana el equipo de enemigos.
                    seguirloop=false;
                }
            }
            Console.WriteLine(Resultado);

        }

 
        
        
    }

}