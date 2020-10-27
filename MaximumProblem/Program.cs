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
            Console.WriteLine(genericInt.MaximumValue());
            float[] floatArray = { 11.1f, 22.2f, 33.3f, 44f, 55f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            Console.WriteLine(genericFloat.MaximumValue());
            string[] stringArray = { "Apple", "Peace", "Banana", "Lemon", "Orange" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine(genericString.MaximumValue());
        }
    }
}
