using System;
using System.Collections.Generic;

namespace GEM_Code_V2
{
    class Simulator
    {
        CommonData CD;
        Random Rand;

        public Simulator (CommonData iCD, Random iRand, bool T)
        {
            CD = iCD;
            Rand = iRand;
        }

        public void Qualifying(List<Entrant> EntryList, int ECount, int QStint, bool Test)
        {
            int StintScore;

            for (int E = 0; E < ECount; E++)
            {
                StintScore = QualiStint(EntryList[E]);

                if (EntryList[E].GetBaseOVR() + StintScore > EntryList[E].GetOVR())
                {
                    EntryList[E].UpdateOVR(EntryList[E].GetBaseOVR() + StintScore);
                    EntryList[E].SetLastStint(StintScore);
                }
            }

            Sort(EntryList, ECount);

            Save.SaveStint(EntryList, CD, "Quali " + QStint, Test);
        }

        public int QualiStint(Entrant EntrantData)
        {
            int StintScore, Incident;
            int IL = 1, DNF = EntrantData.GetDNF();

            StintScore = Rand.Next(CD.GetClasses(EntrantData.GetClassIndex()).GetSRLow(), CD.GetClasses(EntrantData.GetClassIndex()).GetSRHigh() + EntrantData.GetSRM());
            Incident = Rand.Next(IL, EntrantData.GetReliability());

            if (Incident < DNF)
            {
                if (Incident == 1)
                {
                    StintScore = 5;
                }

                else
                {
                    StintScore -= CD.GetClasses(EntrantData.GetClassIndex()).GetSRInc();
                }
            }

            return StintScore;
        }

        public int Race(List<Entrant> EntryList)
        {
            int StintScore, PitScore, DNFs = 0;

            for (int E = 0; E < EntryList.Count; E++)
            {
                if (EntryList[E].GetOVR() == 1)
                {
                    break;
                }

                else
                {
                    StintScore = RaceStint(EntryList[E]);
                    PitScore = Rand.Next(5, 26);

                    if (StintScore == 1)
                    {
                        DNFs++;
                        EntryList[E].UpdateOVR(1);
                    }

                    else
                    {
                        EntryList[E].AddToOVR(StintScore + PitScore);
                    }
                }
            }

            Sort(EntryList, EntryList.Count);

            return DNFs;
        }

        public int RaceStint(Entrant EntrantData)
        {
            int StintScore, Incident;
            int IL = 1, DNF = EntrantData.GetDNF();

            StintScore = Rand.Next(CD.GetClasses(EntrantData.GetClassIndex()).GetSRLow(), CD.GetClasses(EntrantData.GetClassIndex()).GetSRHigh() + EntrantData.GetSRM());
            Incident = Rand.Next(IL, EntrantData.GetReliability());

            if (Incident < DNF)
            {
                if (Incident == 1)
                {
                    StintScore = 1;
                }

                else
                {
                    StintScore -= CD.GetClasses(EntrantData.GetClassIndex()).GetSRInc();
                }
            }

            return StintScore;
        }

        public void SetGrid(List<Entrant> EntryList, int Spacing)
        {
            int ED = EntryList.Count;

            foreach (Entrant EntrantData in EntryList)
            {
                EntrantData.SetGridOVR(ED * Spacing);
                ED--;
            }
        }

        public void Sort(List<Entrant> Entrants, int EC)
        {
            Entrant TE;

            for (int i = 0; i < EC - 1; i++)
            {
                bool Swap = false;

                for (int j = 0; j < EC - i - 1; j++)
                {
                    if (Entrants[j].GetOVR() < Entrants[j + 1].GetOVR())
                    {
                        Swap = true;

                        TE = Entrants[j];

                        Entrants[j] = Entrants[j + 1];
                        Entrants[j + 1] = TE;
                    }

                    else if (Entrants[j].GetOVR() == Entrants[j + 1].GetOVR())
                    {
                        if (Entrants[j].GetOVR() == 1)
                        {
                            continue;
                        }

                        else if (Entrants[j].GetLastStint() < Entrants[j + 1].GetLastStint())
                        {
                            Swap = true;

                            TE = Entrants[j];

                            Entrants[j] = Entrants[j + 1];
                            Entrants[j + 1] = TE;
                        }
                    }
                }

                if (!Swap)
                {
                    break;
                }
            }
        }
    }
}