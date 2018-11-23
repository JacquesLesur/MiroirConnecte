using MiroirConnecte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroirConnecte
{
    public static class Config
    {
        private static readonly List<string> apiWeatherParameters = new List<string> (new string[] {
            "nantes",
            "&units=metric", //celsius
            "&lang=fr",
            "&APPID=7b8d894b477582dfcadab6e43ffaf79c" //APIKey
        });
        // doc at --> https://newsapi.org/docs
        private static readonly List<string> apiNewsParameters = new List<string>(new string[] {
            "country=fr",
            "&category=technology",
            "&apiKey=bff155b8adbe4360b8fdbb0f132f2b98" //APIKey
        });
        public static readonly API wetherUrl = new API("https://api.openweathermap.org/data/2.5/weather?q=", apiWeatherParameters);
        public static readonly API newsUrl = new API("https://newsapi.org/v2/top-headlines?", apiNewsParameters);
        public static readonly string kaamelottUrl = "https://kaamelott.chaudie.re/api/random";


    }
}
