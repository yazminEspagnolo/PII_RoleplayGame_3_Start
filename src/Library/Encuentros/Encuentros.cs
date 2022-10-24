using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame

{
    public class Encounter
    {
        protected List<Heroe> EquipoHeroe= new List<Heroe>();
        protected List<Enemigo> EquipoEnemigo= new List<Enemigo>(); 

        public void AddHeroe(Heroe heroe) 
        {
            this.EquipoHeroe.Add(heroe); 
        }
        public void AddEnemigo(Enemigo enemigo) 
        {
            this.EquipoEnemigo.Add(enemigo);
        }
        public void RemoveHeroe(Heroe heroe) 
        {
            this.EquipoHeroe.Remove(heroe);
        }
        public void RemoveEnemigo(Enemigo enemigo) 
        {
            this.EquipoEnemigo.Remove(enemigo);
        }
        public void printEquipo()   
        {   
            Console.WriteLine("Los Heroes son");
            foreach (Heroe h in this.EquipoHeroe)
            {   
                Console.WriteLine(h.Nombre);  
            }
            Console.WriteLine("Los Enemigos son");
            foreach (Enemigo e in this.EquipoEnemigo)
            {
                Console.WriteLine(e.Nombre);
                
            }
        }
        public void EnemigoVsHeroe() 
        {
            int objetivo=0;
            foreach(Enemigo e in this.EquipoEnemigo)
            {
                EquipoHeroe[objetivo].OfensaDeAtaque(e.Ataque);
                if(EquipoHeroe[objetivo].Vida<1)
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
        public void HeroeVsEnemigo() 
        {
            int objetivo=0;
            int EnemigoFinal=this.EquipoEnemigo.Count()-1;
            foreach(Heroe h in this.EquipoHeroe)
            {
                while(objetivo<= EnemigoFinal)
                {
                    EquipoEnemigo[objetivo].OfensaDeAtaque(h.Ataque);
                    if(EquipoEnemigo[objetivo].Vida<1)
                    {
                        h.SubirVP(EquipoEnemigo[objetivo].VP);
                        this.RemoveEnemigo(EquipoEnemigo[objetivo]);
                        EnemigoFinal=EnemigoFinal-1;
                    }
                    objetivo=objetivo+1;
                }
                objetivo=0;
                EnemigoFinal=this.EquipoEnemigo.Count()-1;
            }
        }

        public void DoEncounter() 
        {
            string Resultado="";      
            bool seguirloop=true;   
            while(seguirloop)       
            {
                this.EnemigoVsHeroe(); 
                int N_Heroe=this.EquipoHeroe.Count(); 
                if(N_Heroe>0)        
                {
                    this.HeroeVsEnemigo();
                    int N_Enemigo=this.EquipoEnemigo.Count();
                    if (N_Enemigo<1) 
                    {
                        seguirloop=false;
                        Resultado="Gano el equipo de Heroes";

                    }
                }
                else
                {
                    Resultado="Gano el equipo enemigo";
                    seguirloop=false;
                }
            }
            Console.WriteLine(Resultado);

        }

 
        
        
    }

}