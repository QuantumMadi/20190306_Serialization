using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Book> array = new List<Book>
            {
                new Book()
                {
                    Name = "War and peace",
                    Author = "Tolstoy",
                    Price = 1000,
                    PublishYear = new DateTime(1996,05,06),
                },
                 new Book()
                {
                    Name = "Monte Cristo",
                    Author = "A.Duma",
                    Price = 1500,
                    PublishYear = new DateTime(1945,07,06),
                },
                  new Book()
                {
                    Name = "Prestuplenie i nakazanie",
                    Author = "Dostoevsky",
                    Price = 2000,
                    PublishYear = new DateTime(1925,07,08),
                }
            };

            SaveAsBinaryFormat(array, "Books.dat");

            foreach(var book in LoadFromBinaryFile("Books.dat"))
            {
                Console.WriteLine($"{book.Name}\n{book.Author}\n{book.Price}\n{book.PublishYear.Year}\n-------------------");
            }
           
            Console.ReadLine();

        }
     
        static void SaveAsBinaryFormat(List<Book>objects,string fileName )
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using(var fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objects);
            }
        }
        static List<Book> LoadFromBinaryFile(string fileName)
        {
            List<Book> books;
            BinaryFormatter binFormat = new BinaryFormatter();
            using(var fs = File.OpenRead(fileName))
            {
               
                books = (List<Book>)binFormat.Deserialize(fs);
            }

            return books;
        }
    }
}
