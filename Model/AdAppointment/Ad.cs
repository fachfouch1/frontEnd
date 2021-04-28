using Model.GestionUser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model.AdAppointment
{
    public enum AdType
    {

        Villa, appartement, maison_hote
    }
    public enum Ad_Etat
    {
        For_Sell, For_Rent, In_process, Sold, Rented
    }

   public class Ad
    {
        [Key]
        [JsonProperty("id")]

        public int Id { get; set; }
        [JsonProperty("name")]

        public string name { get; set; }
        [JsonProperty("price_per_day")]

        public float price_per_day { get; set; }
        [JsonProperty("price_per_month")]

        public float price_per_month { get; set; }
        [JsonProperty("price")]

        public float  price { get; set; }
        [JsonProperty("type")]

        public AdType AdType { get; set; }

        [JsonProperty("etat")]

        public Ad_Etat Ad_Etat { get; set; }

        [JsonProperty("governorate")]

        public String Governorate { get; set; }
        [JsonProperty("delegation")]

        public String Delegation { get; set; }
        [JsonProperty("surface")]

        public double surface { get; set; }
        [JsonProperty("nbrpieces")]

        public int nbrpieces { get; set; }
        [JsonProperty("rooms")]

        public int rooms { get; set; }
        [JsonProperty("image")]

        public String image { get; set; }
        [JsonProperty("piscine")]

        public bool piscine { get; set; }
        [JsonProperty("description")]

        public String description { get; set; }
        [JsonProperty("taux_reduction")]

        public int taux_reduction { get; set; }




        [JsonProperty("fav")]

        public ICollection<AdFav> AdFavs { get; set; }

        public ICollection<Appointment> Appointments{ get; set; }









    }
}
