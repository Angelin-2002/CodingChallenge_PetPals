using PetPals.Entity;
using PetPals.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Repository
{
    internal class PetShelterRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;

        public PetShelterRepository()
        {
            connect = new SqlConnection(DBConnectUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public List<Pets>? availablePets = new List<Pets>();

        public void addPet(Pets pet)
        {
            cmd.CommandText = "Insert into Pets values(@name,@species, @age,@breed)";
            cmd.Parameters.AddWithValue("@name", pet.Name);
            cmd.Parameters.AddWithValue("@species", pet.Species);
            cmd.Parameters.AddWithValue("@age", pet.Age);
            cmd.Parameters.AddWithValue("breed", pet.Breed);
            connect.Open();
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            connect.Close();


        }

        public void RemovePet(int p_id)
        {
            cmd.CommandText = "Delete from Pets where petID = @pet_id";
            cmd.Parameters.AddWithValue("@pet_id", p_id);
            connect.Open();
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Pets> ListAvailablePets(int availableForAdoption)
        {
            List<Pets> availablepets = new List<Pets>();
            cmd.CommandText = "Select * from Pets where availableForAdoption = @pet_status";
            cmd.Parameters.AddWithValue("@pet_status", availableForAdoption);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader sqlDatareader = cmd.ExecuteReader();
            while (sqlDatareader.Read())
            {
                Pets pet = new Pets();
                pet.PetID = (int)sqlDatareader["petID"];
                pet.Name = (string)sqlDatareader["name"];
                pet.Species = (string)sqlDatareader["species"];
                pet.Breed = (string)sqlDatareader["breed"];
                pet.Age = (int)sqlDatareader["age"];
                pet.AvailableForAdoption = (int)sqlDatareader["availableforadoption"];
                availablepets.Add(pet);


            }
            connect.Close();
            foreach (Pets pet in availablepets)
            {
                Console.WriteLine(pet);
            }
            return availablepets;
        }
    }
}
