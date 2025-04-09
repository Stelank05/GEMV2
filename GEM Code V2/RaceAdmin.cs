using System;
using System.Collections.Generic;
using System.IO;

namespace GEM_Code_V2
{
    public class RaceAdmin
    {
        CommonData CD = new CommonData();

        public void GetCalendar(List<Round> Calendar)
        {
            CD.SetPaths();

            string FileName = Path.Combine(CD.GetSetupPath(), "Calendar.csv");

            string[] iCD = File.ReadAllLines(FileName);
            int iRD = 0;

            Round TempRound;

            List<string> Racing = new List<string>();

            foreach (string RoundData in iCD)
            {
                string[] sRD = RoundData.Split(',');

                for (int i = 7; i < 13; i++)
                {
                    if (sRD[i] != " " || sRD[i] != "")
                    {
                        Racing.Add(sRD[i]);

                        try
                        {
                            if (sRD[i + 1] == " " || sRD[i + 1] == "")
                            {
                                break;
                            }
                        }

                        catch
                        {
                            break;
                        }
                    }

                    else
                    {
                        break;
                    }
                }

                TempRound = new Round(sRD[0], Convert.ToInt32(sRD[1]), Convert.ToInt32(sRD[2]), Convert.ToInt32(sRD[3]), sRD[5], Racing);

                Racing.Clear();

                Calendar.Add(TempRound);

                iRD++;
            }
        }

        public List<Car> LoadCars(string FilePath)
        {
            string[] CarData = File.ReadAllLines(FilePath);

            List<Car> CarList = new List<Car>();

            foreach (string CarDataPiece in CarData)
            {
                string[] FormattedDataPiece = CarDataPiece.Split(',');

                CarList.Add(new Car(FormattedDataPiece[0], FormattedDataPiece[1], Convert.ToInt32(FormattedDataPiece[2]), Convert.ToInt32(FormattedDataPiece[3]), Convert.ToInt32(FormattedDataPiece[5])));
            }

            return CarList;
        }

        public void LoadEntrants(List<Entrant> EntryList, string FilePathInc, Round RoundInQuestion, CommonData tCD)
        {
            List<string> Classes = RoundInQuestion.GetLongRacingClasses();

            Entrant CarEntrant;

            string FilePath;

            int CI = 0;

            foreach (string Class in Classes)
            {
                FilePath = Path.Combine(FilePathInc, Class + ".csv");

                string[] Cars = File.ReadAllLines(FilePath);

                int C = Convert.ToInt32(Classes[CI].Replace("Class ", "")) - 1;

                if (Cars.Length == 1)
                {
                    if (Cars[0] != "")
                    {
                        foreach (string Car in Cars)
                        {
                            string[] CarData = Car.Split(',');

                            CarEntrant = new Entrant(CarData[0], CarData[1], CarData[2], CarData[3], Convert.ToInt32(CarData[4]), Convert.ToInt32(CarData[6]), Convert.ToInt32(CarData[8]), tCD.GetClasses(C), RoundInQuestion);

                            EntryList.Add(CarEntrant);
                        }
                    }
                }

                else
                {
                    foreach (string Car in Cars)
                    {
                        string[] CarData = Car.Split(',');

                        CarEntrant = new Entrant(CarData[0], CarData[1], CarData[2], CarData[3], Convert.ToInt32(CarData[4]), Convert.ToInt32(CarData[6]), Convert.ToInt32(CarData[8]), tCD.GetClasses(C), RoundInQuestion);

                        EntryList.Add(CarEntrant);
                    }
                }

                CI++;
            }
        }

        public List<Entrant> LoadEntrants(string FilePath, int Index)
        {
            List<Entrant> EntryList = new List<Entrant>();
            Entrant CarEntrant;

            CD.LoadClasses();

            List<string> Classes = new List<string>() { "PL" };

            Round RoundInQuestion = new Round("PL", 1, 1, 1, "PL", Classes);

            string[] Cars = File.ReadAllLines(FilePath);

            if (Cars.Length == 1)
            {
                if (Cars[0] != "")
                {
                    foreach (string Car in Cars)
                    {
                        string[] CarData = Car.Split(',');

                        CarEntrant = new Entrant(CarData[0], CarData[1], CarData[2], CarData[3], Convert.ToInt32(CarData[4]), Convert.ToInt32(CarData[6]), Convert.ToInt32(CarData[8]), CD.GetClasses(Index), RoundInQuestion);

                        EntryList.Add(CarEntrant);
                    }
                }
            }

            else
            {
                foreach (string Car in Cars)
                {
                    string[] CarData = Car.Split(',');

                    CarEntrant = new Entrant(CarData[0], CarData[1], CarData[2], CarData[3], Convert.ToInt32(CarData[4]), Convert.ToInt32(CarData[6]), Convert.ToInt32(CarData[8]), CD.GetClasses(Index), RoundInQuestion);

                    EntryList.Add(CarEntrant);
                }
            }

            return EntryList;
        }

        public bool ClassExistsInEntrants(string Item, List<Entrant> List)
        {
            bool Exists = false;

            foreach (Entrant SI in List)
            {
                if (Item == SI.GetClass())
                {
                    Exists = true;
                    break;
                }
            }

            return Exists;
        }

        public bool EntrantExistsInEntrants(Entrant ED, List<Entrant> List)
        {
            bool Exists = false;

            foreach (Entrant SI in List)
            {
                if (SI == ED)
                {
                    Exists = true;
                    break;
                }
            }

            return Exists;
        }

        public void IndexSort(List<Entrant> Entrants)
        {
            Entrant TempEntrant;

            for (int i = 0; i < Entrants.Count - 1; i++)
            {
                bool Swap = false;

                for (int j = 0; j < Entrants.Count - i - 1; j++)
                {
                    if (Entrants[j].GetClassIndex() > Entrants[j + 1].GetClassIndex())
                    {
                        Swap = true;

                        TempEntrant = Entrants[j];
                        Entrants[j] = Entrants[j + 1];
                        Entrants[j + 1] = TempEntrant;
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