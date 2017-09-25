using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication.serializable{
    public class BinSer: Ser{
        public void IBinarySerialize(FileStream fs, SaltCandy[] ar){
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ar);
        }
    }
}