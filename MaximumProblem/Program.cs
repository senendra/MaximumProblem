using System;
namespace MaximumProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Problem Program");
            int[] intArray = { 11, 22, 33, 44, 55 };
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            float[] floatArray = { 11.1f, 22.2f, 33.3f, 44.4f, 55.5f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            string[] stringArray = { "Apple", "Peace", "Banana", "Lemon", "Orange" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericInt.DisplayMax();
            genericFloat.DisplayMax();
            genericString.DisplayMax();
        }
    }
}
