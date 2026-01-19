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
    public Kosc(int oczka) {
        if (oczka <= 6 && oczka >= 1) {
            LiczbaOczek = oczka;
            Identyfikator = 0;
        }
        else
            LiczbaOczek = 0;
    }


}
