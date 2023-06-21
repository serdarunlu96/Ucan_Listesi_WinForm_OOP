using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucan_Listesi_WinForm
{
    public class Kus : IUcan
    {
        public Kus(string cins)
        {
            Cins = cins;
            Yas = 1;
        }
        public string Cins { get; set; }

        public int Yas { get; set; }

        public void Uc()
        {
            MessageBox.Show($"{Cins} kanatlarını çırparak gökyüzünde uçuyordu..");
        }
    }
}
