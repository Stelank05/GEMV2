using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GEM_Code_V2
{
    class Race_Admin
    {
        CommonData CDC = new CommonData();

        public void GetCalendar(List<Round> Calendar)
        {
            //string FileName = Path.Combine(CDC.GetFolderPath(), CDC.GetSetupLocation(), "Calendar.csv");

            //string[] CD = File.ReadAllLines(FileName);
            int iRD = 0;

            Round TempRound;

            /*foreach (string RoundData in CD)
            {
                string[] sRD = RoundData.Split(',');

                TempRound = new Round(sRD[0], Convert.ToInt32(sRD[1]), Convert.ToInt32(sRD[2]), Convert.ToInt32(sRD[3]), sRD[5], sRD[7], sRD[8], sRD[9],  sRD[10], sRD[11], sRD[12]);

                Calendar.Add(TempRound);

                iRD++;
            }*/
        }

        public void GetClasses(List<Class> Classes)
        {
            //string FileName = Path.Combine(CDC.GetFolderPath(), CDC.GetSetupLocation(), "Class Setup.csv");

            //string[] CD = File.ReadAllLines(FileName);
            int iCC = 0;

            Class TempClass;

            /*foreach (string RoundData in CD)
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
                    MessageBox.Show(CDs[1] + " , " + CDs[2] + " , " + CDs[3], "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TempClass = new Class(CDs[1], Convert.ToInt32(CDs[2]), Convert.ToInt32(CDs[3]));
                    Classes.Add(TempClass);
                    iCC++;
                }
            }*/
        }

        public static bool CheckEntryList(string FileName)
        {
            int Entered = File.ReadAllLines(FileName).Length;

            if (Entered > 11)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static int GetEntrantsTotal(string FilePath)
        {
            string[] EP = File.ReadAllLines(FilePath);

            int iEP = 0;

            foreach (string sEP in EP)
            {
                if (sEP != null)
                {
                    iEP++;
                }

                else
                {
                    break;
                }
            }

            return iEP;
        }

        public static int TotalClasses(List<Entrant> Entrants)
        {
            string[] Classes = new string[6]; int C = 0;

            for (int i = 0; i < Entrants.Count / 4; i++)
            {
                string Class = Entrants[i].GetClass();

                if (Exists(Class, Classes))
                {
                    continue;
                }

                else
                {
                    Classes[C] = Class;
                    C++;
                }

                if (Full(Classes))
                {
                    break;
                }
            }

            return C;
        }

        public static bool Exists(string Class, string[] Classes)
        {
            bool Found = false;

            for (int i = 0; i < Classes.Length; i++)
            {
                if (Classes[i] == null)
                {
                    break;
                }

                else if (Classes[i] == Class)
                {
                    Found = true;
                    break;
                }
            }

            return Found;
        }

        public static bool Exists2D(string Class, string[,] Classes)
        {
            bool Found = false;

            for (int i = 0; i < Classes.Length / 4; i++)
            {
                try
                {
                    if (Classes[i, 0] == null)
                    {
                        break;
                    }

                    else if (Classes[i, 0] == Class)
                    {
                        Found = true;
                        break;
                    }
                }

                catch
                {
                    continue;
                }
            }

            return Found;
        }

        public static bool Full(string[] Classes)
        {
            bool full = false;

            if (Classes[5] != null)
            {
                full = true;
            }

            return full;
        }

        public static bool Full2D(string[,] Classes)
        {
            bool full = false;

            int Index = (Classes.Length / 5) - 1;

            if (Classes[Index, 0] != null)
            {
                full = true;
            }

            return full;
        }
    }
}