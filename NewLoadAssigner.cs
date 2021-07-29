using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    class NewLoadAssigner : INewLoadAssigner
    {
        public async Task assignAsync()
        {
            //assign new load
            await Task.Delay(5 * 1000);
        }
    }
}
