using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoTournament
{
    class Participant
    {
        public readonly int Id;
        public readonly string Name;


        public Participant(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
