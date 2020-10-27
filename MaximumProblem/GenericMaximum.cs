using System;
using System.Collections.Generic;
using System.Text;
namespace MaximumProblem
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] array;
        public GenericMaximum(T[] array)
        {
            this.array = array;
        }
        public T[] Sort(T[] sortedArray)
        {
            Array.Sort(sortedArray);
            return sortedArray;
        }
        void add (params int[] a)
        {

        }
       public T MaximumValue(params T[] values)
        {
            T[] sortedArray = Sort(this.array);
            return sortedArray[sortedArray.Length - 1];
        }
        public void DisplayMax()
        {
            T[] sortedArray = Sort(this.array);
            Console.WriteLine(sortedArray[sortedArray.Length-1]);
        }
    }
}
