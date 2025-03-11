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

        /*  if ( pierwszaliczba == drugaliczba)
          {
              Console.WriteLine("Największy wspólny dzielnik obu liczb to: " + pierwszaliczba);
          }
          else
          {
              while (koniec )

              if (pierwszaliczba > drugaliczba)
              {
                  zapasowa = pierwszaliczba - drugaliczba;
                  if( zapasowa)
                  {

                  }
              }
              else
              {
                  zapasowa = drugaliczba - pierwszaliczba;
                  if (drugaliczba / zapasowa == 0)
                  {

                  }
              }*/

        do
        {
            if (pierwszaliczba == drugaliczba)
            {
                zapasowa = pierwszaliczba;
                czykoniec = false;
            }
            else if (pierwszaliczba > drugaliczba)
            {
                zapasowa = pierwszaliczba - drugaliczba;
                czykoniec = false;
                
            }
            else if (drugaliczba > pierwszaliczba)
            {
                zapasowa = drugaliczba - pierwszaliczba;
                czykoniec = false;
            }
            
            
        } while (czykoniec = false);
            

        
         
            
            
            
            
            
            
           
        }

    }
