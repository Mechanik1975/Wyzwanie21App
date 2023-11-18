string inName = "Ewa";  // imie
char inGender = 'w';  // w-kobieta , m-mezczyzna
int inEage = 33;   // wiek

if(inGender == 'w' && inEage < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(inGender == 'w' && inName == "Ewa" && inEage == 33)
{
    Console.WriteLine("Ewa, lat 33 ");
}
else if(inGender != 'w' && inEage < 18)
{
    Console.WriteLine("Mężczyzna poniżej 18 roku.");
}