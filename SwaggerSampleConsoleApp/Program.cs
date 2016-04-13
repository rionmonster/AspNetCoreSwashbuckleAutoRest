using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Values;

namespace SwaggerSampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Let me know when the server's ready");
                Console.ReadLine();

                var valuesClient = new ValuesClient(
                    /* this way you can deploy somewhere 
                     * and tell the client how to find it
                     * and not have to change ur codez
                     */
                    new Uri("http://localhost:62611/") 
                    );
                var results = valuesClient.GetValues();

                foreach (var value in results)
                {
                    Console.WriteLine(value);
                }
            }
            catch(Exception x)
            {
                Console.WriteLine(x);
                Debugger.Break();
            }

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
