using System.Collections.Generic;

namespace GEM_Code_V2
{
    public class Round
    {
        string RoundName, LengthType;
        int RaceLength, IncidentRange, DNFRate;
        bool C1_Racing, C2_Racing, C3_Racing, C4_Racing, C5_Racing, C6_Racing;

        List<string> ClassesShort = new List<string>();
        List<string> ClassesLong = new List<string>();

        public Round(string RN, int RL, int IR, int DR, string LT, List<string> RacingClasses)
        {
            RoundName = RN;
            RaceLength = RL;
            LengthType = LT;
            IncidentRange = IR;
            DNFRate = DR;

            foreach (string RacingClass in RacingClasses)
            {
                if (RacingClass == "C1")
                {
                    C1_Racing = true;
                    ClassesLong.Add("Class 1");
                    ClassesShort.Add("C1");
                }

                if (RacingClass == "C2")
                {
                    C2_Racing = true;
                    ClassesLong.Add("Class 2");
                    ClassesShort.Add("C2");
                }

                if (RacingClass == "C3")
                {
                    C3_Racing = true;
                    ClassesLong.Add("Class 3");
                    ClassesShort.Add("C3");
                }

                if (RacingClass == "C4")
                {
                    C4_Racing = true;
                    ClassesLong.Add("Class 4");
                    ClassesShort.Add("C4");
                }

                if (RacingClass == "C5")
                {
                    C5_Racing = true;
                    ClassesLong.Add("Class 5");
                    ClassesShort.Add("C5");
                }

                if (RacingClass == "C6")
                {
                    C6_Racing = true;
                    ClassesLong.Add("Class 6");
                    ClassesShort.Add("C6");
                }
            }
        }

        public string GetRoundName()
        {
            return RoundName;
        }

        public string GetLengthType()
        {
            return LengthType;
        }

        public List<string> GetLongRacingClasses()
        {
            return ClassesLong;
        }

        public List<string> GetShortRacingClasses()
        {
            return ClassesShort;
        }

        public bool ClassIsRacing(string Class)
        {
            if (Class == "Class 1")
            {
                return C1_Racing;
            }

            else if (Class == "Class 2")
            {
                return C2_Racing;
            }

            else if (Class == "Class 3")
            {
                return C3_Racing;
            }

            else if (Class == "Class 4")
            {
                return C4_Racing;
            }

            else if (Class == "Class 5")
            {
                return C5_Racing;
            }

            else if (Class == "Class 6")
            {
                return C6_Racing;
            }

            else
            {
                return false;
            }
        }

        public int GetRaceLength()
        {
            if (LengthType == "WEC")
            {
                return RaceLength * 2;
            }

            else
            {
                return RaceLength;
            }
        }

        public int GetDefaultIncidentRate()
        {
            return IncidentRange;
        }

        public int GetDefaultDNFRate()
        {
            return DNFRate;
        }
    }
}