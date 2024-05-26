using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup.Localizer;
using System.Windows.Media.TextFormatting;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace WindowsFormsApp_Diplom
{
    public partial class PatientForm : Form
    {
        Patient Patient;
        Controller Controller;
    
        public PatientForm()
        {
            Controller = new Controller();
            InitializeComponent();
            this.tB_firstname.KeyPress += new KeyPressEventHandler(tB_KeyPress);
            this.tb_lastname.KeyPress += new KeyPressEventHandler(tB_KeyPress);
            this.tb_name.KeyPress += new KeyPressEventHandler(tB_KeyPress);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Controller.check_tb_empty(tB_firstname, "фамилию") && Controller.check_tb_empty(tb_name, "имя") 
                &&  Controller.check_tb_empty(tb_lastname, "отчество") 
                && Controller.check_combobox_empty(cB_genger, "пол") )
            {
                Patient = new Patient(tB_firstname.Text, tb_name.Text, tb_lastname.Text, cB_genger.Text, dateTimePicker_BirthD.Value);
                //this.Hide();
                
                COPDQuestForm Form1 = new COPDQuestForm(Patient);
                Form1.ShowDialog();
                this.Close();
            }
        }         
        public void open(object obj)
            {

                Application.Run(new COPDQuestForm());

            }

        private void tB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar) || 
                (!string.IsNullOrEmpty((sender as TextBox).Text) && e.KeyChar == '-') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }

            e.Handled = true;

        }
    }
}
