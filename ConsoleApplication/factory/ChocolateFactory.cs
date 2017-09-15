namespace ConsoleApplication.factory{
    public class ChocolateFactory: AbstractFactory{
        public override ICandy GetCaramelCandy(){
            return null;
        }

        public override ICandy GetSaltCandy(){
           return null;
        }

        public override ICandy GetChocolateCandy(){
            ICandy iCandy = new ChocolateCandy();
            return iCandy;
        }
    }
}