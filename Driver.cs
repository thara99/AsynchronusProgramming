using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    class Driver : IDriver
    {
        public async Task ReportBackToOfficeAsync()
        {
            //set break time
            await Task.Delay(5 * 1000);
        }
    }
}
