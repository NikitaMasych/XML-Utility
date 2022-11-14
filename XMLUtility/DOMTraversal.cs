using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLUtility
{
    internal class DOMTraversal
    {
        public static List<XmlNode> FetchAttributes(string XMLFilepath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(XMLFilepath);
            var xmlNodes = TraverseNodes(xmlDoc);
            return xmlNodes;
        }
        private static List<XmlNode> TraverseNodes(XmlDocument xmlDoc)
        {
            var xmlNodes = new List<XmlNode>();
            const int level = 0;
            TraverseRecusively(xmlDoc.DocumentElement, level, xmlNodes);
            return xmlNodes;
        }
        private static void TraverseRecusively(XmlNode node, 
            int level, List<XmlNode> xmlNodes)
        {
            xmlNodes.Add(node); 
        }
    }
}
