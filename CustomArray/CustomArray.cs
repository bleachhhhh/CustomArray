using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomArray
{
	public class CustomArray:IEnumerable<int>
	{
        private int _lenght;
        private int[] _elements;
        public int Length
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _lenght = value;
            }
        }
        public int this[int index]
        {
            get => _elements[index];
            set => _elements[index] = value;
        }
       
        public CustomArray(int elementCount)
        {
            Length = elementCount;
            _elements=new int[Length];
        }
        public IEnumerator GetEnumerator()
        {
            return _elements.GetEnumerator();
        }
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return ((IEnumerable<int>)_elements).GetEnumerator();
        }

        public void SetRandomValues()
        {
            Random r = new Random();
            for (int i = 0; i < this.Length; i++)
            {
                this[i] = r.Next(1, 100);
            }
        }
    }
}
