using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.Commons
{
    public interface IMovie
    {
        string? Title { get; set; }
        void Play();

        //List<string> Catalogue();
    }
}
