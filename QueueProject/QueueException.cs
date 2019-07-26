using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    class QueueException : Exception
    {
        public QueueException()
            :base("An Unknown Exception Has Occured.")
        {

        }
        public QueueException(string str)
            :base(str)
        {

        }
    }
}
