using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GEM_Code_V2
{
    public partial class StartWindow : Form
    {
        RaceAdmin RA = new RaceAdmin();
        CommonData CD = new CommonData();
        Random Rand = new Random();

        List<Round> Calendar = new List<Round>();

        public StartWindow()
        {
            InitializeComponent();

            RA.GetCalendar(Calendar);
            LoadCalendar(Calendar);

            CD.SetPaths();
        }

        private void btn_ChooseRnd_Click(object sender, EventArgs e)
        {
            if (lb_Calendar.SelectedItem == null)
            {
                MessageBox.Show("You haven't Selected a Race!" + Environment.NewLine + 
                    "Select One to be able to Race!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                CD.SetRoundNo(lb_Calendar.SelectedIndex + 1);

                SimRace SR = new SimRace(Calendar, CD, Rand);
                SR.Show();
            }
        }

        private void LoadCalendar(List<Round> Calendar)
        {
            for (int R = 0; R < Calendar.Count; R++)
            {
                lb_Calendar.Items.Add(Calendar[R].GetRoundName());
            }
        }

        private void btn_CreateCrew_Click(object sender, EventArgs e)
        {
            MakeCar MC = new MakeCar();
            MC.Show();
        }

        private void btn_CreateCar_Click(object sender, EventArgs e)
        {
            CarEditor CE = new CarEditor();
            CE.Show();
        }

        private void btn_DeleteAllCrews_Click(object sender, EventArgs e)
        {
            ChooseDelete CD = new ChooseDelete();
            CD.Show();
        }
    }
}