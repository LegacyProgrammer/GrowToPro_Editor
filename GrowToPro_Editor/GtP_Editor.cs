using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrowToPro_Editor
{
    public partial class GtP_Editor : Form
    {

        public GtP_Editor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkillSelectbox.Text = "Selecteer soort vraag!";
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            //Makes "Selecteer soort vraag!" disappear after clicking the comboBox.
            if (SkillSelectbox.Items.Contains("Selecteer soort vraag!"))
            {
                SkillSelectbox.Items.Remove("Selecteer soort vraag!");
            }

        }

        //The DropdownClosed will make sure the text "Selecteer soort vraag!" Returns if there is no selection.
        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            #region SkillList
            List<string> index = new List<string>();

            index.Add("Artistiek");
            index.Add("Realistisch");
            index.Add("Intellectueel");
            index.Add("Sociaal");
            index.Add("Ondernemend");
            index.Add("Conventioneel");

            #endregion

            #region Combobox Tekst
            if (SkillSelectbox.Text != "")
            {

                SkillSelectbox.Text = SkillSelectbox.Text;
            }

            else
            {
                SkillSelectbox.Items.Add("Selecteer soort vraag!");
                SkillSelectbox.Text = "Selecteer soort vraag!";
            }



            #endregion

            if (SkillSelectbox.Text == "Artistiek")
            {
                #region Vraag TB

                TextBox VraagTB = new TextBox();
                VraagTB.Width = 400;
                VraagTB.Location = new Point(370, 90);
                this.Controls.Add(VraagTB);

                #endregion

                #region Vraag Label

                Label VraagLb = new Label();
                VraagLb.Width = 500;
                VraagLb.BackColor = Color.Transparent;
                VraagLb.Location = new Point(370, 70);
                VraagLb.Text = "Wat wordt de vraag die U wilt toevoegen?";
                this.Controls.Add(VraagLb);

                #endregion

                #region Antwoord TextBoxes (A t/m D)

                TextBox Antwoord_A = new TextBox();
                Antwoord_A.Width = 150;
                Antwoord_A.Location = new Point(370, 200);
                this.Controls.Add(Antwoord_A);

                TextBox Antwoord_B = new TextBox();
                Antwoord_B.Width = 150;
                Antwoord_B.Location = new Point(600, 200);
                this.Controls.Add(Antwoord_B);

                TextBox Antwoord_C = new TextBox();
                Antwoord_C.Width = 150;
                Antwoord_C.Location = new Point(600, 280);
                this.Controls.Add(Antwoord_C);

                TextBox Antwoord_D = new TextBox();
                Antwoord_D.Width = 150;
                Antwoord_D.Location = new Point(370, 280);
                this.Controls.Add(Antwoord_D);

                #endregion

                #region Antwoord Labels (A t/m D)
                Label Antwoord_A_Lb = new Label();
                Antwoord_A_Lb.Width = 150;
                Antwoord_A_Lb.BackColor = Color.Transparent;
                Antwoord_A_Lb.Location = new Point(370, 180);
                Antwoord_A_Lb.Text = "Het antwoord voor optie A";
                this.Controls.Add(Antwoord_A_Lb);

                Label Antwoord_B_Lb = new Label();
                Antwoord_B_Lb.Width = 150;
                Antwoord_B_Lb.BackColor = Color.Transparent;
                Antwoord_B_Lb.Location = new Point(600, 180);
                Antwoord_B_Lb.Text = "Het antwoord voor optie B";
                this.Controls.Add(Antwoord_B_Lb);

                Label Antwoord_C_Lb = new Label();
                Antwoord_C_Lb.Width = 150;
                Antwoord_C_Lb.BackColor = Color.Transparent;
                Antwoord_C_Lb.Location = new Point(370, 260);
                Antwoord_C_Lb.Text = "Het antwoord voor optie C";
                this.Controls.Add(Antwoord_C_Lb);

                Label Antwoord_D_Lb = new Label();
                Antwoord_D_Lb.Width = 150;
                Antwoord_D_Lb.BackColor = Color.Transparent;
                Antwoord_D_Lb.Location = new Point(600, 260);
                Antwoord_D_Lb.Text = "Het antwoord voor optie D";
                this.Controls.Add(Antwoord_D_Lb);
                #endregion

            }
            else
            {
                this.Controls.Clear();
                InitializeComponent();
                SkillSelectbox.Text = "Selecteer soort vraag!";
                
            }
        }

       }
   }
    



    

