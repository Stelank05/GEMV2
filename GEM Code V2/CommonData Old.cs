using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GEM_Code_V2
{
    public class Common_Data
    {
        string FilePath = @"C:\Users\Steph\Documents\Excel Sims", FolderName = "Global Endurance Masters";
        string CarLocation = "Car Data", SetupLocation = "V2 Setup Files", SeasonNo = "V2 Code Testing";
        string RoundPath;
        List<string> WECDistances = new List<string>(),
            IMSADistances = new List<string>(),
            LapDistances = new List<string>();
        int Entrants, RoundNo;

        List<Class> Classes = new List<Class>();

        public Common_Data()
        {
            // Load Distances

            LoadDistances(WECDistances, "WEC");

            LoadDistances(IMSADistances, "IMSA");

            LoadDistances(LapDistances, "Lap");

            // Load Classes

            //RA.GetClasses(Classes);
        }

        public void LoadDistances(List<string> ListType, string Type)
        {
            string FP = Path.Combine(FilePath, FolderName, SetupLocation, Type + " Distances.csv");

            string[] Distances = File.ReadAllLines(FP);

            foreach (string D in Distances)
            {
                ListType.Add(D);
            }
        }

        public void SetEntrants(int iEntrants)
        {
            Entrants = iEntrants;
        }

        public void SetRoundNo(int iRoundNo)
        {
            RoundNo = iRoundNo;
            RoundPath = Path.Combine(FilePath, FolderName, "Results", SeasonNo, "Round " + (RoundNo + 1));
            Directory.CreateDirectory(RoundPath);
        }

        public int GetEntrants()
        {
            return Entrants;
        }

        public int GetRoundNo()
        {
            return RoundNo;
        }

        public string GetPath()
        {
            return FilePath;
        }

        public string GetFolder()
        {
            return FolderName;
        }

        public string GetFolderPath()
        {
            return Path.Combine(FilePath, FolderName);
        }

        public string GetCarsLocation()
        {
            return Path.Combine(FilePath, FolderName, CarLocation);
        }

        public string GetSetupLocation()
        {
            return SetupLocation;
        }

        public string GetRoundPath()
        {
            return RoundPath;
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
