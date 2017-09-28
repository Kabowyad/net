using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication.serializable{
    public class BinSer: Ser{
        public void IBinarySerialize(FileStream fs, SaltCandy[] ar){
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ar);
        }

        public void IXmlSerialize(FileStream fs, SaltCandy candy){
            return;
        }

        public void IJsonSerialize(ICandy candy){
            return;
        }

        public void IBinaryDeserialize(FileStream fs){
            BinaryFormatter formatter = new BinaryFormatter();
            ICandy candy = (SaltCandy) formatter.Deserialize(fs);
        }

        public void IXmlDeserialize(FileStream fs, SaltCandy candy){
            return;
        }

        public void IJsonDeserialize(string json){
            return;
        }
    }
}