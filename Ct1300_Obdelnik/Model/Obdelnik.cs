namespace Ct1300_Obdelnik.Model
{
    public class Obdelnik
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }

        private void SpoctiObsah() 
        { 
            Obsah = StranaA * StranaB;
        }
        private void SpoctiObvod()
        {
            Obvod = 2*(StranaA + StranaB);
        }
        private void SpoctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(Math.Pow(StranaA,2) + StranaB*StranaB);
        }
        public void Spocti()
        {
            SpoctiObsah();
            SpoctiObvod();
            SpoctiUhlopricku();
        }
    }
}
