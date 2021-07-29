using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    class LoadVerifiier : ILoadVerifier
    {
        public async Task<bool> verifyAsync()
        {
            //call load varify service
            await Task.Delay(5 * 1000);
            return true;
        }
    }
}
