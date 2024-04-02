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
    internal class IAdoptionRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;


        public IAdoptionRepository()
        {
            connect = new SqlConnection(DBConnectUtil.GetConnectionString());
            cmd = new SqlCommand();
        }


        public List<AdoptionEvent> GetAvailableParticpants(String adoption_status)
        {
            List<AdoptionEvent> availableParticipants = new List<AdoptionEvent>();
            cmd.CommandText = "Select * from AdoptionEvent where adoption_status = @status";
            cmd.Parameters.AddWithValue("@status", adoption_status);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                AdoptionEvent participant = new AdoptionEvent();
                participant.ParticipantID = (int)sqlDataReader["participant_id"];
                participant.ParticipantName = (string)sqlDataReader["participant_name"];
                participant.AdoptedPetID = (int)(sqlDataReader["adopted_pet_id"] == DBNull.Value ? (int?)null : (int)sqlDataReader["adopted_pet_id"]);
                participant.AdoptionDate = (DateTime)sqlDataReader["registration_date"];
                availableParticipants.Add(participant);

            }
            connect.Close();
            return availableParticipants;
        }

        public void RegisterParticipant(AdoptionEvent participant)
        {
            cmd.CommandText = "Insert into AdoptionEvent values(@participant_id, @participant_name, @adopted_pet_id, @adoption_date)";
            cmd.Parameters.AddWithValue("@participant_id", participant.ParticipantID);
            cmd.Parameters.AddWithValue("@participant_name", participant.ParticipantName);
            cmd.Parameters.AddWithValue("@adopted_pet_id", participant.AdoptedPetID);
            cmd.Parameters.AddWithValue("@registration_date", participant.AdoptionDate);

            connect.Open();
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
