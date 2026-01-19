public class Kosc {
    public static int LiczbaInstacji = 0; // pole statyczne
    public List<string> NazwyPlikow = new List<string>
    {
        "kosc0.png",
        "kosc1.png",
        "kosc2.png",
        "kosc3.png",
        "kosc4.png",
        "kosc5.png",
        "kosc6.png"
    };

    // Identyfikator pliku graficznego --> Jeśli ktos wyrzuci 1
    // Liczba oczek --> Jeśli ktoś wyrzuci 1,2,3,4,5,6
    public int LiczbaOczek {get; set;}
    public int Identyfikator {get; set;}

    // Informacja czy kość jest dostępna
    public bool CzyDostepna {get; set;}

    // Konstruktor klasy jednoargumentowy - Gdy wartośc argumentu wrzyrzuconej kosci jesc inna niz 1,2,3,4,5,6
    // ustawia na wartość 0 
    // Argument jest wartością wyrzuconej kości
    // Oczka będziemy przypisywać do liczby oczek
    // Wyznacza dwie granicę (jeśli byśmy nie dali && to te granice by przeszły przez siebie)

    // Oczka = 5
    public Kosc(int Oczka) { // Konstruktor --> Tworzy obiekt danej klasy
        if (Oczka <= 6 && Oczka >= 1) {
            LiczbaOczek = Oczka;
            Identyfikator = Oczka;
        }
        else {
            LiczbaOczek = 0;
            Identyfikator = 0;

        }
        CzyDostepna = true; // Kość jest dostępna
        LiczbaInstacji++; // Inkrementuje zmienną statyczną
    }
     // Przypisuje wartość w polu logicznym --> kość jest dostępna
     // Identyfikator jest do tego, żeby po indeksach sprawdzać

     // Jeśli stworzymy obiekt -- to będzie liczba instancji 1


    // Konstruktor Bezargumentowy -> losuje liczbę z zakresu od 1 do 6
    // Next -> Musimy wiedzieć jakie teraz są granicę
    // Czy może 1 wylosować i 6 czy nie (nie ma tej 6)
    // Często jest w granicach tak, że w granicach ta 2 wartość jest do niej
    // jest 6, a 7 nie ma
    public Kosc() {
        Render r = new Random();
        int losowa = r.Next(1, 7); // liczba pseudolosowa
        LiczbaOczek = losowa;
        Identyfikator = losowa;
        CzyDostepna = true;
        LiczbaInstacji++;
    } 

    // Metoda --> do przerzucania kości, która realizuje rzuć kością dla kości tylko gdy jest dostępna
    // Nie ma nazw, więc wymyślamy
    // Uzywamy to co jest w konstruktorze

    public void WyswietlLiczbeInstancji() {
        Console.WriteLine(k1.LiczbaInstancji);
    }

    public void RzucKosc() {
        if (CzyDostepna) {
            Render r = new Random();
            int losowa = r.Next(1, 7); // liczba pseudolosowa
            LiczbaOczek = losowa;
            Identyfikator = losowa;
        } 
    }

    // Jeśli wszystkie kości są rzucone, to możemy kliknąć na jakąś kość
    // i ona się przerzuci

    public string WartoscTekstowa() {
        // Zwraca wartość w postaci tekstu, gdy wartość jest równa 3, zwracane jest 3
        // 1. sposob - ciezszy (uzycie) --> klucz i wartość (Dictionary)
        // 2. sposob - na ifach
        // 3. sposob - switch case
        if (LiczbaOczek == 1) return "jeden";
        else if (LiczbaOczek == 2) return "dwa";
        else if (LiczbaOczek == 3) return "trzy";
        else if (LiczbaOczek == 4) return "cztery";
        else if (LiczbaOczek == 5) return "pięć";
        else if (LiczbaOczek == 6) return "sześć";
        else return "zero";
    }

    // Metoda, która blokuje kość
    public void BlokujKosc() {
        CzyDostepna = false;
    }
}
