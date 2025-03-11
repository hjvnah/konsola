class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź pierwszą liczbę: ");
        string pierwszaliczba_ = Console.ReadLine();
        int pierwszaliczba = int.Parse(pierwszaliczba_);

        Console.WriteLine("Wprowadź drugą liczbę: ");
        string drugaliczba_ = Console.ReadLine();
        int drugaliczba = int.Parse(drugaliczba_);

        int zapasowa = 0;
        bool czykoniec = false;
        int wynik = 0;

        if (pierwszaliczba == drugaliczba)
        {
            Console.WriteLine("Największy wspólny dzielnik obu liczb to: " + pierwszaliczba);
        }
        else
        {
            Dzialanie(drugaliczba, pierwszaliczba, zapasowa, czykoniec, wynik);
            
        }


    }


    static void Dzialanie(int drugaliczba, int pierwszaliczba, int zapasowa, bool czykoniec, int wynik)
    {
       

        do
        {           
            if (pierwszaliczba > drugaliczba)
            {
                zapasowa = pierwszaliczba - drugaliczba;
                wynik = pierwszaliczba / zapasowa;
                czykoniec = false;

            }
            else if (drugaliczba > pierwszaliczba)
            {
                zapasowa = drugaliczba - pierwszaliczba;
                wynik = drugaliczba / zapasowa;
                czykoniec = false;
            }
            else
            {
                czykoniec = true;
               
            }
        } while (czykoniec = false && zapasowa==wynik);

        Console.WriteLine("Największy wspólny dzielnik to: " + zapasowa);
    }
}
