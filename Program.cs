namespace LV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Zad1Test();
           //Zad3Test();
           //Zad4Test();           
           //Zad5Test();
           //Zad6Test();
           Zad7Test();
           
        }

        static void Zad1Test()
        {
            Product product1 = new Product("Product1", 10, 5);
            Product product2 = new Product("Product2", 20, 10);
            Product product3 = new Product("Product3", 30, 15);
            Product product4 = new Product("Product4", 40, 20);

            Box box1 = new Box("Box1");
            box1.Add(product1);        
            
            Box box2 = new Box("Box2");
            box1.Add(box2);            
            box2.Add(product2);
            box2.Add(product3);

            box1.Add(product4);
            double totalPrice1 = box1.Price;
            double totalPrice2 = box2.Price;
            Console.WriteLine($"Box1 Total Price {totalPrice1}\nBox2 Total Price {totalPrice2}");

            Console.WriteLine(box1.Description());

            Zad2Test(product1);
            Zad2Test(box1);
        }

        static void Zad2Test(IShipable shipable)
        {
            ShippingService shippingService = new ShippingService();
            double price = shippingService.CalculatePrice(shipable);
            Console.WriteLine($"Shipping Price: {price}");

        }

        static void Zad3Test()
        {
            DataConsolePrinter printer = new DataConsolePrinter();
            Dataset dataset = new Dataset("D:\\Faks\\2. Godina\\RPPOON\\LV\\New folder\\LV5\\ProxyData.csv");
            VirtualProxyDataset proxy = new VirtualProxyDataset("D:\\Faks\\2. Godina\\RPPOON\\LV\\New folder\\LV5\\ProxyData.csv");
            User user1 = User.GenerateUser("Ivan");
            User user2 = User.GenerateUser("Marko");
            ProtectionProxyDataset protectionProxy1 = new ProtectionProxyDataset(user1);
            ProtectionProxyDataset protectionProxy2 = new ProtectionProxyDataset(user2);

            Console.WriteLine("Dataset");
            printer.PrintDataset(dataset);
            Console.WriteLine("VitualProxyDataset");
            printer.PrintDataset(proxy);

            Console.WriteLine("ProtectionProxyDataset1");
            printer.PrintDataset(protectionProxy1);
            Console.WriteLine("ProtectionProxyDataset2");
            printer.PrintDataset(protectionProxy2);

        }

        static void Zad4Test()
        {
            LoginProxyDataset dataset = new LoginProxyDataset("D:\\Faks\\2. Godina\\RPPOON\\LV\\New folder\\LV5\\ProxyData.csv");
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.PrintDataset(dataset);

            User user1 = User.GenerateUser("Ivan");
            User user2 = User.GenerateUser("Marko");
            ProtectionProxyDataset protectionProxy1 = new ProtectionProxyDataset(user1);
            ProtectionProxyDataset protectionProxy2 = new ProtectionProxyDataset(user2);

            printer.PrintDataset(protectionProxy1);
            Console.WriteLine();
            printer.PrintDataset(protectionProxy2);




        }

        static void Zad5Test()
        {
            string people = "Ivan,Marko,Ivica";
            ReminderNote note1 = new ReminderNote("Reminder 1", new DarkRedTheme());
            note1.Show();
            note1.Theme = new LightTheme();
            note1.Show();
        }

        static void Zad6Test()
        {
            List<string> people = new List<string>();
            people.Add("Ivan");
            people.Add("Marko");
            people.Add("Ivica");
            GroupNote note1 = new GroupNote("Group Note 1", new DarkRedTheme(), people);
            List<string> people2 = new List<string>();
            people2.Add("Luka");
            people2.Add("Gabriel");
            people2.Add("Leon");
            GroupNote note2 = new GroupNote("Group Note 2", new LightTheme(), people2);

            note1.Show();
            note2.Show();

        }

        static void Zad7Test()
        {
            Notebook notebook = new Notebook(new LightTheme());
            notebook.AddNote(new ReminderNote("Reminder 1", new DarkRedTheme()));
            notebook.Display();
            notebook.AddNote(new GroupNote("Group Note 1", new DarkRedTheme(), new List<string> { "Ivan", "Marko", "Ivica" }));
            notebook.ChangeTheme(new DarkRedTheme());
            notebook.AddNote(new GroupNote("Group Note 2", new LightTheme(), new List<string> { "Luka", "Gabriel", "Leon" }));
            notebook.Display();
        }
    }
}