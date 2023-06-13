using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaitFinish.Common
{
    public class TestedClass
    {
        private const int DEFAULT_DELAY = 2000;
        public async Task DoSomething(int? delay = DEFAULT_DELAY)
        {
            await Task.Delay(delay);
        }
    }
}