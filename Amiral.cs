using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmiralAPI
{
    public class Amiral
    {
        public int token { get; set; }

        public Amiral()
        {

        }

        public int GenereToken ()
        {
            Random aleatoire = new Random();
            int token = aleatoire.Next(9999999, 100000000);
            return token;
        }

    }
}
