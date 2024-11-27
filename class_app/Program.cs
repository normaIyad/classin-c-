namespace class_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Prodact prodact1 = new Prodact();
            prodact1.name = "car";
            prodact1.price = 10000;
            prodact1.id = 100;
            prodact1.description = "Description pla pla pla pla";
            prodact1.print();
        }
    }
}
