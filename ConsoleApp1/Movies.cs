using Elisanewproject;
using Player.Commons;

namespace Elisanewproject
{

    public  class Movie: IMovie
    {
        private string? _title;
        //se metti il punto interrogativo dopo il tipo è come scrivere Nullable<String>
        private MovieType MovieType;
        

        public  MovieType genere
        {
            get { return MovieType; }

            set { MovieType = value; }
        }

        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public override string ToString()
        {

            return Title;


        }
        public override bool Equals(object obj)
        {
            var movie = obj as Movie; //soft cast, gli dico che obj potrebbe essere di tipo Movie
            if (movie == null) return false;
            return (this.Title == movie.Title);
        }

        public  void Play()
        {
            Console.WriteLine( $"Sto riproducendo{Title}");
        }

    }
}
