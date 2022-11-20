using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLUtility
{
    internal class DOMTraversal : ISelectionStrategy
    {
        private const int personLevel = 1;
        private string separatorBetweenRecords = new string('-', 63);
        public string FetchCurrentValues(string XMLFilepath, 
            HashSet<string> filters) 
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(XMLFilepath);
            return TraverseNodes(xmlDoc, filters);
        }
        private string TraverseNodes(XmlDocument xmlDoc, HashSet<string> filters)
        {
            var sb = new StringBuilder();
            const int level = 0;
            TraverseRecusively(xmlDoc.DocumentElement, level, filters, sb);
            return sb.ToString();
        }
        private void TraverseRecusively(XmlNode node, int level, 
            HashSet<string> filters, StringBuilder sb)
        {
            foreach (XmlAttribute attribute in node.Attributes)
            {
                if (filters.Contains(attribute.Name))
                {
                    sb.AppendLine(
                        string.Format("{0}: {1}",
                attribute.Name, attribute.Value));
                }
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                TraverseRecusively(childNode, level + 1, filters, sb);
            }
            if (level == personLevel)
                sb.AppendLine(separatorBetweenRecords);
        }
    }
}
