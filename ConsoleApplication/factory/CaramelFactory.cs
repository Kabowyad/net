namespace ConsoleApplication.factory{
    
    public class CaramelFactory : AbstractFactory{
        public Candy CreateCandy(){
            return new CaramelCandy();
        }
    }
}