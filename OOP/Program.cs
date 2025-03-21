namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Amelie";
            p.age = 5;
            p.email = "amelie@cat.com";

            Console.WriteLine("p name: " + p.name);
            Console.WriteLine("p age: " + p.age);
            Console.WriteLine("p email: " + p.email);
            Console.WriteLine("\n");

            Person p1 = new Person();

            p1.name = "Mimosinha";
            p1.age = 2;
            p1.email = "mimosinha@cat.com";

            Console.WriteLine("p1 name: " + p1.name);
            Console.WriteLine("p1 age: " + p1.age);
            Console.WriteLine("p1 email: " + p1.email);
            Console.WriteLine("\n");

            Person p2 = new Person();

            Console.WriteLine("Name: ");
            p2.name = Console.ReadLine();
            Console.WriteLine("Age: ");
            p2.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            p2.email = Console.ReadLine();

            Console.WriteLine("\np2 name: " + p2.name);
            Console.WriteLine("p2 age: " + p2.age);
            Console.WriteLine("p2 email: " + p2.email);
            Console.WriteLine("\n");

            Car c = new Car();
            Car c1 = new Car();

            Console.WriteLine("c manufacturer: ");
            c.manufacturer = Console.ReadLine();
            Console.WriteLine("c model: ");
            c.model = Console.ReadLine();
            Console.WriteLine("c year: ");
            c.year = int.Parse(Console.ReadLine());

            Console.WriteLine("c1 manufacturer: ");
            c1.manufacturer = Console.ReadLine();
            Console.WriteLine("c1 model: ");
            c1.model = Console.ReadLine();
            Console.WriteLine("c1 year: ");
            c1.year = int.Parse(Console.ReadLine());

            Console.WriteLine("\nc manufacturer: " + c.manufacturer);
            Console.WriteLine("c model: " + c.model);
            Console.WriteLine("c year: " + c.year);

            Console.WriteLine("\nc1 manufacturer: " + c1.manufacturer);
            Console.WriteLine("c1 model: " + c1.model);
            Console.WriteLine("c1 year: " + c1.year);

            Book b = new Book();

            Console.WriteLine("b title: ");
            b.title = Console.ReadLine();
            Console.WriteLine("b author: ");
            b.author = Console.ReadLine();
            Console.WriteLine("b year: ");
            b.year = int.Parse(Console.ReadLine());

            Console.WriteLine("\nb title: " + b.title);
            Console.WriteLine("b author: " + b.author);
            Console.WriteLine("b year: " + b.year);
        }
    }
}