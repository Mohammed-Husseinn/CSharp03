#region Questions
// Question 1

int pages = 464;
bool isAvailable = true;

if (pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}



// Question 2

string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}

// Question 3

int pages = 464;
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";



// Question 4

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}


// Question 5

int index = 0;

while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}


// Question 6
int count = 0;

do
{
    Console.WriteLine("Checking book...");
    count++;
}
while (count < 3);


// Question 7

foreach (string book in books)
{
    Console.WriteLine(book);
}

// Question 8

foreach (string book in books)
{
    Console.WriteLine(book);

    if (book == "Refactoring")
    {
        break;
    }
}


// Question 9

foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }

    Console.WriteLine(book);
}


// Question 10

void PrintFirstBook()
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}

#endregion