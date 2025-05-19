using System.Reflection;
using System;

namespace Oefentoets_game
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Sla de instellingen van de game op.
            //Maak een ridder, tovenaar en boogschutter aan, elk met een specifieke naam en een HP van 50.
            //Laat de personages aanvallen en laat hen schade ontvangen.Voeg elke actie toe aan het logboek.
            //Toon het tot dus verre opgeslagen logboek en de instellingen.
            var instelling = new Instellingen() { Taal = "mogools", Volume = 22};
            //instelling.Taal = "Nederlands";
            //instelling.Volume = 19;


            var ridder1 = new Ridder("Jeroen", 50, 20);
            var tovenaar1 = new Tovenaar("Dumbledore", 1000, ElementType.Lucht);
            var boogschutter1 = new Boogschutter("Piet", 30, 9);

            var ridder1aanval = ridder1.Attack();
            var tovernaanval = tovenaar1.Attack();
            var boogschutteraanval = boogschutter1.Attack();

            var ridderschade = ridder1.TakeDamage(10);
            var toverschade = tovenaar1.TakeDamage(30);
            var boogschade = boogschutter1.TakeDamage(10);

            var logboek = new Logboek() { };
            logboek.NoteerActie(ridder1aanval);
            logboek.NoteerActie(boogschade);

            logboek.Save();
            instelling.Save();




        }
    }
}
