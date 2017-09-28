using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication.serializable{
    public class Xml: Ser{
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

        public void IBinaryDeserialize(FileStream fs){
            return;
        }

        public void IXmlDeserialize(FileStream fs, SaltCandy candy){
            XmlSerializer formatter = new XmlSerializer(typeof(ICandy));
            ICandy candyOut = (SaltCandy) formatter.Deserialize(fs);
        }

        public void IJsonDeserialize(string json){
            return;
        }
    }
}