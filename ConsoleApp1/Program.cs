// See https://aka.ms/new-console-template for more information
//Movie movie = new Movie();
//movie.Title = "Alien";
//Console.WriteLine(movie); //stampa il nome dell'oggetto perchè tutte le classi eridatono dalla classe object che hanno il metodo to string che viene eseguito dal console writeline

//var movie1 = new Movie();
//movie1.Title = "Alien";

//Console.WriteLine(movie.Equals(movie1)); //(ora ritorna vero perchè abbiamo fatto l'override)questo ritorna falso perchè usano spazi di memoria differente quindi possiamo fare l'override dell'Equals per forzare il true in casi del genere

using PlayerManager;
using Players;

Console.WriteLine("Hello Nele");
;//equivalente a   Movie movie = new Movie();   movie.Title = "Alien";Console.WriteLine(movie);

//var disFilms = new List<IMovie>()
//{
//    movie,
//    movie2,
//    movie3,
//};


//var disneyMovie = new DisneyPlus(movie,disFilms);


var playerManager = new Nirvana();
Console.WriteLine("premi per visualizzare i player disponibili");
Console.ReadLine();
//Boolean end = false;
//do
//{
//    foreach (var player in playerManager.GetPlayers())
//    {

//        if (player.CanPlay(movie))
//        {
//            Console.WriteLine($"vuoi riprodurre {movie.Title} su {player}?");
//            var userChoice = Console.ReadLine();
//            if (userChoice != "S" && userChoice != "N")
//            {
//                Console.WriteLine("scegli S o N");
//                Console.ReadLine();
//            }

//            if (userChoice == "S")
//            {
//                movie.Play();
//                end = true;
//                break;
//            }
//            else if (userChoice == "N")
//            {
//                Console.WriteLine("ci spiace che non vuoi vedere il film");
//                Console.ReadLine();
//            }
//            else
//            {
//                Console.WriteLine($"titolo non trovato su{player}");
//                Console.ReadLine();

//            }
//            end = true;

//        } 



//    }

//} while (!end);
foreach (var player in playerManager.GetPlayers())
{
    var result = ((PlayerBase)player).Find("Dune").FirstOrDefault();//cast aggressivo per accedere al metodo .Find;firstordefault ti restituisce solo il primo elemento della lista
    if (result is not null)
    {
        Console.WriteLine($"Vuoi riprodurre ${result.Title} su {player}?");
    }
    
    else
    {
        Console.WriteLine($"titolo non trovato su {player}");

    }
    Console.WriteLine("Non ci sono più film.");
}



