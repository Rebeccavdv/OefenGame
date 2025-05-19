using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefentoets_game
{
    public interface ISavebaar
    {
        public void Save();
    }

    public class Logboek : ISavebaar
    {
        private List<string> acties = new List<string>(); //lists alvast aanmaken
        //private List<string> acties;
        //public List<string> Acties { 
        //    get { return acties; }
        //    set { acties = new List<string>(); }
        //}

        public void Save()
        {
            //print alle acties
            foreach (var actie in acties)
            {
                Console.WriteLine(actie);
            }
        }

        public void NoteerActie(string actie)
        {
            acties.Add(actie);
        }
    }

    public class Instellingen : ISavebaar
    {
        public string Taal;
        public int Volume;
        public void Save()
        {
            Console.WriteLine($"Huidige taal en volume: {Taal}, {Volume}");
        }
    }


}
