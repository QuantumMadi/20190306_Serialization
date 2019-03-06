//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;


//namespace Theory
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Person person = new Person
//            //{
//            //    Name = "Aslan",

//            //};

//            //string json = JsonConvert.SerializeObject(person);
//            //Person result = JsonConvert.DeserializeObject<Person>(json);
//            ////var serializer = new BinaryFormatter();
//            //using (var stream = File.Create("data.bin"))
//            //{
//            //    serializer.Serialize(stream, person);
//            //}

//            //using (var stream = File.OpenRead("data.bin"))
//            //{
//            //    var result = serializer.Deserialize(stream) as Person;
//            //    Console.WriteLine($"{result.Id}, { result.Name}");
//            //}

//            WebClient client = new WebClient();
//            client.DownloadFile("http://hp-api.herokuapp.com/api/characters","file.json" );

//            //var file = File.OpenRead("file.json");
//            //string json = JsonConvert.DeserializeObject(file) ;

//            RootObject[] obj = new RootObject[30];

//            string json = JsonConvert.SerializeObject(obj);

//            using (Stream stream = client.OpenRead("http://hp-api.herokuapp.com/api/characters"))
//            {
//                using (StreamReader reader = new StreamReader(stream))
//                {
//                    string line = "";
//                    while ((line = reader.ReadLine()) != null)
//                    {
                        
//                    }
//                    obj = JsonConvert.DeserializeObject<RootObject[]>(line);
//                }
//            }

//            //WebClient client2 = new WebClient();
//            //client.DownloadFile("http://hp-api.herokuapp.com/api/characters/students", "file.json");

//            //RootObject obj2 = new RootObject();

//            //using (Stream stream = client.OpenRead("http://hp-api.herokuapp.com/api/characters"))
//            //{
//            //    using (StreamReader reader = new StreamReader(stream))
//            //    {

//            //        obj2 = JsonConvert.DeserializeObject<RootObject>(json);
//            //    }
//            //}

//            Console.ReadLine();
//        }
//    }
//}
