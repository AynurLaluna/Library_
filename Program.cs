using System;

using Library_;


Library library = new();





string email = "aynur@gmail.com";
string password = "aynur123";

Console.WriteLine("Welcome to our online Library!");
Thread.Sleep(2000);
Console.Clear();






int attempt = 0;


while (attempt < 5)
{
    Console.WriteLine("Enter your email:");
    string usrEmail = Console.ReadLine();

    Console.WriteLine("Enter your password:");
    string usrPassword = Console.ReadLine();

    if (usrEmail == email && usrPassword == password  )
    {

       
        Console.WriteLine("Login successfully!");
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Invalid email address or password. Please try again");
        attempt++;
    }
    

    while (true)
    {
        Console.WriteLine("Please,enter your choice: ");

        Console.WriteLine("1. List of items in the library");
        Console.WriteLine("2. Renting items to students");
        Console.WriteLine("3. Search in the library");
        Console.WriteLine("4. Exit");

        

        string userChoice = Console.ReadLine();


        switch (userChoice)
        {
            case "1":
                library.DisplayItems();
                break;

            case "2":
                library.RentItem();
                break;

            case "3":
                library.SearchItems();
                break;

            case "4":
                Console.WriteLine("Exiting the program..");
                Thread.Sleep(1000);
                Console.Clear();
                break;
        }
        attempt++;
    }
    

}




