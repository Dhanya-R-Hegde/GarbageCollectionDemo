namespace GarbageCollectionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Calculator Object is now on " + GC.GetGeneration(calculator) + "Generation");
            Console.WriteLine("Garbage Collection occured in 0th generation " + GC.CollectionCount(0));
            Console.WriteLine("Garbage Collection occured in 1st generation " + GC.CollectionCount(1));
            Console.WriteLine("Garbage Collection occured in 2nd generation " + GC.CollectionCount(2));
            GC.Collect(0);
            Console.WriteLine("Garbage Collection occured in 0th generation " + GC.CollectionCount(0));
            GC.Collect(1);
            Console.WriteLine("Garbage Collection occured in 1st generation " + GC.CollectionCount(1));
            Console.WriteLine("Generation Count is : " + GC.MaxGeneration);
        }
    }
}
