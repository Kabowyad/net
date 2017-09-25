using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication.serializable{
    public class XmlSer: Ser{
        public void IBinarySerialize(FileStream fs, SaltCandy[] ar){
            return;
        }

        public void IXmlSerialize(FileStream fs, SaltCandy candy){
            XmlSerializer formatter = new XmlSerializer(typeof(ICandy));
            formatter.Serialize(fs, candy);
        }

        public void IJsonSerialize(ICandy candy){
            return;
        }
    }
}