using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Common.Utility
{
    public static class SerializeUtility<T>
    {
        public static string XmlSerialize<T>(T obj)
        {
            var xmlString = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (TextWriter textWriter = new StringWriter(xmlString))
            {
                xmlSerializer.Serialize(textWriter, obj);
            }

            return xmlString.ToString();
        }

        public static T XmlDeserialize(string xmlString)
        {
            T obj;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader textReader = new StringReader(xmlString))
            {

                obj = (T)xmlSerializer.Deserialize(textReader);
            }

            return obj;
        }
    }
}
