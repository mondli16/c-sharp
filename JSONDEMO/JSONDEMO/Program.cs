using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace JSONDEMO
{
    internal class Program
    {

       
        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            Post post1 = new Post();

            //an htttp client to end the get request
            HttpClient httpClient = new HttpClient();
            try
            {
                //Need to wait for this to finish but dont wanna freeze our application 
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                Console.WriteLine(jsonResponse);

                //Desertilaze the json response into C# array of type Post[]
                var myPosts = JsonConvert.DeserializeObject <Post[]>(jsonResponse);
                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.Id} {post.Title}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                httpClient.Dispose();
            }
        }
    }
}
