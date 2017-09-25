using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication {
   public abstract class  ICandy: ICloneable, IEnumerable<ICandy>{
      private string type;
      List<ICandy> mylist = new List<ICandy>();
      protected Guid? _UniqueId;
      
      //Default constructor
      protected ICandy()
      {
         //create a new unique id for this business object
         _UniqueId = Guid.NewGuid();
      }
      
      public ICandy this[int index]  
      {  
         get => mylist[index];
         set => mylist.Insert(index, value);
      } 
      
      //UniqueId property for every business object
      public Guid? UniqueId
      {
         get => _UniqueId;
         set => _UniqueId = value;
      }

      public String GetCandyType(){
         return type;
      }

      public object Clone(){
         ICandy iCandy = (ICandy) this.MemberwiseClone();
         return iCandy;
      }

      public IEnumerator<ICandy> GetEnumerator(){
         return mylist.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator(){
         return this.GetEnumerator();
      }
   }
    
}