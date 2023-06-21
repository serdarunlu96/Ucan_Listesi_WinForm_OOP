namespace Ucan_Listesi_WinForm
{
    public partial class Form1 : Form
    {
        List<IUcan> ucanlar = new List<IUcan>();

        public Form1()
        {
            InitializeComponent();
            Ucak u1 = new Ucak("Boeing 737");
            u1.Kapasite = 149;
            Ucak u2 = new Ucak("F-16 Fighting Falcon");
            u2.Kapasite = 1;
            u2.Tur = UcakTur.Savas;
            Balon b1 = new Balon() { Renk = "Mavi" };
            Balon b2 = new Balon() { Renk = "Kýrmýzý" };
            Kus k1 = new Kus("Þahin");
            IUcan k2 = new Kus("Kýrlangýç");

            ucanlar.Add(u1);
            ucanlar.Add(b1);
            ucanlar.Add(k1);
            ucanlar.Add(k2);
            ucanlar.Add(u2);
            ucanlar.Add(b2);

            Listele();
        }

        private void Listele()
        {
            lstUcanlar.Items.Clear();

            foreach (IUcan ucan in ucanlar)
            {
                lstUcanlar.Items.Add(ucan);
            }
        }

        private void btnTumunuUcur_Click(object sender, EventArgs e)
        {
            foreach (IUcan ucan in ucanlar)
            {
                ucan.Uc();
            }
        }
    }
}