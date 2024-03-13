// See https://aka.ms/new-console-template for more information

using modul4_1302223136;

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        KodeBuah1 kodeBuah1 = new KodeBuah1();

        kodeBuah.setKodeBuah();
        kodeBuah.getKodeBuah();
        kodeBuah1.setKodeBuah();
        kodeBuah1.getKodeBuah();

        PosisiKarakterGame posisiKarakterGame = new PosisiKarakterGame();
        posisiKarakterGame.testrun();
    }
}


