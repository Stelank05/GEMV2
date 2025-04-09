using System;
using System.Collections.Generic;
using System.IO;

namespace GEM_Code_V2
{
    class Save
    {
        public static void SaveStint(List<Entrant> EntryList, CommonData CD, string Session, bool T)
        {
            string FilePath = Path.Combine(CD.GetSavePath(T), Session + ".csv");

            string SaveString = "";

            List<int> Positions = new List<int>();

            for (int P = 0; P < CD.GetClassCount(); P++)
            {
                Positions.Add(0);
            }

            string CP = "";

            for (int E = 0; E < EntryList.Count; E++)
            {
                if (EntryList[E].GetOVR() == 1)
                {
                    CP = "DNF";
                }

                else
                {
                    int CI = EntryList[E].GetClassIndex();

                    Positions[CI]++;
                    CP = "P" + Positions[CI];
                }

                SaveString += EntryList[E].GetClass() + "," + CP + "," + EntryList[E].GetCarAsWriteString();

                if (E != EntryList.Count - 1)
                {
                    SaveString += Environment.NewLine;
                }

                if ((E + 1) % 25 == 0)
                {
                    SaveString += Environment.NewLine;
                }
            }

            File.WriteAllText(FilePath, SaveString);
        }
    }
}