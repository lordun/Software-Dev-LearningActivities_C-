using System.Collections.Generic;

namespace Blockbuster___MultiFileProject
{
    public partial class Blockbuster
    {
        public string Address;
        public List<VHSTape> Movies;//this part should be initialized in the constructor method: = new List<VHSTape>();

        public Blockbuster(string storeAddress)
        {
            Address = storeAddress;
            Movies = new List<VHSTape>();
        }
        public void AddMovie(VHSTape tape)
        {
            Movies.Add(tape);
        }
        public bool HasMovie(string name)
        {
            VHSTape tape = Movies.Find(a => a.Name == name);
            if (tape == null)
            {
                return false;
            }
            return true;
        }
        public bool IsMovieAvailable(string name)
        {
            VHSTape tape = Movies.Find(a => a.Name == name);
            if (tape == null)
            {
                return false;
            }
            else
            {
                if (tape.Rented == false)
                    return true;
            }
            return false;
        }
    }
}
