using System.Diagnostics.Metrics;
using System.IO;

namespace between
{
    internal class Program
    {
        List<int> data = new();
            

        static void Main(string[] args)
        {
            bool eslo = false;
            bool masodik;
            List<int> data = new();
            data.Add(101);
            data.Add(102);
            data.Add(103);
            data.Add(115);
            data.Add(201);
            data.Add(202);
            data.Add(219);
            data.Add(106);
            data.Add(115);

            List<int> helper = new();

            foreach (int item in data)
            {
                int test = (item + 1) - item;
                Console.WriteLine(test);
                Console.WriteLine(item);
            }

            

            foreach (int item in data)
            {
                bool a = item.IsBetween(101, 115);
                double avg = 0;
                double avg2 = 0;
                
                bool b = item.IsBetween(101, 115);
                if (b)
                {

                    Console.WriteLine(item + " elso");
                    
                    helper.Add(item);
                    if (item == 115)
                    {
                        Console.WriteLine(AveragePart(helper));
                        helper.Clear();
                    }


                }
                bool c = item.IsBetween(201, 219);
                if (c)
                {
                    Console.WriteLine(item + " masodik");

                    helper.Add(item);
                    if (item == 219)
                    {

                        Console.WriteLine(AveragePart(helper));
                        helper.Clear();
                    }
                }

            }
             static double AveragePart(List<int> list)
            {
                int sum = 0;
                if (list.Any())
                    foreach (int number in list)
                        sum += number;

                return (double)sum / list.Count;
            }

        }

    }
}