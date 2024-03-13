using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223136
{
    internal class KodeBuah1
    {
        public String namaBuah;
        public String kodeBuah;

        public KodeBuah1(String namaBuah, String kodeBuah)
        {
            this.namaBuah = namaBuah;
            this.kodeBuah = kodeBuah;
        }

        public KodeBuah1()
        {
        }

        public List<KodeBuah1> listBuah = new List<KodeBuah1>();

        public void setKodeBuah()
        {
            this.listBuah.Add(new KodeBuah1("Apel", "A00"));
            this.listBuah.Add(new KodeBuah1("Aprikot", "B00"));
            this.listBuah.Add(new KodeBuah1("Alpukat", "C00"));
            this.listBuah.Add(new KodeBuah1("Pisang", "D00"));
            this.listBuah.Add(new KodeBuah1("Paprika", "E00"));
            this.listBuah.Add(new KodeBuah1("Blackberry", "F00"));
            this.listBuah.Add(new KodeBuah1("Ceri", "H00"));
            this.listBuah.Add(new KodeBuah1("Kelapa", "I00"));
            this.listBuah.Add(new KodeBuah1("Jagung", "J00"));

        }

        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah    Kode Buah");
            foreach (KodeBuah1 k in this.listBuah)
            {
                Console.WriteLine(k.namaBuah + "    " + k.kodeBuah);
            }
        }
    }
}
