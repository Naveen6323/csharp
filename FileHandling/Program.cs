using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.Json.Nodes;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace FileHandling
{
    class Person
    {
        public int ID { get;  set; }
        public string name { get;  set; }
        public int age { get;  set; }
    }
    internal class FileHandling
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\navee\source\repos\practice problems\FileHandling\FileHandlingJSON.json";
            //IsExist(@"C:\Users\navee\OneDrive\Desktop\FileHandling\Operations\Example.txt");
            //Write(path);
            //ReadLines(@"C:\Users\navee\OneDrive\Desktop\FileHandling\Operations\Example.txt");
            //DirectoryInfo d = new DirectoryInfo(@"C:\Users\navee\OneDrive\Desktop\FileHandling\Operations");
            //int[] arr = { 1, 2, 3 };
            //List<string> l = new List<string>();
            //l.Remove("dajsdb");
            //DeleteContent(path);
            //File.Create(path);
            List<Person> person = new List<Person>()
            {
                new Person() { ID = 1, name = "Sam", age = 23 },
                new Person() { ID = 2, name = "Robert", age = 21 },
                new Person() { ID = 4, name = "Richard", age = 30 }
            };
            //string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            //File.WriteAllText(path,json);
            //string jsonData = File.ReadAllText(path);
            //var deserializedData = JsonConvert.DeserializeObject<List<Person>>(jsonData);
            //foreach (var record in deserializedData)
            //{
            //    Console.WriteLine($"[ID = {record.ID}, Name = {record.name}, Age = {record.age}]");
            //}
            ReadJsonData(path);
            //ReadCsvData(path);
            //DeleterecordByID(path,2);
            //ReadCsvData(path);
            
        }

        public static void IsExist(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("file exists");
                return;
            }

            File.Create(path);
            Console.WriteLine("file created");
            
        }

        public static string ReadLines(string path)
        {
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            return lines;
        }

        public static void Write(string path)
        {

            string Old = ReadLines(path);
            StringBuilder oldData = new StringBuilder(Old);
            string newdata = Console.ReadLine();
            if(oldData.Length!=0) oldData.Append(" ");
            oldData.Append(newdata);
            File.WriteAllText(path,oldData.ToString());
        }

        public static void DeleteAllContent(string path)
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path,String.Empty);
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("succesfully deleted");
                return;
            }

            Console.WriteLine("no file exist with that name");
        }

        public static void DeleteContent(string path)
        {
            if (File.Exists(path))
            {
                ReadLines(path);
                Console.WriteLine("enter the content u want to delete");
                string del = " "+Console.ReadLine();
                var content = File.ReadAllText(path).Split('.').ToList();
                if (content.Count == 2)
                {
                    content.Remove(del.Trim());
                }
                else
                {
                    content.Remove(del);
                }
                string wr = string.Join(".", content);
                File.WriteAllText(path,wr);
            }
            else
            {
                Console.WriteLine("file does not exist");
            }
        }

        public static void AddCsvData(List<Person>? s, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(s);

            }
        }

        public static void ReadCsvData(string path)
        {
         using(var reader = new StreamReader(path))
         using (var csvData = new CsvReader(reader, CultureInfo.InvariantCulture))
         {
             var records = csvData.GetRecords<Person>();
             foreach (var record in records)
             {
                 Console.WriteLine($"[ID = {record.ID}, Name = {record.name}, Age = {record.age}]");
             }
         }
        }

        public static void DeleterecordByID(string path, int id)
        {
            List<Person> updatedRecords;
            using(var reader = new StreamReader (path))
            using (var csvData = new CsvReader(reader, CultureInfo.InvariantCulture))
                
            {
                var records = csvData.GetRecords<Person>();
                updatedRecords = records.Where(x => x.ID != id).ToList();
            }
            AddCsvData(updatedRecords,path);
            
        }

        public static void AddJsonData(string path, List<Person> p)
        {
            string json = JsonConvert.SerializeObject(p,Formatting.Indented);
            File.WriteAllText(path,json);
        }

        public static IEnumerable<Person>        ReadJsonData(string path)
        {
            string jsonData = File.ReadAllText(path);
            var deserializeData = JsonConvert.DeserializeObject<List<Person>>(jsonData);
            foreach (var record in deserializeData)
            {
                Console.WriteLine($"[ID = {record.ID}, Name = {record.name}, Age = {record.age}]");
            }

            return deserializeData;
        }

        public static void DeleteJsonByID(string path, int id)
        {
            var updatedData = ReadJsonData(path).Where(x => x.ID != id).ToList();
            AddJsonData(path,updatedData);
        }
        
        


    }
}

