using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare.DataGram
{
    [Serializable]
    public class DataGram<T>
    {
        public string cmd;
        public T data;
    }
}
