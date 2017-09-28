using System;
using System.Collections;
using NUnit.Framework;

namespace ConsoleApplication.Tests{
    [TestFixture]
    public class Class2{

        delegate ArrayList delegateSort(ICandy x, ICandy y);
        
        [Test]
        public void test(){ 
            ICandy saltCandy = new SaltCandy();
            ICandy caramelCandy = new CaramelCandy();
            
            Action<ICandy, ICandy> delegAction;
            delegAction = saltC;
            compare(saltCandy, caramelCandy, delegAction);

            Func<ICandy, ICandy, ArrayList> sort = sortCandy;
            sort(caramelCandy, saltCandy);

            delegateSort del = new delegateSort(delegateSortCandy);
            ArrayList result = del.Invoke(saltCandy, caramelCandy);
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

        static ArrayList delegateSortCandy(ICandy x, ICandy y){
            ArrayList arrayList = new ArrayList();
            arrayList.Add(x);
            arrayList.Add(y);
            return arrayList;
        }
        
    }
}