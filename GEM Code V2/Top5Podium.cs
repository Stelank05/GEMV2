using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GEM_Code_V2
{
    public partial class Top5Podium : Form
    {
        string Class;

        RaceAdmin RA = new RaceAdmin();

        List<Entrant> Overall = new List<Entrant>();
        List<Entrant> Podium = new List<Entrant>();

        List<TextBox> TBS = new List<TextBox>();

        public Top5Podium()
        {
            InitializeComponent();
        }

        public void LoadResults(List<Entrant> Entrants, string Class)
        {
            GetPodium(Entrants, Class);

            this.Text = Class + " Top 5";
            tb_ClassTop5.Text = "Class Podium - " + Class;
        }

        public void LoadOverall(List<Entrant> Entrants)
        {
            Class = "Overall";

            GetPodiumOverall(Entrants);

            this.Text = "Overall Top 5";
            tb_ClassTop5.Text = "Overall Top 5";
        }

        private void GetPodium(List<Entrant> Entrants, string Class)
        {
            foreach (Entrant EntrantData in Entrants)
            {
                if (RA.EntrantExistsInEntrants(EntrantData, Podium))
                {
                    break;
                }

                else
                {
                    if (EntrantData.GetClass() == Class)
                    {
                        Podium.Add(EntrantData);
                    }
                }

                if (Podium.Count == 5)
                {
                    break;
                }
            }
        }

        private void GetPodiumOverall(List<Entrant> Entrants)
        {
            foreach (Entrant ED in Entrants)
            {
                Overall.Add(ED);

                if (Overall.Count == 5)
                {
                    break;
                }
            }
        }

        private void btn_ShowPodium_Click(object sender, EventArgs e)
        {
            btn_ShowPodium.Visible = false;

            LoadTBS();

            if (Class == "Overall")
            {
                int I = 0;

                foreach (Entrant ED in Overall)
                {
                    TBS[I].Text = ED.GetCrew();
                    TBS[I + 1].Text = ED.GetCar();

                    I += 2;
                }
            }

            else
            {
                int I = 0;

                foreach (Entrant ED in Podium)
                {
                    TBS[I].Text = ED.GetCrew();
                    TBS[I + 1].Text = ED.GetCar();

                    I += 2;
                }
            }
        }

        private void LoadTBS()
        {
            TBS.Add(tb_TeamP1);
            TBS.Add(tb_CarP1);

            TBS.Add(tb_TeamP2);
            TBS.Add(tb_CarP2);

            TBS.Add(tb_TeamP3);
            TBS.Add(tb_CarP3);

            TBS.Add(tb_TeamP4);
            TBS.Add(tb_CarP4);

            TBS.Add(tb_TeamP5);
            TBS.Add(tb_CarP5);
        }
    }
}