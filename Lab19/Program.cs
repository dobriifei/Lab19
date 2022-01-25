using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Model> models = new List<Model>()
            {
                new Model(){Kod=1, Name="Defender15", Type="Intel", Rate=2.1, MemorySize="6Gb", VolumeDisc="120Gb", Price=1200, Number=45 },
                new Model(){Kod=2, Name="Defender150", Type="AMD", Rate=3.2, MemorySize="8Gb", VolumeDisc="500Gb", Price=1700, Number=10},
                new Model(){Kod=3, Name="Defender123", Type="AMD", Rate=2.7, MemorySize="6Gb", VolumeDisc="120Gb", Price=1400, Number=12},
                new Model(){Kod=4, Name="Defender", Type="Intel", Rate=2.1, MemorySize="16Gb", VolumeDisc="120Gb", Price=1600, Number=4},
                new Model(){Kod=5, Name="Defender", Type="AMD", Rate=3.5, MemorySize="4Gb", VolumeDisc="120Gb", Price=1800, Number=3},
                new Model(){Kod=6, Name="Defender", Type="Intel", Rate=2.1, MemorySize="6Gb", VolumeDisc="120Gb", Price=1400, Number=15},
            };

            Console.WriteLine("Введите тип процессора");
            string type = Console.ReadLine();
            List<Model> models1 = models.Where(x => x.Type == type).ToList();
            Print(models1);

            Console.WriteLine("Введите объем озу");
            double rate = Convert.ToDouble(Console.ReadLine());
            List<Model> models2 = models.Where(x => x.Rate >= rate).ToList();
            Print(models2);

            List<Model> models3 = models.OrderBy(x => x.Price).ToList();
            Print(models3);

            IEnumerable<IGrouping<string, Model>> models4 = models.GroupBy(x => x.Type);
            foreach (IGrouping<string, Model> gr in models4)
            {
                Console.WriteLine(gr.Key);
                foreach (Model m in gr)
                {
                    Console.WriteLine($"{m.Kod} {m.Name} {m.Type} {m.Rate} {m.MemorySize} {m.VolumeDisc} {m.Price} {m.Number}");
                }
            }

            Model models5 = models.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{models5.Kod} {models5.Name} {models5.Type} {models5.Rate} {models5.MemorySize} {models5.VolumeDisc} {models5.Price} {models5.Number}");
            Model models6 = models.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{models6.Kod} {models6.Name} {models6.Type} {models6.Rate} {models6.MemorySize} {models6.VolumeDisc} {models6.Price} {models6.Number}");

            Console.WriteLine(models.Any(x => x.Number > 30));

            Console.ReadKey();
        }
        static void Print(List<Model> models)
        {
            foreach (Model m in models)
            {
                Console.WriteLine($"{m.Kod} {m.Name} {m.Type} {m.Rate} {m.MemorySize} {m.VolumeDisc} {m.Price} {m.Number}");
            }
            Console.WriteLine();
        }
    }
}
