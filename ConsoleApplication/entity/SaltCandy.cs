using System;

namespace ConsoleApplication{
    [Serializable]
    public class SaltCandy : ICandy{
        private string type;

        public SaltCandy(){
            this.type = "Salt";
        }

        public string GetCandyType(){
            return type;
        }
    }
}