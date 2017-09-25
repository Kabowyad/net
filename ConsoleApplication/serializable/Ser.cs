using System.IO;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication.serializable{
    public interface Ser{
        void IBinarySerialize(FileStream fs,SaltCandy[] ar);
        void IXmlSerialize(FileStream fs, SaltCandy candy);
        void IJsonSerialize(ICandy candy);
    }
}