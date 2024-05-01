using System;
namespace Library_
{
	public class Library: LibraryResource
	{

		public List<string> items;
		public Library()
		{
			items = new List<string>();
		}


		public void DisplayItems()
		{
			Console.WriteLine("Items:");
			foreach(var item in items)
			{
				Console.WriteLine(item);
			}
		}

		public void RentItem()
		{
			Console.WriteLine("What do you wish to rent?");
			string title = Console.ReadLine();

			foreach(var item in items)
			{
				if(items.Contains(title))
				{
                    items.Remove(title);
                    Console.WriteLine($"You have successfully rented {item}");
					return;
				}
				else
				{
					Console.WriteLine("The item you were searching for was not found");
				}
			}

		}

		public void SearchItems()
		{
			Console.WriteLine($"What type of item are you searching?");
			string typeOfItem = Console.ReadLine();

            Thread.Sleep(1000);

			Console.WriteLine("Results:");

			foreach(var item in items)
			{
                if(typeOfItem == item)
				{
                    switch (typeOfItem)
                    {
                        case "book":
                            SearchBooks();
                            break;

                        case "audio books":
                            SearchAudioBooks();
                            break;

                    }
                }
				
            }
			
		}

		public void SearchBooks()
		{

			Console.WriteLine("Enter author, title, year, or pages to search: ");

			string searchTerm = Console.ReadLine().ToLower();

			foreach(var item in items)
			{
				if(items.Contains(searchTerm))
				{
					Console.WriteLine($"The book {item} you were looking for was found. What do you want to do now? ");
				}
				else
				{
					Console.WriteLine($"Sorry, {item} is not in the library");
				}
			}
        }

        public void SearchAudioBooks()
        {

            Console.WriteLine("Enter author, title, narrator, or length to search: ");

            string searchTerm = Console.ReadLine().ToLower();

            foreach (var item in items)
            {
                if ( items.Contains(searchTerm))
                {
					
                    Console.WriteLine($"The audio book {item} you were looking for was found. What do you want to do now? ");
                }
				else
				{
					Console.WriteLine($"Sorry, {item} is not in the library");
				}
            }
        }
    }
}

