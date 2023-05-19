using Player.Commons;
using System.Linq;

namespace Players //un oggetto deve essere responsabile dei proprio campi,della sua inizializzazione e gestione.
    
{
    public abstract class PlayerBase: IPlayer
    {
        private int id;
        private string? name;
        private string? description;
        
        private IList<IMovie> films;

        

        public IList<IMovie> Films
        {
            get 
            {   
                if(films is null) //come fare ==null
                {
                    films = CreateCatalogue(); 
                }
                return films; 
            }
            //set { films = value; } //non voglio che dall'esterno venga modificata la lista di film
        }

        protected abstract IList<IMovie>? CreateCatalogue();
       

        public PlayerBase()
        {
            
            //films.Add(movieToPlay);
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { name = value; }
        }

        public abstract void Play();

        
        public IList<IMovie> Find(string movieTitleToSearch)
        {
            
            if (Films is null)
            {
                return new List<IMovie>();
            }
            return films.Where(m => m.Title.Contains(movieTitleToSearch, StringComparison.InvariantCultureIgnoreCase)).ToList();


        }

        //public abstract void Catalogue(IMovie movieToPlay,List<IMovie> films);
     

        
    }
}
