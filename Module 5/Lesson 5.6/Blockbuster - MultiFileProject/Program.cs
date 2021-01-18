using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster___MultiFileProject
{

    class Program
    {
        static void Main(string[] args)
        {
            var store = new Blockbuster("Calgary, Alberta, Canada.");
            string command = "";
            while (command != "exit")
            {
                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                if (cmdArgs[0] == "add")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var length = float.Parse(cmdArgs.Last());
                    var tape = new VHSTape(name, length);
                    store.AddMovie(tape);
                }
                else if (cmdArgs[0] == "find")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    bool hasMovie = store.HasMovie(name);
                    if (hasMovie)
                        Console.WriteLine("Store has " + name);
                    else
                        Console.WriteLine("Store does not have " + name);
                }
                else if (cmdArgs[0] == "available")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    bool available = store.IsMovieAvailable(name);
                    if (available)
                        Console.WriteLine(name + " is available");
                    else
                        Console.WriteLine(name + " is rented");
                }
                else if (cmdArgs[0] == "rent")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    VHSTape movie = store.Rent(name);
                    Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                }
                else if (cmdArgs[0] == "play")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var duration = float.Parse(cmdArgs.Last());
                    var movie = store.GetRented(name);
                    movie.Play(duration);
                    Console.WriteLine(movie.Name + ": " + movie.Progress);
                }
                else if (cmdArgs[0] == "rewind")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                    var duration = float.Parse(cmdArgs.Last());
                    var movie = store.GetRented(name);
                    movie.Rewind(duration);
                    Console.WriteLine(movie.Name + ": " + movie.Progress);
                }
                else if (cmdArgs[0] == "return")
                {
                    var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                    var movie = store.GetRented(name);
                    store.Return(name);
                    Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                }
            }
        }
    }
}
