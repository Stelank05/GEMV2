using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace GEM_Code_V2
{
    public partial class SimRace : Form
    {
        RaceAdmin RA = new RaceAdmin();

        string EntrantsPath;
        int RoundNo;
        bool LMS, Test;

        int RStint = 1;

        List<Round> Calendar;
        List<Entrant> EntryList = new List<Entrant>();

        List<Entrant> PoleSitters = new List<Entrant>();

        List<TextBox> ClassTBs;

        CommonData CD;
        Random Rand;

        Simulator Sim;

        List<Podiums> ActivePodiums = new List<Podiums>();
        List<ViewClassOrder> ActiveVCOs = new List<ViewClassOrder>();

        string Session;

        public SimRace(List<Round> iCalendar, CommonData iCD, Random iRand)
        {
            InitializeComponent();

            Calendar = iCalendar;
            CD = iCD;
            Rand = iRand;

            Sim = new Simulator(CD, Rand, Test);

            CD.LoadClasses();
            CD.LoadDistances();

            RoundNo = CD.GetRoundNo();
            Test = CD.GetTest();

            Directory.CreateDirectory(CD.GetSavePath(Test));

            EntrantsPath = Path.Combine(CD.GetSetupPath(), "Entrants");

            RA.LoadEntrants(EntryList, EntrantsPath, Calendar[RoundNo - 1], CD);

            if (Test)
            {
                if (RoundNo - 1 == 0)
                {
                    tb_RoundNo.Text = "Test";
                }

                else
                {
                    tb_RoundNo.Text = "Round " + (RoundNo - 1);
                }
            }

            else
            {
                tb_RoundNo.Text = "Round " + RoundNo;
            }
            
            tb_RoundName.Text = Calendar[RoundNo - 1].GetRoundName();

            if (Calendar[RoundNo - 1].GetLengthType() == "Laps")
            {
                tb_RaceLength.Text = Convert.ToString(Calendar[RoundNo - 1].GetRaceLength()) + " Laps";
            }

            else if (Calendar[RoundNo - 1].GetLengthType() == "WEC")
            {
                tb_RaceLength.Text = Convert.ToString(Calendar[RoundNo - 1].GetRaceLength() / 2) + " Hours";
            }

            else if (Calendar[RoundNo - 1].GetLengthType() == "IMSA")
            {
                tb_RaceLength.Text = CD.GetIMSADistance(Calendar[RoundNo - 1].GetRaceLength());
            }

            ClassTBs = new List<TextBox>();
            LoadBoxes(ClassTBs);

            LoadClassColumn();

            if (tb_RoundName.Text == "24 Heures du Mans" || tb_RoundName.Text == "24 Hours of Silverstone")
            {
                LMS = true;
            }

            else
            {
                LMS = false;
            }

            Session = "Qualifying";

            btn_ViewPodium.Text = "View Top 8";
        }

        private List<Entrant> GetLeaders(List<Entrant> Entrants)
        {
            List<Entrant> Leaders = new List<Entrant>();

            for (int CC = 0; CC < CD.GetClassCount(); CC++)
            {
                for (int EC = 0; EC < Entrants.Count; EC++)
                {
                    if (!RA.ClassExistsInEntrants(Entrants[EC].GetClass(), Leaders))
                    {
                        Leaders.Add(Entrants[EC]);
                    }
                }
            }

            RA.IndexSort(Leaders);

            return Leaders;
        }

        private void SetLeaders(List<Entrant> Leaders)
        {
            int TBI = 0;

            for (int LI = 0; LI < Leaders.Count; LI++)
            {
                ClassTBs[TBI + 1].Text = Leaders[LI].GetCrew();
                ClassTBs[TBI + 2].Text = Leaders[LI].GetCar();

                TBI += 3;
            }
        }

        private void LoadBoxes(List<TextBox> ClassTBs)
        {
            ClassTBs.Add(tb_C1_Class);
            ClassTBs.Add(tb_C1_Team);
            ClassTBs.Add(tb_C1_Car);

            ClassTBs.Add(tb_C2_Class);
            ClassTBs.Add(tb_C2_Team);
            ClassTBs.Add(tb_C2_Car);

            ClassTBs.Add(tb_C3_Class);
            ClassTBs.Add(tb_C3_Team);
            ClassTBs.Add(tb_C3_Car);

            ClassTBs.Add(tb_C4_Class);
            ClassTBs.Add(tb_C4_Team);
            ClassTBs.Add(tb_C4_Car);

            ClassTBs.Add(tb_C5_Class);
            ClassTBs.Add(tb_C5_Team);
            ClassTBs.Add(tb_C5_Car);

            ClassTBs.Add(tb_C6_Class);
            ClassTBs.Add(tb_C6_Team);
            ClassTBs.Add(tb_C6_Car);
        }

        private void LoadClassColumn()
        {
            int TBI = 0;

            List<string> Classes = Calendar[RoundNo - 1].GetShortRacingClasses();

            for (int CI = 0; CI < Classes.Count(); CI++)
            {
                int CN = Convert.ToInt32(Classes[CI].Replace('C', ' ')) - 1;

                ClassTBs[TBI].Text = CD.GetClasses(CN).GetClassName();
                TBI += 3;
            }

            for (int TI = TBI; TI < ClassTBs.Count; TI++)
            {
                ClassTBs[TI].Visible = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ViewPodium_Click(object sender, EventArgs e)
        {
            if (btn_ViewPodium.Text == "View Top 8")
            {
                ViewClassOrder VCO = new ViewClassOrder(CD, RA);

                ActiveVCOs.Add(VCO);

                List<Entrant> Top8 = VCO.GetTop8(EntryList);
                List<Entrant> Overall = VCO.GetTop8Overall(EntryList);

                VCO.LoadLeaders(Top8, Overall, EntryList);
                VCO.Show();
            }

            else
            {
                if (Session == "Qualifying")
                {
                    if (!LMS)
                    {
                        Podiums QualiR = new Podiums(CD, RA);

                        ActivePodiums.Add(QualiR);

                        List<Entrant> Podiums = QualiR.GetPodium(EntryList);
                        List<Entrant> Overall = QualiR.GetOverallPodium(EntryList);

                        QualiR.LoadLeaders(PoleSitters, Podiums, Overall, Session, LMS);
                        QualiR.Show();
                    }

                    else
                    {
                        Podiums QualiR = new Podiums(CD, RA);

                        ActivePodiums.Add(QualiR);

                        List<Entrant> Top5s = QualiR.GetTop5(EntryList);
                        List<Entrant> Overall = QualiR.GetOverallTop5(EntryList);

                        QualiR.LoadLeaders(PoleSitters, Top5s, Overall, Session, LMS);
                        QualiR.Show();
                    }
                }

                else if (Session == "Race")
                {
                    Podiums Podium = new Podiums(CD, RA);

                    ActivePodiums.Add(Podium);

                    List<Entrant> Podiums = Podium.GetPodium(EntryList);
                    List<Entrant> Overall = Podium.GetOverallPodium(EntryList);

                    Podium.LoadLeaders(PoleSitters, Podiums, Overall, Session, LMS);
                    Podium.Show();
                }
            }
        }

        private void btn_NextRace_Click(object sender, EventArgs e)
        {
            if (CD.GetRoundNo() + 1 > Calendar.Count)
            {
                MessageBox.Show("That's It!" + Environment.NewLine +
                    "The Calendar is now Complete, the Season's over!" + Environment.NewLine + Environment.NewLine +
                    "Press Enter, or Click OK, to Exit the Program.", "Season Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }

            else
            {
                CD.SetRoundNo(CD.GetRoundNo() + 1);
            }

            SimRace NextRound = new SimRace(Calendar, CD, Rand);

            this.Close();
            ClosePodiums();
            NextRound.Show();
        }

        private void btn_Advance_Click(object sender, EventArgs e)
        {
            if (btn_Advance.Text == "Start Qualifying")
            {
                tb_RaceLength.Text = "3 Sessions";
                tb_CurrentStint.Text = "Qualifying 1";

                Sim.Qualifying(EntryList, EntryList.Count, 1, Test);

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                btn_Advance.Text = "Continue Qualifying";
            }

            else if (btn_Advance.Text == "Continue Qualifying")
            {
                tb_CurrentStint.Text = "Qualifying 2";

                Sim.Qualifying(EntryList, EntryList.Count, 2, Test);

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                btn_Advance.Text = "Finish Qualifying";
            }

            else if (btn_Advance.Text == "Finish Qualifying")
            {
                tb_CurrentStint.Text = "Qualifying 3";

                Sim.Qualifying(EntryList, EntryList.Count, 3, Test);

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                PoleSitters = Leaders;

                btn_Advance.Text = "Start Race";

                btn_ViewPodium.Text = "View Podium";
            }

            else if (btn_Advance.Text == "Start Race")
            {
                btn_ViewPodium.Text = "View Top 8";

                ClosePodiums();

                Session = "Race";

                if (Calendar[RoundNo - 1].GetLengthType() == "WEC")
                {
                    tb_CurrentStint.Text = CD.GetWECDistance(RStint);
                    tb_RaceLength.Text = CD.GetWECDistance(Calendar[RoundNo - 1].GetRaceLength());
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "IMSA")
                {
                    tb_CurrentStint.Text = CD.GetIMSADistance(RStint);
                    tb_RaceLength.Text = CD.GetIMSADistance(Calendar[RoundNo - 1].GetRaceLength());
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "Laps")
                {
                    tb_CurrentStint.Text = CD.GetLapsDistance(RStint);
                    tb_RaceLength.Text = CD.GetLapsDistance(Calendar[RoundNo - 1].GetRaceLength()) + " Laps";
                }

                Sim.SetGrid(EntryList, 10);

                Sim.Race(EntryList);
                RStint++;

                Save.SaveStint(EntryList, CD, "Stint " + (RStint - 1), Test);

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                btn_Advance.Text = "Simulate Stint " + RStint;
            }

            else if (btn_Advance.Text.StartsWith("Simulate Stint"))
            {
                if (Calendar[RoundNo - 1].GetLengthType() == "WEC")
                {
                    tb_CurrentStint.Text = CD.GetWECDistance(RStint);
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "IMSA")
                {
                    tb_CurrentStint.Text = CD.GetIMSADistance(RStint);
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "Laps")
                {
                    tb_CurrentStint.Text = CD.GetLapsDistance(RStint);
                }

                Sim.Race(EntryList);
                RStint++;

                Save.SaveStint(EntryList, CD, "Stint " + (RStint - 1), Test);

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                if (RStint == Calendar[RoundNo - 1].GetRaceLength())
                {
                    btn_Advance.Text = "Finish Race";
                }

                else
                {
                    btn_Advance.Text = "Simulate Stint " + RStint;
                }
            }

            else if (btn_Advance.Text == "Finish Race")
            {
                if (Calendar[RoundNo - 1].GetLengthType() == "WEC")
                {
                    tb_CurrentStint.Text = CD.GetWECDistance(RStint);
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "IMSA")
                {
                    tb_CurrentStint.Text = CD.GetIMSADistance(RStint);
                }

                else if (Calendar[RoundNo - 1].GetLengthType() == "Laps")
                {
                    tb_CurrentStint.Text = CD.GetLapsDistance(RStint);
                }

                Sim.Race(EntryList);
                RStint++;

                List<Entrant> Leaders = GetLeaders(EntryList);
                SetLeaders(Leaders);

                Save.SaveStint(EntryList, CD, "Race Results", Test);

                btn_Advance.Visible = false;
                btn_ViewPodium.Text = "View Podium";
                btn_NextRace.Visible = true;
            }
        }

        private void ClosePodiums()
        {
            foreach (Podiums P in ActivePodiums)
            {
                P.CloseAllPodiums();
                P.Hide();
            }

            foreach (ViewClassOrder VCO in ActiveVCOs)
            {
                VCO.Hide();
            }
        }
    }
}