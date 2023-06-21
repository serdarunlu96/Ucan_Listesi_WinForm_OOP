using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucan_Listesi_WinForm
{
    public class Ucak : IUcan
    {

        public Ucak(string model)
        {
            Model = model;
        }

        public int Kapasite { get; set; } = 100;

        public UcakTur Tur { get; set; } = UcakTur.Yolcu;

        public string Model { get; set; }

        public void Uc()
        {
            MessageBox.Show($"{Model} modelli uçak semalarda süzülüyor..");
        }

    }
}
