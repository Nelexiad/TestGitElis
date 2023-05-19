using Player.Commons;
using Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Players.DisneyPlus;

namespace Players
{
    public class NetflixPlayer : PlayerBase
    {
        public NetflixPlayer() : base()
        {
        }

        

        public override void Play()
        {
            Console.WriteLine($"flusso video da{nameof(NetflixPlayer)}");
            
        }

        protected override IList<IMovie>? CreateCatalogue()
        {
            var impCatalogue = new List<IMovie>();
            impCatalogue.Add(new Movie { Title = "Film Blu", });
            impCatalogue.Add(new Movie { Title = "Film Bianco", });
            impCatalogue.Add(new Movie { Title = "Film Rosso", });
            impCatalogue.Add(new Movie { Title = "La Pelle che Abito", });
            impCatalogue.Add(new Movie { Title = "La Mala Education", });
            return impCatalogue;
        }
    }
}


