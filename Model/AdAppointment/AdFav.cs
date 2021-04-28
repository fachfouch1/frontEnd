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
  public  class AdFav
    {
        [JsonProperty("id")]
        [Key]
        public long Id { get; set; }


        public int UserId { get; set; }
        public UserDari UserDari { get; set; }

        public int AdId { get; set; }
        public Ad Ad { get; set; }

        

    }
}
