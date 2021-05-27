namespace practice1
{

    class Program
    {
        static void Main(string[] args)
        {
            var raman = new Person();
            raman.Name("Raman");
            raman.Age(23);

            System.Console.WriteLine();
            var karan = new Person();
            karan.Name("Karan");
            karan.Age(21);

            System.Console.WriteLine();

            raman.Legs(2);
        }
    }
}
