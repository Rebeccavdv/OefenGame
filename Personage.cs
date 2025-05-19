using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oefentoets_game
{
    public abstract class Personage
    {
        private string naam;
        //public string Naam => naam;
        public string Naam {get { return naam; } }

        private int hp;
        public int HP { get { return hp; } }

        public Personage(string Naam, int HP)
        {
            naam = Naam;
            hp = HP;
        }


        public abstract string Attack();

        public virtual string TakeDamage(int schade)
        {
            // schade min hp = string actie> consolewrite 
            var nieuwHP = HP - schade;
            var actie = $"{Naam} heeft {schade} gepakt en heeft nu {nieuwHP}HP";
            Console.WriteLine(actie);
            return actie;
        }
    }

    public class Ridder : Personage
    {
        private int armor;

        public Ridder(string Naam, int HP, int Armor) : base(Naam, HP)
        {
            armor = Armor;
        }

        public override string Attack()
        {
            string aanval = $"{Naam} valt aan met zijn zwaard ;)";
            Console.WriteLine(aanval);
            return aanval;
        }

        public override string TakeDamage(int schade)
        {
            var echteschade = schade - armor;
            var nieuwHP = HP - echteschade;
            var actie = $"{Naam} heeft {echteschade} gepakt en heeft nu {nieuwHP}HP";
            Console.WriteLine(actie);
            return actie;
        }
    }
    public class Tovenaar : Personage
    {
        private ElementType element;

        public Tovenaar(string Naam, int HP, ElementType Element) : base(Naam, HP)
        {
            element = Element;
        }

        public override string Attack() // Print dat de tovenaar een aanval uitvoert met zijn element.
                                        // De actie word ook teruggegeven in string formaat.
        {
            string aanval = $"{Naam} voert een aanval uit met {element}";
            Console.WriteLine(aanval);
            return aanval;
        }
    }

    public class Boogschutter : Personage //Print dat de boogschutter een pijl schiet en verlaagt het aantal pijlen met 1.
                                          //Als er geen pijlen meer zijn, wordt dat gemeld. De actie word ook teruggegeven in string formaat.
    {
        private int aantalpijlen;

        public Boogschutter(string Naam, int HP, int Aantalpijlen) : base(Naam, HP)
        {
            if (Aantalpijlen >= 0) 
            { 
                aantalpijlen = Aantalpijlen;
            }
            else { 
                aantalpijlen = 0;
            }
         
        }

        public override string Attack()
        {
            string succes = $"{Naam} schiet een pijl en heeft nu {aantalpijlen} pijlen over";
            string mislukt = $"Er zijn geen pijlen meer";

            if (aantalpijlen > 0) { return succes ; }
            else
            { return mislukt; }
        }
    }
}
