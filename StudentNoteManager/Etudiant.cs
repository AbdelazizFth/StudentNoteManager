using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNoteManager
{
    public class Etudiant
    {
        public string name { get; set; }

        public List<float> Notes { get; set; } = new List<float>();
    }
}
