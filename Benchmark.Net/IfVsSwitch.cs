using BenchmarkDotNet.Attributes;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Benchmark.Net
{
    public class IfVsSwitch
    {
        [Benchmark]
        public void If()
        {
            Person temp = new Person
            {
                Name = "Vighnesh",
                Age = 3600
            };

            if (temp.Age == 100) { }
            else if (temp.Age == 200) { }
            else if (temp.Age == 300) { }
            else if (temp.Age == 400) { }
            else if (temp.Age == 500) { }
            else if (temp.Age == 600) { }
            else if (temp.Age == 700) { }
            else if (temp.Age == 800) { }
            else if (temp.Age == 900) { }
            else if (temp.Age == 1000) { }
            else if (temp.Age == 1100) { }
            else if (temp.Age == 1200) { }
            else if (temp.Age == 1300) { }
            else if (temp.Age == 1400) { }
            else if (temp.Age == 1500) { }
            else if (temp.Age == 1600) { }
            else if (temp.Age == 1700) { }
            else if (temp.Age == 1800) { }
            else if (temp.Age == 1900) { }
            else if (temp.Age == 2000) { }
            else if (temp.Age == 2100) { }
            else if (temp.Age == 2200) { }
            else if (temp.Age == 2300) { }
            else if (temp.Age == 2400) { }
            else if (temp.Age == 2500) { }
            else if (temp.Age == 2600) { }
            else if (temp.Age == 2700) { }
            else if (temp.Age == 2800) { }
            else if (temp.Age == 2900) { }
            else if (temp.Age == 3000) { }
            else if (temp.Age == 3100) { }
            else if (temp.Age == 3200) { }
            else if (temp.Age == 3300) { }
            else if (temp.Age == 3400) { }
            else if (temp.Age == 3500) { }
            else if (temp.Age == 3600) { }
            else if (temp.Age == 3700) { }
            else if (temp.Age == 3800) { }
            else if (temp.Age == 3900) { }
            else if (temp.Age == 4000) { }
            else if (temp.Age == 4100) { }
            else if (temp.Age == 4200) { }
            else if (temp.Age == 4300) { }
            else if (temp.Age == 4400) { }
            else if (temp.Age == 4500) { }
            else if (temp.Age == 4600) { }
            else if (temp.Age == 4700) { }
            else if (temp.Age == 4800) { }
            else if (temp.Age == 4900) { }
            else if (temp.Age == 5000) { }
            else if (temp.Age == 5100) { }
            else if (temp.Age == 5200) { }
            else if (temp.Age == 5300) { }
            else if (temp.Age == 5400) { }
            else if (temp.Age == 5500) { }
            else if (temp.Age == 5600) { }
            else if (temp.Age == 5700) { }
            else if (temp.Age == 5800) { }
            else if (temp.Age == 5900) { }
            else if (temp.Age == 6000) { }
            else if (temp.Age == 6100) { }
            else if (temp.Age == 6200) { }
            else if (temp.Age == 6300) { }
            else if (temp.Age == 6400) { }
            else if (temp.Age == 6500) { }
            else if (temp.Age == 6600) { }
            else if (temp.Age == 6700) { }
            else if (temp.Age == 6800) { }
            else if (temp.Age == 6900) { }
            else if (temp.Age == 7000) { }
            else if (temp.Age == 7100) { }
            else if (temp.Age == 7200) { }
            else if (temp.Age == 7300) { }
            else if (temp.Age == 7400) { }
            else if (temp.Age == 7500) { }
            else if (temp.Age == 7600) { }
            else if (temp.Age == 7700) { }
            else if (temp.Age == 7800) { }
            else if (temp.Age == 7900) { }
            else if (temp.Age == 8000) { }
            else if (temp.Age == 8100) { }
            else if (temp.Age == 8200) { }
            else if (temp.Age == 8300) { }
            else if (temp.Age == 8400) { }
            else if (temp.Age == 8500) { }
            else if (temp.Age == 8600) { }
            else if (temp.Age == 8700) { }
            else if (temp.Age == 8800) { }
            else if (temp.Age == 8900) { }
            else if (temp.Age == 9000) { }
            else if (temp.Age == 9100) { }
            else if (temp.Age == 9200) { }
            else if (temp.Age == 9300) { }
            else if (temp.Age == 9400) { }
            else if (temp.Age == 9500) { }
            else if (temp.Age == 9600) { }
            else if (temp.Age == 9700) { }
            else if (temp.Age == 9800) { }
            else if (temp.Age == 9900) { }
            else if (temp.Age == 10000) { }
            else { }
        }

        [Benchmark]
        public void Switch()
        {
            Person temp = new Person
            {
                Name = "Vighnesh",
                Age = 3600
            };

            switch (temp.Age)
            {
                case 100: break;
                case 200: break;
                case 300: break;
                case 400: break;
                case 500: break;
                case 600: break;
                case 700: break;
                case 800: break;
                case 900: break;
                case 1000: break;
                case 1100: break;
                case 1200: break;
                case 1300: break;
                case 1400: break;
                case 1500: break;
                case 1600: break;
                case 1700: break;
                case 1800: break;
                case 1900: break;
                case 2000: break;
                case 2100: break;
                case 2200: break;
                case 2300: break;
                case 2400: break;
                case 2500: break;
                case 2600: break;
                case 2700: break;
                case 2800: break;
                case 2900: break;
                case 3000: break;
                case 3100: break;
                case 3200: break;
                case 3300: break;
                case 3400: break;
                case 3500: break;
                case 3600: break;
                case 3700: break;
                case 3800: break;
                case 3900: break;
                case 4000: break;
                case 4100: break;
                case 4200: break;
                case 4300: break;
                case 4400: break;
                case 4500: break;
                case 4600: break;
                case 4700: break;
                case 4800: break;
                case 4900: break;
                case 5000: break;
                case 5100: break;
                case 5200: break;
                case 5300: break;
                case 5400: break;
                case 5500: break;
                case 5600: break;
                case 5700: break;
                case 5800: break;
                case 5900: break;
                case 6000: break;
                case 6100: break;
                case 6200: break;
                case 6300: break;
                case 6400: break;
                case 6500: break;
                case 6600: break;
                case 6700: break;
                case 6800: break;
                case 6900: break;
                case 7000: break;
                case 7100: break;
                case 7200: break;
                case 7300: break;
                case 7400: break;
                case 7500: break;
                case 7600: break;
                case 7700: break;
                case 7800: break;
                case 7900: break;
                case 8000: break;
                case 8100: break;
                case 8200: break;
                case 8300: break;
                case 8400: break;
                case 8500: break;
                case 8600: break;
                case 8700: break;
                case 8800: break;
                case 8900: break;
                case 9000: break;
                case 9100: break;
                case 9200: break;
                case 9300: break;
                case 9400: break;
                case 9500: break;
                case 9600: break;
                case 9700: break;
                case 9800: break;
                case 9900: break;
                case 10000: break;
                default: break;
            }
        }
    }
}