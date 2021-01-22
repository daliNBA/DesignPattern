using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private readonly SubSystem1 _sys1;
        private readonly SubSystem2 _sys2;

        public Facade(SubSystem1 sys1, SubSystem2 sys2)
        {
            _sys1 = sys1;
            _sys2 = sys2;
        }

        public string Operation()
        {
            return $"voila mes ops systemes 1 {_sys1.Operation1()} et {_sys1.OperationN()} et voila mes ops systemes 2 {_sys2.Operation2()} et {_sys2.OperationM()}";
        }
    }
}
