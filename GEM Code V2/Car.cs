using System;

namespace GEM_Code_V2
{
    public class Car
    {
        string Class, CarName;
        int OVR, BOP, Reliability;

        public Car(string C, string CN, int O, int B, int R)
        {
            Class = C;
            CarName = CN;
            OVR = O;
            BOP = B;
            Reliability = R;
        }

        public string GetCarAsWriteString()
        {
            return Class + "," + CarName + "," + Convert.ToString(OVR) + "," + Convert.ToString(BOP) + ",," + Convert.ToString(Reliability);
        }

        public string GetClass()
        {
            return Class;
        }

        public void UpdateClass(string C)
        {
            Class = C;
        }

        public string GetCarName()
        {
            return CarName;
        }

        public void UpdateCarName(string CN)
        {
            CarName = CN;
        }

        public int GetOVR()
        {
            return OVR;
        }

        public void UpdateOVR(int O)
        {
            OVR = O;
        }

        public int GetBOP()
        {
            return BOP;
        }

        public void UpdateBOP(int BoP)
        {
            BOP = BoP;
        }

        public int GetReliability()
        {
            return Reliability;
        }

        public void UpdateReliability(int R)
        {
            Reliability = R;
        }
    }
}
