using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();

                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void pcbAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();

                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();

                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("", "", "", "Prelim", "Quiz", "", "Midterm", "Quiz", "", "Finals", "Quiz");
            dataGridView1.Rows.Add("", "", "", "", "Laboratory", "", "", "Laboratory", "", "", "Laboratory");
            dataGridView1.Rows.Add("", "", "", "", "Seatwork", "", "", "Practical Exam", "", "", "Project");
            dataGridView1.Rows.Add("", "", "", "", "Attendance");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[1].Value = null;
            dataGridView1.Rows[0].Cells[1].Value = txtName.Text;
            txtName.Clear();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = null;
            dataGridView1.Rows[0].Cells[0].Value = txtID.Text;
            txtID.Clear();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[2].Value = null;
            dataGridView1.Rows[0].Cells[2].Value = txtCourse.Text;
            txtCourse.Clear();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[5].Value = null;
            double quiz = Convert.ToDouble(txtQuiz.Text);
            if (quiz < 0 || quiz > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[0].Cells[5].Value = quiz.ToString();
            }
            txtQuiz.Clear();
        }

        private void btnQuzi2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[8].Value = null;
            double quiz2 = Convert.ToDouble(txtQuiz2.Text);
            if (quiz2 < 0 || quiz2 > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[0].Cells[8].Value = quiz2.ToString();
            }
            txtQuiz2.Clear();
        }

        private void btnQuiz3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[11].Value = null;
            double quiz3 = Convert.ToDouble(txtQuiz3.Text);
            if (quiz3 < 0 || quiz3 > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[0].Cells[11].Value = quiz3.ToString();
            }
            txtQuiz3.Clear();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].Cells[5].Value = null;
            double LAB = Convert.ToDouble(txtLab.Text);
            if (LAB < 0 || LAB > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[1].Cells[5].Value = LAB.ToString();
            }
            txtLab.Clear();
        }

        private void btnLab2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].Cells[8].Value = null;
            double LAB2 = Convert.ToDouble(txtLab2.Text);
            if (LAB2 < 0 || LAB2 > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[1].Cells[8].Value = LAB2.ToString();
            }
            txtLab2.Clear();
        }

        private void btnLab3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].Cells[11].Value = null;
            double LAB3 = Convert.ToDouble(txtLab3.Text);
            if (LAB3 < 0 || LAB3 > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[1].Cells[11].Value = LAB3.ToString();
            }
            txtLab3.Clear();
        }

        private void btnSeatwork_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[2].Cells[5].Value = null;
            double SW = Convert.ToDouble(txtSeatwork.Text);
            if (SW < 0 || SW > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[2].Cells[5].Value = SW.ToString();
            }
            txtSeatwork.Clear();
        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[2].Cells[8].Value = null;
            double PE = Convert.ToDouble(txtPE.Text);
            if (PE < 0 || PE > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[2].Cells[8].Value = PE.ToString();
            }
            txtPE.Clear();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[2].Cells[11].Value = null;
            double proj = Convert.ToDouble(txtProject.Text);
            if (proj < 0 || proj > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[2].Cells[11].Value = proj.ToString();
            }
            txtProject.Clear();
        }

        private void btnAttendace_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[3].Cells[5].Value = null;
            double att = Convert.ToDouble(txtAttendance.Text);
            if(att < 0 || att > 100)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                dataGridView1.Rows[3].Cells[5].Value = att.ToString();
            }
            txtAttendance.Clear();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string PResult, MResult, FResult, FGResult;

            double PQuiz = Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value.ToString());
            double PLab = Convert.ToDouble(dataGridView1.Rows[1].Cells[5].Value.ToString());
            double PSeatwork = Convert.ToDouble(dataGridView1.Rows[2].Cells[5].Value.ToString());
            double PAttendance = Convert.ToDouble(dataGridView1.Rows[3].Cells[5].Value.ToString());
            double MQuiz = Convert.ToDouble(dataGridView1.Rows[0].Cells[8].Value.ToString());
            double MLab = Convert.ToDouble(dataGridView1.Rows[1].Cells[8].Value.ToString());
            double MPE = Convert.ToDouble(dataGridView1.Rows[2].Cells[8].Value.ToString());
            double FQuiz = Convert.ToDouble(dataGridView1.Rows[0].Cells[11].Value.ToString());
            double FLab = Convert.ToDouble(dataGridView1.Rows[1].Cells[11].Value.ToString());
            double FProject = Convert.ToDouble(dataGridView1.Rows[2].Cells[11].Value.ToString());

            //Prelim
            double Quiz = PQuiz / 100 * .40;
            double Lab = PLab / 100 * .50;
            double Seatwork = PSeatwork / 100 * .05;
            double Attendance = PAttendance / 100 * .05;

            double PrelimResult = (Quiz + Lab + Seatwork + Attendance) * 100;
            PrelimResult = Math.Round(PrelimResult, 2);
            if (PrelimResult >= 100)
            {
                PResult = "100";
            }
            else if (PrelimResult <= 65)
            {
                PResult = "65";
            }
            else
            {
                PResult = PrelimResult.ToString();
            }

            //Midterm
            double Quiz2 = MQuiz / 100 * .20;
            double Lab2 = MLab / 100 * .50;
            double PracticalExam = MPE / 100 * .30;

            double MidtermResult = (Quiz2 + Lab2 + PracticalExam) * 100;
            MidtermResult = Math.Round(MidtermResult, 2);
            if (MidtermResult >= 100)
            {
                MResult = "100";
            }
            else if (MidtermResult <= 65)
            {
                MResult = "65";
            }
            else
            {
                MResult = MidtermResult.ToString();
            }

            //Finals
            double Quiz3 = FQuiz / 100 * .30;
            double Lab3 = FLab / 100 * .50;
            double Project = FProject / 100 * .20;

            double FinalsResult = (Quiz3 + Lab3 + Project) * 100;
            FinalsResult = Math.Round(FinalsResult, 2);
            if (FinalsResult >= 100)
            {
                FResult = "100";
            }
            else if (FinalsResult <= 65)
            {
                FResult = "65";
            }
            else
            {
                FResult = FinalsResult.ToString();
            }

            //FinalGrade
            double PrelimGrade = PrelimResult / 100 * .20;
            double MidtermGrade = MidtermResult / 100 * .40;
            double FinalsGrade = FinalsResult / 100 * .40;

            double FinalResult = (PrelimGrade + MidtermGrade + FinalsGrade) * 100;
            FinalResult = Math.Round(FinalResult, 2);
            if (FinalResult >= 100)
            {
                FGResult = "100";
            }
            else if (FinalResult <= 65)
            {
                FGResult = "65";
            }
            else
            {
                FGResult = FinalResult.ToString();
            }

            //ListBox
            lstRecords.Items.Add($"               Final Result");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"\n")
            lstRecords.Items.Add($"Student ID: {dataGridView1.Rows[0].Cells[0].Value}");
            lstRecords.Items.Add($"Student Name: {dataGridView1.Rows[0].Cells[1].Value}");
            lstRecords.Items.Add($"Course: {dataGridView1.Rows[0].Cells[2].Value}");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"Prelim Grade: {PResult}");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"Midterm Grade: {MResult}");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"Finals Grade: {FResult}");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"Final Grade: {FGResult}");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"\n");
            lstRecords.Items.Add($"               KEEP IT UP!! ");




        }
    }
}
