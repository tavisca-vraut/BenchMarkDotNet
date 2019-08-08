using BenchmarkDotNet.Attributes;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Benchmark.Net
{
    public class ForVsWhileLoop
    {
        public static string filePath = @"C:\TaviscaDev\Benchmark.Net\Benchmark.Net\testset.csv";
        public static List<Person> items;

        public ForVsWhileLoop()
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csvFile = new CsvReader(reader))
                {
                    items = csvFile.GetRecords<Person>().ToList();
                }
            }
        }

        [Benchmark]
        public void WhileLoop()
        {
            int i = 0;
            while (i < items.Count)
            {
                var temp = items[i];
                i++;
            }
        }

        [Benchmark]
        public void ForLoop()
        {
            for (int i = 0; i < items.Count; i++)
            {
                var temp = items[i];
            }
        }
    }
}