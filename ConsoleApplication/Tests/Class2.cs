using System;
using System.Collections;
using NUnit.Framework;

namespace ConsoleApplication.Tests{
    [TestFixture]
    public class Class2{
        [Test]
        public void test(){ 
            ICandy saltCandy = new SaltCandy();
            ICandy caramelCandy = new CaramelCandy();
            
            Action<ICandy, ICandy> delegAction;
            delegAction = saltC;
            compare(saltCandy, caramelCandy, delegAction);

            Func<ICandy, ICandy, ArrayList> sort = sortCandy;
            sort(caramelCandy, saltCandy);

        }
        
        static void compare(ICandy x, ICandy y, Action<ICandy, ICandy> delegAction){
             if (x.GetCandyType().Length > y.GetCandyType().Length)
                 delegAction(x, y);
        }
       
        static void saltC(ICandy x, ICandy y){
            Console.WriteLine("x > y");
        }

        static ArrayList sortCandy(ICandy x, ICandy y){
            ArrayList arrayList = new ArrayList();
            arrayList.Add(x);
            arrayList.Add(y);
            return arrayList;
        }
    }
}