namespace Ct1300_Obdelnik.Model
{
    public class Obdelnik2
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
                    if (value < 0)
                        stranaA = Math.Abs(value);
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
        public int Obvod => 2 * (StranaA + StranaB);
        public int Obsah => StranaA * StranaB;
        public double Uhlopricka => Math.Sqrt(Math.Pow(StranaA, 2) + StranaB * StranaB);

    }
}
