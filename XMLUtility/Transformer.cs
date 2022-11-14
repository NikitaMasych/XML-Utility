using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace XMLUtility
{
    internal class Transformer
    {
        public static HashSet<string> WasTransformed = new HashSet<string>();
        public static void Transform(string xmlFilePath, 
            string xslFilePath, string htmlFilePath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xslFilePath);
            xslt.Transform(xmlFilePath, htmlFilePath);
            WasTransformed.Add(xmlFilePath);
        }
    }
}
