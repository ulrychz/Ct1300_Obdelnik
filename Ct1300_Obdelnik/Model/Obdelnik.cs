namespace Ct1300_Obdelnik.Model
{
    public class Obdelnik
    {
        private int stranaA;
        private int stranaB;

        public int StranaA
        {
            get => stranaA; 
            set
            {
                if (stranaA != value)
                {
                    if(value < 0)
                        stranaA = Math.Abs(value) ;
                    else
                        stranaA = value;
                }
            }
        }
        public int StranaB
        {
            get => stranaB; 
            set
            {
                if (stranaB != value)
                    stranaB = Math.Abs(value);
            }
        }
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
