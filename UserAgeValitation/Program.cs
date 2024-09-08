// See https://aka.ms/new-console-template for more information
//Rakendus küsib kasutajal sisestada tema vanuse
//kui vanus on väiksem kui 13, siis konsoolis kuvatakse
//"you are too young"
// else , konsoolis kuvatakse lubatav tekst

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//Boolean - True/False

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse resulte {isAgeNumber}. User is {userAgeNum}");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are to young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}