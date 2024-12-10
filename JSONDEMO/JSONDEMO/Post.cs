using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSONDEMO
{
    public class Post
    {

        
            [JsonProperty("id")]

            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }
    }
}
