namespace ConsoleApplication.factory{
    public class SaltFactory : AbstractFactory{
        public override ICandy GetCaramelCandy(){
            return null;
        }

        public override ICandy GetSaltCandy(){
            ICandy iCandy = new SaltCandy();
            return iCandy;
        }

        public override ICandy GetChocolateCandy(){
            return null;
        }
    }
}