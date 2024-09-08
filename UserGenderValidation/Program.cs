// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajalt valida tema sugu
//Rakendus küsib kasutajalt sisestada tema perekonnanime
//Lähtudes kasutaja valikust ,rakendus tervitab kasutajat:
//"Welcome, MR/MS kasutaja perekonnanime

Console.WriteLine("Please, select your gender m/f");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string formaadis
Console.WriteLine("Please, enter your lastname");
string userlastname = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userlastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userlastname}!");
}
else
{
    Console.WriteLine($"Welcome!{userlastname}");
}