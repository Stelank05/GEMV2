namespace GEM_Code_V2
{
    public class Entrant
    {
        string Class, CarNo, TeamName, Car;
        int OVR, OVRa, Reliability, DNF, SRModifier, ClassIndex, LastStint;

        public Entrant(string C, string CN, string TN, string Ca, int OVRi, int SRM, int R, Class EntrantClass, Round RoundData)
        {
            Class = C;
            CarNo = CN;
            TeamName = TN;
            Car = Ca;
            OVR = OVRi;
            OVRa = OVRi;
            SRModifier = SRM;
            Reliability = R + EntrantClass.GetIRM() - RoundData.GetDefaultIncidentRate();
            DNF = RoundData.GetDefaultDNFRate() + EntrantClass.GetDNFRM();
            ClassIndex = EntrantClass.GetClassIndex();
        }

        public string GetClass()
        {
            return Class;
        }

        public string GetCarNo()
        {
            return CarNo;
        }

        public string GetTeamName()
        {
            return TeamName;
        }

        public string GetCrew()
        {
            return CarNo + " " + TeamName;
        }

        public string GetCar()
        {
            return Car;
        }

        public string GetCarAsWriteString()
        {
            return CarNo + " " + TeamName + "," + Car + ",," + OVR;
        }

        public void AddToOVR(int AddValue)
        {
            OVR += AddValue;
        }

        public void SetGridOVR(int GridSpacing)
        {
            OVR = OVRa + GridSpacing;
        }

        public void UpdateOVR(int NewOVR)
        {
            OVR = NewOVR;
        }

        public int GetOVR()
        {
            return OVR;
        }

        public int GetBaseOVR()
        {
            return OVRa;
        }

        public int GetSRM()
        {
            return SRModifier;
        }

        public int GetReliability()
        {
            return Reliability;
        }

        public int GetDNF()
        {
            return DNF;
        }

        public int GetClassIndex()
        {
            return ClassIndex;
        }

        public void SetLastStint(int Stint)
        {
            LastStint = Stint;
        }

        public int GetLastStint()
        {
            return LastStint;
        }
    }
}