namespace ConsoleApplication {
    
    public class CaramelCandy : ICandy{
        private string type;
        
        public string GetCandyType(){
            return type;
        }

        public CaramelCandy(){
            type = "Caramel";
        }

        public void setType(){
            type = "Candy";
        }
    }
}