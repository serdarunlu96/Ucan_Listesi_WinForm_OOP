using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucan_Listesi_WinForm
{
    public class Balon : IUcan
    {
        public string Renk { get; set; } = "Pembe";

        public void Uc()
        {
            MessageBox.Show($"{Renk} balon havada yükseliyor..");
        }

    }
}
