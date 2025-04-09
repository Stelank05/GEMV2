using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GEM_Code_V2
{
    public class CommonData
    {
        string FilePath = @"", FolderName = "", SetupLocation = "", SeasonNo = "";

        List<string> WECDistances = new List<string>(),
            IMSADistances = new List<string>(),
            LapDistances = new List<string>();

        int RoundNo;

        bool Test;

        List<Class> Classes = new List<Class>();

        public void SetPaths() // Void this if desired by commenting out Line 28 in Start Window.cs, and put the paths in directly above
        {
            List<string> Paths = new List<string>();

            try
            {
                string[] FPs = File.ReadAllLines("File Paths.csv");

                foreach (string FP in FPs)
                {
                    Paths.Add(FP.Split(',')[1]);
                }

                FilePath = @Paths[0];
                FolderName = Paths[1];
                SetupLocation = Paths[2];
                SeasonNo = Paths[3];
                Test = Convert.ToBoolean(Convert.ToString(Paths[4]).ToLower());
            }

            catch
            {
                MessageBox.Show("Please Close the 'File Paths.csv' File", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetPaths();
            }
        }

        public void LoadClasses()
        {
            Classes.Clear();
            SetPaths();

            string FileName = Path.Combine(FilePath, FolderName, SetupLocation, "Class Setup.csv");

            string[] CD = File.ReadAllLines(FileName);

            Class TempClass;

            int Index = 0;

            foreach (string RoundData in CD)
            {
                string[] CDs = RoundData.Split(',');

                if (CDs[1] == "")
                {
                    break;
                }

                else if (CDs[0] == "Arbitrary")
                {
                    continue;
                }

                else
                {
                    TempClass = new Class(CDs[1], Convert.ToInt32(CDs[2]), Convert.ToInt32(CDs[3]), Convert.ToInt32(CDs[5]), Convert.ToInt32(CDs[6]), Convert.ToInt32(CDs[7]), Convert.ToInt32(CDs[9]), Convert.ToInt32(CDs[10]), Index);
                    Classes.Add(TempClass);

                    Index++;
                }
            }
        }

        public Class GetClasses(int I)
        {
            return Classes[I];
        }

        public int GetClassCount()
        {
            return Classes.Count;
        }

        public void LoadDistances()
        {
            string[] sWECDistances = File.ReadAllLines(Path.Combine(FilePath, FolderName, SetupLocation, "WEC Distances.csv"));

            foreach (string sWEC in sWECDistances)
            {
                WECDistances.Add(sWEC);
            }

            string[] sIMSADistances = File.ReadAllLines(Path.Combine(FilePath, FolderName, SetupLocation, "IMSA Distances.csv"));

            foreach (string sIMSA in sIMSADistances)
            {
                IMSADistances.Add(sIMSA);
            }

            string[] sLapDistances = File.ReadAllLines(Path.Combine(FilePath, FolderName, SetupLocation, "Lap Distances.csv"));

            foreach (string sLap in sLapDistances)
            {
                LapDistances.Add(sLap);
            }
        }

        public void SetRoundNo(int RN)
        {
            RoundNo = RN;
        }

        public int GetRoundNo()
        {
            return RoundNo;
        }

        public bool GetTest()
        {
            return Test;
        }

        public string GetFilePath()
        {
            return Path.Combine(FilePath, FolderName);
        }

        public string GetSavePath(bool Test)
        {
            if (Test)
            {
                return Path.Combine(FilePath, FolderName, "Results", SeasonNo, "Round " + (RoundNo - 1));
            }

            else
            {
                return Path.Combine(FilePath, FolderName, "Results", SeasonNo, "Round " + RoundNo);
            }
        }

        public string GetSetupPath()
        {
            return Path.Combine(FilePath, FolderName, SetupLocation);
        }

        public string GetWECDistance(int Stint)
        {
            return WECDistances[Stint - 1];
        }

        public string GetIMSADistance(int Stint)
        {
            return IMSADistances[Stint - 1];
        }

        public string GetLapsDistance(int Stint)
        {
            return LapDistances[Stint - 1];
        }
    }
}