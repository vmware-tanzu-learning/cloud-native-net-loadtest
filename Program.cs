using System;
using System.Net.Http;

namespace bootcamp_core_loadtester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing load ...");

            HttpClient c = new HttpClient();

            for(int i = 0; i < 2500; i++)
            {
                var result = c.GetStringAsync("https://<enter your service>/api/products").Result; 
                Console.WriteLine("calling API - " + DateTime.Now.ToString());
                
                System.Threading.Thread.Sleep(100);
            }   

            Console.WriteLine("done calling API");
        
        }
    }
}
