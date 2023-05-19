using Player.Commons;
using Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Players.DisneyPlus;

namespace Elisa.NetDay1_2.Players
{
    class TeatherPlayer : PlayerBase
    {
        public TeatherPlayer() : base()
        {

        }

      
        public override void Play()
        {
            Console.WriteLine($"flusso video da{nameof(TeatherPlayer)}");
            
        }

        protected override IList<IMovie>? CreateCatalogue()
        {
            var impCatalogue = new List<IMovie>();
            impCatalogue.Add(new Movie { Title = "Mamma Mia", });
            impCatalogue.Add(new Movie { Title = "Mad Max", });
            impCatalogue.Add(new Movie { Title = "La La Land", });
            impCatalogue.Add(new Movie { Title = "Cloud Atlas", });
            impCatalogue.Add(new Movie { Title = "Interstellar", });
            return impCatalogue;
        }
    }
}

