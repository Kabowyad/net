using System;
using System.Collections;
using System.Threading;
using log4net;
using NUnit.Framework;

namespace ConsoleApplication.Tests{
    [TestFixture]
    public class Class2{
        private ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected static ArrayList multiArrayList;
        
        delegate ArrayList delegateSort(ICandy x, ICandy y);
        
        [Test]
        public void test(){ 
            log.Debug("hello");
            SaltCandy saltCandy = new SaltCandy();
            SaltCandy caramelCandy = new SaltCandy();

            Action<SaltCandy, SaltCandy> delegAction = saltC;
            compare(saltCandy, caramelCandy, delegAction);

            Func<ICandy, ICandy, ArrayList> sort = sortCandy;
            sort(caramelCandy, saltCandy);

            delegateSort del = delegateSortCandy;

            IAsyncResult resultObj = del.BeginInvoke(saltCandy, caramelCandy, null, null); // работа test не приостанавливается, sort происходит в другом потоке через делегат
            del.EndInvoke(resultObj);
            
            del.Invoke(saltCandy, caramelCandy);
        }

        [Test]
        public void another_test(){
           
            Action<SaltCandy, SaltCandy> sortAction = delegate(SaltCandy candy, SaltCandy saltCandy){
                Console.WriteLine("EverythinGood");
              };
            
            SaltCandy saltCandy1 = new SaltCandy();
            SaltCandy saltCandy2 = new SaltCandy();
            sortAction(saltCandy1, saltCandy2);

        }
        
        static void compare(SaltCandy x, SaltCandy y, Action<SaltCandy, SaltCandy> delegAction){
             if (x.GetCandyType().Length > y.GetCandyType().Length)
                 delegAction(x, y);
        }
       
        static void saltC(SaltCandy x, SaltCandy y){
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
        
        static object locker = new object();

        static void threads(){
            for (int i = 0; i < 2; i++){
                Thread mThread = new Thread(doAction);
            }
        }

        static void doAction(){
            lock (locker){
                multiArrayList.Sort();
            }
        }
    }
}