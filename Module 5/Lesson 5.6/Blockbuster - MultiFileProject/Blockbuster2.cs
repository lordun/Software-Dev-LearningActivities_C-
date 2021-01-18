using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster___MultiFileProject
{
    public partial class Blockbuster
    {
        public VHSTape Rent(string name)
        {
            VHSTape tape = Movies.Find(a => a.Name == name);
            if (tape == null) return null;

            else if (tape.IsRented() == false)
            {
                tape.Rented = true;
                return tape;
            }
            return null;
        }
        public VHSTape GetRented(string name)
        {
            VHSTape tape = Movies.Find(a => a.Name == name);
            if (tape == null) return null;
            else if (tape.IsRented() == true)
            {
                return tape;
            }
            return null;
        }
        public void Return(string name)
        {
            VHSTape tape = Movies.Find(a => a.Name == name);
            if (tape.IsRented() == true)
            {
                tape.Rented = false;
            }
        }
    }
}

