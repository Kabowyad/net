using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication.generic{
    public class CandyCollection<T>: ICollection<T> where T : ICandy{
        //inner ArrayList object
        protected ArrayList _innerArray;
        
        //flag for setting collection to read-only
        //mode (not used in this example)
        protected bool _IsReadOnly;
        
        // Default constructor
        public CandyCollection()
        {
            _innerArray = new ArrayList();
        }

        // Default accessor for the collection 
        public virtual T this[int index]
        {
            get
            {
                return (T)_innerArray[index];
            }
            set
            {
                _innerArray[index] = value;
            }
        }

        // Number of elements in the collection
        public virtual int Count
        {
            get
            {
                return _innerArray.Count;
            }
        }

        // Flag sets whether or not this collection is read-only
        public virtual bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
        }
        
        // Add a business object to the collection
        public virtual void Add(T Candy)
        {
            _innerArray.Add(Candy);
        }

        // Remove first instance of a business object from the collection 
        public virtual bool Remove(T Candy) 
        {
            bool result = false;

            //loop through the inner array's indices
            for (int i = 0; i < _innerArray.Count; i++)
            {
                //store current index being checked
                T obj = (T)_innerArray[i];

                //compare the BusinessObjectBase UniqueId property
                if (obj.UniqueId == Candy.UniqueId)
                {
                    //remove item from inner ArrayList at index i
                    _innerArray.RemoveAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }
        
        // Returns true/false based on whether or not it finds
        // the requested object in the collection.
        public bool Contains(T Candy)
        {
            //loop through the inner ArrayList
            foreach (T obj in _innerArray)
            {
                //compare the BusinessObjectBase UniqueId property
                if (obj.UniqueId == Candy.UniqueId)
                {
                    //if it matches return true
                    return true;
                }
            }
            //no match
            return false;
        }
        
        // Copy objects from this collection into another array
        public virtual void CopyTo(T[] Candy, int index)
        {
            throw new Exception(
                "This Method is not valid for this implementation.");
        }

        // Clear the collection of all it's elements
        public virtual void Clear()
        {
            _innerArray.Clear();
        }

        // Returns custom generic enumerator for this BusinessObjectCollection
        public virtual IEnumerator<T> GetEnumerator()
        {
            //return a custom enumerator object instantiated
            //to use this CandyCollection 
            return new CandyEnumerator<T>(this);
        }

        // Explicit non-generic interface implementation for IEnumerable
        // extended and required by ICollection (implemented by ICollection<T>)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CandyEnumerator<T>(this);
        }
    }
}