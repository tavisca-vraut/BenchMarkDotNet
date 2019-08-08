using BenchmarkDotNet.Running;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Benchmark.Net
{
    class Program
    {
        static void Main(string[] _)
        {
            //List<Person> nameAge = new List<Person>();

            //Random random = new Random();

            //foreach (var i in Enumerable.Range(0, 10000))
            //{
            //    nameAge.Add(new Person { Name = "Vighnesh", Age = random.Next(20, 80) });
            //}

            //using (TextWriter writer = new StreamWriter(@"C:\TaviscaDev\Benchmark.Net\Benchmark.Net\testset.csv", false, System.Text.Encoding.UTF8))
            //{
            //    using (var csv = new CsvWriter(writer))
            //    {
            //        csv.WriteRecords(nameAge); // where values implements IEnumerable
            //    }
            //}

            BenchmarkRunner.Run<CsvValueReader>();
            Console.ReadKey(true);
        }
    }
}
