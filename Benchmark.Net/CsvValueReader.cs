using BenchmarkDotNet.Attributes;
using CsvHelper;
using System.IO;
using System.Text;

namespace Benchmark.Net
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {

            return $"{Name}: {Age}";
        }
    }
    public class CsvValueReader
    {
        public static string filePath = @"C:\TaviscaDev\Benchmark.Net\Benchmark.Net\testset.csv";

        [Benchmark]
        public void StringConcatenator()
        {
            string s = string.Empty;

            using (var reader = new StreamReader(filePath))
            {
                using (var csvFile = new CsvReader(reader))
                {
                    while (csvFile.Read())
                    {
                        s += csvFile.GetRecord<Person>().ToString();
                    }
                }
            }
        }

        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (var reader = new StreamReader(filePath))
            {
                using (var csvFile = new CsvReader(reader))
                {
                    while (csvFile.Read())
                    {
                        stringBuilder.Append(csvFile.GetRecord<Person>().ToString());
                    }
                }
            }
        }
    }
}