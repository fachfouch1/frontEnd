
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Model.AdAppointment;

using Model.GestionUser;

namespace Service
{
    public class AdService
    {
        HttpClient httpClient;
        public AdService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public Boolean AjouterAd( Ad ad,long id)
        {
            id = 1;
            try
            {
                var APIResponse = httpClient.PostAsJsonAsync<Ad>(Statics.baseAddress + "/Ad/addEstate?id=" + id,ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Ad getbyId(int id)
        {
            
            Ad ad = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "/Ad/getAdbyId/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<Ad>().Result;

                return a;
            }


            return ad;
        }

        public bool updateAd( Ad ad,int id)
        {
           
            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Ad>(Statics.baseAddress + "/Ad/updateEstate?id=" + id, ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Ad> GetAllAds()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "/Ad/getEstate").Result;


            if (response.IsSuccessStatusCode)
            {
                var Lis = response.Content.ReadAsAsync<IEnumerable<Ad>>().Result;
                return Lis;
            }
            return new List<Ad>();

        }
        
        public bool DeleteAd(int id)
        {

            try
            {
                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "/Ad/deleteEstate?id=" + id).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}
