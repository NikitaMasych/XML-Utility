using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLUtility
{
    public interface ISelectionStrategy
    {
        string FetchCurrentValues(string XMLFilePath, HashSet<string> filters);
    }
}
