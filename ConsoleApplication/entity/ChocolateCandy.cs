namespace ConsoleApplication{
    public class ChocolateCandy:ICandy{
        private string type;

        public ChocolateCandy(){
            this.type = "Chocolate";
        }

        public string GetCandyType(){
            return type;
        }
    }
}