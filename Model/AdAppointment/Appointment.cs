using Model.GestionUser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.AdAppointment
{
  public  class Appointment
    {
        [JsonProperty("id")]
        [Key]
        public long Id { get; set; }
        [JsonProperty("title")]

        public String Title { get; set; }
        [JsonProperty("description")]

        public String Description { get; set; }
        [JsonProperty("dateOfAppointment")]

        public DateTime dateOfAppointment { get; set; }
        [JsonProperty("timeOfAppointment")]

        public DateTime TimeOfAppointment { get; set; }
        [JsonProperty("appointmentAdress")]

        public String AppointmentAdress { get; set; }
        [JsonProperty("StateAppointment")]

        public int StateAppointment { get; set; }
       // [JsonProperty("userId")]

        public int UserId { get; set; }
        public UserDari UserDari { get; set; }
      //  [JsonProperty("idapp")]

        public int AdId { get; set; }
        public Ad Ad { get; set; }




    }
}
