using PetPals.Entity;
using PetPals.Menu;

namespace PetPals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PetPals";
            Console.WriteLine("WELCOME TO PETPALS");
            Console.WriteLine("The ultimate Pet Adoption Platform");

            PetAdoption petPals = new PetAdoption();
            petPals.Mainmenu();

            Console.WriteLine("\nThank you for using PetPals!");
            Console.WriteLine("\n         Visit Again!       ");
        }
    }
}
