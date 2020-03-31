using Amazon;
using Shapes;
using POSInterface;
using System;
using System.Collections.Generic;
using System.IO;
using Extensibility;
using Polymorphism;
using Exercise3;
using Exercise2;
using Exercise1;

namespace MoshClass
{

    partial class Program
    {
        static void Main(string[] args)
        {
            var pie = new Pie();
            Console.WriteLine(pie.EstimatePie(1000));
        }
        static void UseWorkFlow()
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new VideoUploador());
            workFlow.Add(new SendEmail());
            workFlow.Add(new CallWebService());
            workFlow.Remove(new CallWebService());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);

            Console.ReadLine();
        }
        static void UseStack()
        {
            var stack = new Stack();

            stack.Push("A");
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        static void StartStopWatch()
        {
            StopWatch stopWatch = new StopWatch();
            Console.WriteLine("Start_Time : {0}", DateTime.Now);
            stopWatch.Start();
            Console.WriteLine("Press enter to stop.");
            Console.ReadKey();
            stopWatch.Stop();
            Console.WriteLine("Stop_Time : {0}", DateTime.Now);
            Console.WriteLine("Duration: {0}", stopWatch.GetInterval());
            Console.WriteLine("Do you want to restart the stopwatch? y/n");

            string request = Console.ReadLine();
            if (request == "y" || request == "yes")
                StartStopWatch();

            Console.WriteLine("Thanks for using RyStopWatch");
        }
        static void UsePolymorphism()
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.Encode(new Video());
        }
        static void UseExtensibility()
        {
            var dbMigrator = new Extensibility.DbMigrator(new FileLogger("D:\\Learning\\log.txt"));
            dbMigrator.Migrate();
        }
        static void UseInterface()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new POSInterface.Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
        static void UseMethodOverriding()
        {
            var shapes = new List<Shapes.Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
        static void UseExplicit()
        {
            Shape shape = new TextClass();
            TextClass text = (TextClass)shape;

            var x = shape as TextClass;
            if(x != null)
                Console.WriteLine("Up casting method!");
        }
        static void UseImplicit()
        {
            StreamReader stream = new StreamReader(new MemoryStream());

            var text = new TextClass();
            Shape shape = text;

            text.Hieght = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
        static void UseInheritance()
        {
            var car = new Car("XYZ1234");
        }
        static void UseClassLibray()
        {
            var rateCalulator = new RateCalcultor();
            rateCalulator.Calculate(new Amazon.Customer());
        }
        static void UseComposition()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
        static void UseText()
        {
            var text = new Text
            {
                Width = 100
            };
            text.Copy();
        }
        static void UseIndexer()
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }
        static void UseEProperties()
        {
            var calucateAge = new CalculateAge(new DateTime(1995, 6, 3));
            Console.WriteLine(calucateAge.Age);
        }
        static void UseProperties()
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1995, 6, 3));
            Console.WriteLine(person.Age);
        }
        static void UseEncapulation()
        {
            Person person = new Person();
            person.SetBirthdate(new DateTime(1892, 1, 1));
            Console.WriteLine(person.GetBirtdate());
        }
        static void UseFileds()
        {
            Customer customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
        static void UseOut()
        {
            int number;
            var result = int.TryParse("1", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Unable to convert number.");
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 2));
            Console.WriteLine(calculator.Add(1, 2, 2));
            Console.WriteLine(calculator.Add(new int[] { 1, 9, 2 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);

                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("You have an exception");
            }
        }
        static void UseCustomer()
        {
            var customer = new Customer(1, "Jhon");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
        static void UsePerson()
        {
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
