using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Theory;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person
            //{

            //};

            //string json = JsonConvert.SerializeObject(person);
            //Person result = JsonConvert.DeserializeObject<Person>(json);


            WebClient client = new WebClient();
            var jsonFile = client.DownloadString("http://hp-api.herokuapp.com/api/characters");
            var res = JsonConvert.DeserializeObject<RootObject[]>(jsonFile);

            WebClient client2 = new WebClient();
            var jsonFile2 = client.DownloadString("http://hp-api.herokuapp.com/api/characters/students");
            var res2 = JsonConvert.DeserializeObject<RootObject[]>(jsonFile2);

            WebClient client3 = new WebClient();
            var jsonFile3 = client.DownloadString("http://hp-api.herokuapp.com/api/characters/staff");
            var res3 = JsonConvert.DeserializeObject<RootObject[]>(jsonFile3);

            WebClient client4 = new WebClient();
            var jsonFile4 = client.DownloadString("http://hp-api.herokuapp.com/api/characters/house/:house");
            var res4 = JsonConvert.DeserializeObject<RootObject[]>(jsonFile4);


            Console.Read();
        }
    }
}