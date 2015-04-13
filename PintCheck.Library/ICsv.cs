using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintCheck.Library
{
    public interface ICsv
    {
        string CsvHeader { get; }

        string ToString();
    }
}
