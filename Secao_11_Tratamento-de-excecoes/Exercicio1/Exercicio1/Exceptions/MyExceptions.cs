using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Exceptions
{
    class MyExceptions:ApplicationException
    {
        public MyExceptions(string message) : base(message)
        {

        }
    }
}
