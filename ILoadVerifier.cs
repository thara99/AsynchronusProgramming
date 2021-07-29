using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    interface ILoadVerifier
    {

        public Task<bool> verifyAsync();

    }
}
