using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLUtility
{
    internal class SAXTraversal : ISelectionStrategy
    {
        public string FetchCurrentValues(string XMLFilepath,
            HashSet<string> filters)
        {
            var xmlReader = new XmlTextReader(XMLFilepath);
            var sb = new StringBuilder();
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        sb.AppendLine(string.Format(
                            "{0}:{1}",xmlReader.Name, xmlReader.Value));
                    }
                }
            }
            return sb.ToString();
        }
    }
}
