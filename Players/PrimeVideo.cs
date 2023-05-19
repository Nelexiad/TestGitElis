using Player.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Players.DisneyPlus;

namespace Players
{
    public class PrimeVideo : PlayerBase
    {
        public PrimeVideo() : base()
        {
        }

       

        public override void Play()
        {
            Console.WriteLine($"flusso video da{nameof(PrimeVideo)}");
            
        }

        protected override IList<IMovie>? CreateCatalogue()
        {
            var impCatalogue = new List<IMovie>();
            impCatalogue.Add(new Movie { Title = "Limitless", });
            impCatalogue.Add(new Movie { Title = "The Imitation Game", });
            impCatalogue.Add(new Movie { Title = "Vi presento Joe Black", });
            impCatalogue.Add(new Movie { Title = "Intervista col Vampito", });
            impCatalogue.Add(new Movie { Title = "Il Conte di MonteCristo", });
            return impCatalogue;
        }
    }
}