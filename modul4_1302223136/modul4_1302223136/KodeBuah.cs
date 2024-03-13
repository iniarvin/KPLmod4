using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223136
{
    internal class KodeBuah
    {
        public String namaBuah;
        public String kodeBuah;

        public KodeBuah(String namaBuah, String kodeBuah)
        {
            this.namaBuah = namaBuah;
            this.kodeBuah = kodeBuah;
        }

        public KodeBuah()
        {
        }

        public List<KodeBuah> listBuah = new List<KodeBuah>();

        public void setKodeBuah()
        {
            this.listBuah.Add(new KodeBuah("Apel", "A00"));
            this.listBuah.Add(new KodeBuah("Aprikot", "B00"));
            this.listBuah.Add(new KodeBuah("Alpukat", "C00"));
            this.listBuah.Add(new KodeBuah("Pisang", "D00"));
            this.listBuah.Add(new KodeBuah("Paprika", "E00"));
            this.listBuah.Add(new KodeBuah("Blackberry", "F00"));
            this.listBuah.Add(new KodeBuah("Ceri", "H00"));
            this.listBuah.Add(new KodeBuah("Kelapa", "I00"));
            this.listBuah.Add(new KodeBuah("Jagung", "J00"));
            
        }

        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah    Kode Buah");
            foreach (KodeBuah k in this.listBuah)
            {
                Console.WriteLine(k.namaBuah + "    " + k.kodeBuah);
            }
        }
    }
}
