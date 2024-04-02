using PetPals.Entity;
using PetPals.Repository;
using PetPals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Menu
{
    internal class PetAdoption
    {
        IAdoptableService adoptableService = new IAdoptableService();
        PetShelterService petShelterService = new PetShelterService();
        MemberService memberService = new MemberService();

        public void Mainmenu()
        {
            bool log = false;
            do
            {
                Console.WriteLine("\nPress 1: Login\nPress 2: Register\nPress 3: Exit\n");
                Console.WriteLine("What would you like to do: ");
                int loginChoice = int.Parse(Console.ReadLine());

                switch (loginChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the name: ");
                        string membername = Console.ReadLine();
                        Console.WriteLine("Enter the password: ");
                        string password = Console.ReadLine();
                        log = memberService.Login(membername, password);
                        if (!log)
                        {
                            Console.WriteLine("Invalid name or password. Please try again!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Enter the password: ");
                        string newPassword = Console.ReadLine();
                        Member newMember = new Member() { Membername = newName, Password = newPassword };
                        memberService.Register(newMember);
                        Console.WriteLine("Registration successfull.Login to continue");
                        break;

                    case 3:
                        Console.WriteLine("Exiting from PetPals");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
            } while (!log);

            MainMenu();
        }


        public void MainMenu()
        {
            PetShelterService petShelterService = new PetShelterService();
            IAdoptableService adoptableService = new IAdoptableService();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("Press 1. Add a pet");
                Console.WriteLine("Press 2. Remove a pet");
                Console.WriteLine("Press 3. List the available pets");
                Console.WriteLine("Press 4. Record cash donation");
                Console.WriteLine("Press 5. Record item donation");
                Console.WriteLine("Press 6. Adoption event");
                Console.WriteLine("Press 7. Exit");
                Console.Write("What would you like to do: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the pet name:");
                            String pet_name = Console.ReadLine();
                            Console.WriteLine("Enter the pet species:");
                            String pet_species = Console.ReadLine();
                            Console.WriteLine("Enter the pet age:");
                            int pet_age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the pet breed:");
                            String pet_breed = Console.ReadLine();
                            Console.WriteLine("Enter the availability status:");
                            int pet_status = int.Parse(Console.ReadLine());
                            Pets pets = new Pets() { Name = pet_name, Species = pet_species, Age = pet_age, Breed = pet_breed, AvailableForAdoption = pet_status };
                            petShelterService.InsertPet(pets);
                            Console.WriteLine("Pet Details added successfully");
                            break;

                        case 2:
                            Console.WriteLine("Enter the pet Id:");
                            int petid = int.Parse(Console.ReadLine());
                            petShelterService.DeletePet(petid);
                            Console.WriteLine("Pet Details removed successfully");
                            break;

                        case 3:
                            Console.WriteLine("Enter the availability status:");
                            int av_status = int.Parse(Console.ReadLine());
                            petShelterService.AvailablePets(av_status);
                            break;

                        case 4:
                            Console.Write("Enter the donor name: ");
                            string donorname = Console.ReadLine();
                            Console.Write("Enter the donation amount: ");
                            decimal donationAmount = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter the donation date: ");
                            DateTime donationDate = Convert.ToDateTime(Console.ReadLine());
                            CashDonation donation = new CashDonation(donorname, donationAmount, donationDate);
                            IDonationRepository donationRepository = new IDonationRepository();
                            donationRepository.RecordDonation(donation);
                            break;

                        case 5:
                            Console.WriteLine("Enter the adoption status of the pet:");
                            String adoption_status = Console.ReadLine();
                            adoptableService.EventHost(adoption_status);
                            break;

                        case 6:
                            Console.WriteLine("Enter the participant name:");
                            String participant_name = Console.ReadLine();                                                   
                            Console.WriteLine("Enter the adopted pet id:");
                            int adpetid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the date:");
                            DateTime addate = DateTime.Parse(Console.ReadLine());
                            AdoptionEvent adoptionEvent = new AdoptionEvent() { ParticipantName = participant_name, AdoptedPetID = adpetid, AdoptionDate = addate };
                            adoptableService.Addparticipant(adoptionEvent);
                            break;

                        case 7:
                            Console.WriteLine("Exiting from Main Menu!");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice!");
                }

                Console.WriteLine();
            }
        }
    }
}
