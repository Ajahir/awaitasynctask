using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace awaitasynctask
{
    class Program
    {
        static void Main(string[] args)
        {
            dowork();
            work();  

            record records = new record();
            records.doworks().Wait();

            Console.ReadKey();

        }

        private static async void work()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <5; i++)
                {
                    Thread.Sleep(3000);     
                    Console.WriteLine("\ncr7 has scored 804");

                    Task.Delay(1000).Wait();
                }

            });

        }

        private static void dowork()
        {

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("\n messi has scored 759");

                Task.Delay(1000).Wait();
            }
        }

        private class record
        {
            public async Task doworks()
            {
                int a = await add(759);
                return;
            }

            private async Task<int> add(int v)
            {
                return await Task.Run(() =>
                {

                    Thread.Sleep(1000);
                    Console.WriteLine("\n\n total goal of both ");
                    Console.Write("\n\n" + (v + 804) + "\n\n");
                    return v + 804;

                });
            }
        }
    }
}
