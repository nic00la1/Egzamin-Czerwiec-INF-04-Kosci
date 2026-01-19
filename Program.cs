Kosc k1 = new Kosc();

Console.WriteLine("Podaj wartość: ");
int wartosc =  Console.ReadLine();

// Nie mogą być 2 konstruktory, ktore mają te same argumenty
// Dwuargumentowy konstruktor (int, string)
// Jeśli zrobimy drugi taki to nie będzie działać
// Przeciążenie metod - zadeklarowanie tej samej metody z tą samą nazwa ale różniącą się argumentami
// Przeciążamy konstruktory

Kosc k2 = new Kosc(wartosc);

// Po utworzeniu każdego obiektu, należy wyświetlić liczbę instancji klasy
k1.WyswietlLiczbeInstancji();
Console.WriteLine($"Kość 1\nLiczba oczek - {k1.LiczbaOczek} ({k1.WartoscTekstowa()}), nazwa pliku"); // k1 i k2 będą miały obie taką samą wartość tej samej instancji
Console.WriteLine($"Kość 2\nLiczba oczek - {k2.LiczbaOczek} ({k2.WartoscTekstowa()}), nazwa pliku");
// pola statyczne mają takie same wartośći dla wszyzstkich obiektów

// output: Gdy podam 3 : Liczba oczek - 3 (trzy). nazwa pliku - kosc3.png
