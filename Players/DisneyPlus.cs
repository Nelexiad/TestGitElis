using Player.Commons;
using Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    public class DisneyPlus : PlayerBase
    {

        public class Movie : IMovie
        {
            public string? Title { get ; set ; }

            public void Play()
            {
                //TODO 
            }
        }
        public DisneyPlus() : base()
        {
           
        }

      

        

        //public override void Catalogue(IMovie movieToPlay, List<IMovie> films )
        //{
        //    films.Add(movieToPlay);
        //    movieToPlay.Catalogue();
        //}

        public override void Play()
        {
            Console.WriteLine(  $"flusso video da{nameof(DisneyPlus)}");
            
        }

        protected override IList<IMovie>? CreateCatalogue()
        {
            var impCatalogue= new List<IMovie>();
            impCatalogue.Add(new Movie { Title = "Tutto su mia madre",});
            impCatalogue.Add(new Movie { Title = "Mine Vaganti", });
            impCatalogue.Add(new Movie { Title = "Matrix", });
            impCatalogue.Add(new Movie { Title = "Dune", });
            impCatalogue.Add(new Movie { Title = "Orgoglio e Pregiudizio", });
            return impCatalogue;
        }
    }
}

