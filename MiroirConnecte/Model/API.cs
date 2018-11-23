using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroirConnecte.Model
{
    public class API
    {

        private string url;
        private List<string> parameters = new List<string>();
        public API(string url, List<string> parameters)
        {
            this.url = url;
            this.parameters = parameters;
        }
        public string concat()
        {
            string fullURL = url;
            foreach (var param in parameters)
            {
                fullURL += param;
            }
            return fullURL;
        }



    }
}
