using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication.serializable{
    public class JsonSer: Ser{
        public void IBinarySerialize(FileStream fs, SaltCandy[] ar){
            return;
        }

        public void IXmlSerialize(FileStream fs, SaltCandy candy){
            return;
        }

        public void IJsonSerialize(ICandy candy){
            string json = JsonConvert.SerializeObject(candy);
        }

        public void IBinaryDeserialize(FileStream fs){
            return;
        }

        public void IXmlDeserialize(FileStream fs, SaltCandy candy){
            return;
        }

        public void IJsonDeserialize(string json){
            SaltCandy candy = JsonConvert.DeserializeObject<SaltCandy>(json);
        }
    }
}