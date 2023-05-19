using Player.Commons;
using Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManager
{
    public class Nirvana
    {
        List<IPlayer> players = new List<IPlayer>();
       //
       
        public Nirvana()
        {
              players.Add(new NetflixPlayer());
            players.Add(new DisneyPlus());
            players.Add(new PrimeVideo());
        }
        public List<IPlayer> GetPlayers() {  return players; } 
    }
}
