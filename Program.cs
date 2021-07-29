using System;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifiier();
            var assigner = new NewLoadAssigner();

            var startTime = DateTime.Now;

            var diverTask =  driver.ReportBackToOfficeAsync();
            var varifierTask =  verifier.verifyAsync();

            Task.WaitAll(diverTask, varifierTask);

            var assignerTask = assigner.assignAsync();

            if (varifierTask.Result == true)
                await assigner.assignAsync();



            

            Console.WriteLine($"Total time taken:{DateTime.Now.Subtract(startTime).TotalSeconds}");
        }
    }
}
