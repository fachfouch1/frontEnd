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
    public enum NotificationType
    {
        Apointment_Suggested, Appointment_Moddified, Appointment_Canceled
    }
   public class Notification
    {
        [JsonProperty("id")]
        [Key]
        public long Id { get; set; }
        [JsonProperty("notificationType")]

        public NotificationType notifType { get; set; }
        [JsonProperty("isRead")]

        public bool isRead { get; set; }

        public int UserId { get; set; }
        public UserDari UserDari { get; set; }


    }
}
