using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HM84
{
    public class XmlFileHandler
    {
        private readonly string _fileName;

        public XmlFileHandler(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteXml(Note note)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Note));
            using (TextWriter writer = new StreamWriter(_fileName))
            {
                serializer.Serialize(writer, note);
            }
        }

        public Note ReadXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Note));
            using (TextReader reader = new StreamReader(_fileName))
            {
                return (Note)serializer.Deserialize(reader);
            }
        }


    }
}
