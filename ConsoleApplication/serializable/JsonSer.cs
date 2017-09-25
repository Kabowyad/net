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
    }
}