namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            float[] numbers = ArrayCreator.Create(50, 3f);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}