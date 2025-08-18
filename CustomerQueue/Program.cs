Queue<string> customers = new Queue<string> ();
while(true)
{
    Console.WriteLine("\n 1. Add new Customer");
    Console.WriteLine("\n 2. Call the next Customer");
    Console.WriteLine("\n 3. Show List Customer");
    Console.WriteLine("\n 0. Exit");
    Console.WriteLine("\n Please choose a function");
    Console.WriteLine("\n -------------------------");

    int choice = int .Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
            Console.WriteLine("Enter Cs Name");
            customers.Enqueue(Console.ReadLine());
        break;
    
        case 2:
            if (customers.Count > 0)
            {
                Console.WriteLine($"Call the next customer name: {customers.Dequeue()}");
            }
            else
            {
                Console.WriteLine("No more customer");
            }
            break;
        case 3:
            Console.WriteLine("show List Cs");
            foreach (var cs in customers)
            { Console.WriteLine(cs); }    

            break;
        case 0:
            return;

        default: Console.WriteLine("Invalid choice");
            break;
    }

}