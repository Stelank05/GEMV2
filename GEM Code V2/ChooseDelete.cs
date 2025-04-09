using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace GEM_Code_V2
{
    public partial class ChooseDelete : Form
    {
        CommonData CD = new CommonData();
        RaceAdmin RA = new RaceAdmin();

        string FilePath;
        List<Entrant> EntrantList = new List<Entrant>();

        public ChooseDelete()
        {
            InitializeComponent();

            CD.LoadClasses();

            for (int i = 0; i < CD.GetClassCount(); i++)
            {
                lb_Classes.Items.Add(CD.GetClasses(i).GetClassName());
            }
        }

        private void LoadEntrants()
        {
            lb_Entrants.Items.Clear();

            foreach (Entrant E in EntrantList)
            {
                lb_Entrants.Items.Add(E.GetCrew());
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            int SelectedClass = lb_Classes.SelectedIndex;
            
            FilePath = Path.Combine(CD.GetSetupPath(), "Entrants", "Class " + Convert.ToString(SelectedClass + 1) + ".csv");

            EntrantList.Clear();
            EntrantList = RA.LoadEntrants(FilePath, SelectedClass);

            LoadEntrants();
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            EntrantList.Clear();

            lb_Entrants.Items.Clear();
        }

        private void btn_DeleteSelected_Click(object sender, EventArgs e)
        {
            EntrantList.RemoveAt(lb_Entrants.SelectedIndex);

            LoadEntrants();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (EntrantList.Count > 0)
            {
                string WriteString = "";

                foreach (Entrant E in EntrantList)
                {
                    WriteString += E.GetClass() + "," + E.GetCarNo() + "," + E.GetTeamName() + "," + E.GetCar() + "," + E.GetBaseOVR() + ",," + E.GetSRM() + ",," + E.GetReliability() + Environment.NewLine;
                }

                File.WriteAllText(FilePath, WriteString);
            }

            else
            {
                File.Create(FilePath).Close();
            }
        }
    }
}
