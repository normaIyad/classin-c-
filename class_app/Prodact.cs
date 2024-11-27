namespace class_app
{
    internal class Prodact
    {
        public int id;
        public string name;
        public string description;
        public float price;
        public void print()
        {
            Console.WriteLine($"prodact name : {name} prodact description : {description} price : {price}");
        }
    }
}
