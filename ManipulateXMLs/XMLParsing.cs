using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ManipulateXMLs
{
    class XMLParsing
    {
        public static string DateParsing(FileInfo enterdoc)
        {

            XmlReader xmlReader = XmlReader.Create(enterdoc.FullName);
            while (xmlReader.Read())
            {
                string result = "";
                if (xmlReader.ReadToDescendant("dhEmi"))
                {
                    xmlReader.Read();
                    result = xmlReader.Value;
                    return result;
                }
            }
            return "";
        }
    }
}
