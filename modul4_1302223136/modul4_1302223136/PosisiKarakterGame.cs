using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223136
{
    internal class PosisiKarakterGame
    {
        public enum State{JONGKOK, BERDIRI, TENGKURAP, TERBANG};
        State defaults = State.BERDIRI;
        public void testrun()
        {
            //nim % 3 == 1302223136 % 3 == 2
            //dari TERBANG ke JONGKOK, output "posisi landing"
            //dari BERDIRI ke TERBANG, output "posisi takeoff"
            String action;
            Console.WriteLine("Pilih tombol (masukkan huruf): ");
            Console.WriteLine("-W-");
            Console.WriteLine("-S-");
            Console.WriteLine("-X-");
            action = Console.ReadLine();
            while (action != "E")
            {
                Console.WriteLine("Pilih tombol (masukkan huruf): ");
                Console.WriteLine("-W-");
                Console.WriteLine("-S-");
                Console.WriteLine("-X-");
                Console.WriteLine("-E (exit)-");
                action = Console.ReadLine();
                if (action == "W" || action == "w")
                {
                    if (defaults == State.BERDIRI)
                    {
                        defaults = State.TERBANG;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                        Console.WriteLine("posisi take off");
                    }
                    else if (defaults == State.JONGKOK)
                    {
                        defaults = State.BERDIRI;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                    }
                    else if (defaults == State.TERBANG)
                    {
                        Console.WriteLine("Gerakan tidak tersedia");
                    }
                    else if (defaults == State.TENGKURAP)
                    {
                        defaults = State.JONGKOK;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                    }

                }
                else if (action == "S" || action == "s")
                {
                    if (defaults == State.BERDIRI)
                    {
                        defaults = State.JONGKOK;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                    }
                    else if (defaults == State.JONGKOK)
                    {
                        defaults = State.TENGKURAP;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                    }
                    else if (defaults == State.TERBANG)
                    {
                        defaults = State.BERDIRI;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                    }
                    else if (defaults == State.TENGKURAP)
                    {
                        Console.WriteLine("Gerakan tidak tersedia");
                    }
                }
                else if (action == "X" || action == "x")
                {
                    if (defaults == State.TERBANG)
                    {
                        defaults = State.JONGKOK;
                        Console.WriteLine("Posisi saat ini: " + defaults);
                        Console.WriteLine("posisi landing");
                    }
                    else
                    {
                        Console.WriteLine("Gerakan tidak tersedia");
                    }
                }
            }

            
        }
    }
}
