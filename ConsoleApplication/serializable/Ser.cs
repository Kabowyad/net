using System;
using System.IO;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication.serializable{
    public interface Ser{
        void IBinarySerialize(FileStream fs,SaltCandy[] ar);
        void IXmlSerialize(FileStream fs, SaltCandy candy);
        void IJsonSerialize(ICandy candy);

        void IBinaryDeserialize(FileStream fs);
        void IXmlDeserialize(FileStream fs, SaltCandy candy);
        void IJsonDeserialize(String json);
    }
}