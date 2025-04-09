namespace GEM_Code_V2
{
    public class Class
    {
        string ClassName;
        int IncidentRangeModifier, DNFRateModifier;
        int SRHigh, SRLow, SRInc;
        int ClassIndex;
        int MinOVR, MaxOVR;

        public Class(string CN, int IRM, int DNFRM, int H, int L, int I, int mOVR, int MOVR, int CI)
        {
            ClassName = CN;
            IncidentRangeModifier = IRM;
            DNFRateModifier = DNFRM;
            SRHigh = H;
            SRLow = L;
            SRInc = I;
            MinOVR = mOVR;
            MaxOVR = MOVR;
            ClassIndex = CI;
        }

        public string GetClassName()
        {
            return ClassName;
        }

        public int GetIRM()
        {
            return IncidentRangeModifier;
        }

        public int GetDNFRM()
        {
            return DNFRateModifier;
        }

        public int GetClassIndex()
        {
            return ClassIndex;
        }

        public int GetSRLow()
        {
            return SRLow;
        }

        public int GetSRHigh()
        {
            return SRHigh;
        }

        public int GetSRInc()
        {
            return SRInc;
        }

        public int GetMinOVR()
        {
            return MinOVR;
        }

        public int GetMaxOVR()
        {
            return MaxOVR;
        }
    }
}