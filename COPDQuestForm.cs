using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Threading;

namespace WindowsFormsApp_Diplom
{
    
    public partial class COPDQuestForm : Form
    { 
        public  QuestCOPD questionCOPD; // = new ExpertSystem;
        public  Patient Patient;
        bool correct_data;
        QuestCOPD EScopd;
        bool boolrestest;
        Controller Controller;
        Thread th;

        public COPDQuestForm()
        {
            Controller = new Controller();
            InitializeComponent();
            EScopd = new QuestCOPD();
        }
        public COPDQuestForm(Patient patient): this()
        {          
            this.Patient = patient;
        }
        
       private void Set_patient (Patient patient)
        {
            Patient = patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            init_test_copd();

            // здесь будет открытие следующей формы
        }





        private void init_test_copd()
        {

            if (Controller.check_numericupdown_zero(weight_numericUpDown, "вес") &&  Controller.check_numericupdown_zero(height_numericUpDown, "рост"))
            {
                EScopd.set_weight(Convert.ToInt32(weight_numericUpDown.Value));
                EScopd.set_height(Convert.ToInt32(height_numericUpDown.Value));
                correct_data = true;
            }    

            if (correct_data)
            {

                EScopd.set_BD(Patient.get_BD_patient());
                EScopd.set_sigday(Convert.ToInt32(sigar_day_numericUpDown.Value));
                EScopd.set_exper_smoke(Convert.ToInt32(sigar_exper_numericUpDown.Value));


                EScopd.set_bad_weather_cough(bad_weather_sputum_cough_checkBox.Checked);
                EScopd.set_cough_sputum_outside_colds(colds_cough_sputum_checkBox.Checked);
                EScopd.set_morning_sputum_cough(morning_cough_checkBox.Checked);
                EScopd.set_dyspnea(sometimes_radioButton.Checked);
                EScopd.set_allergy(allergy_checkBox.Checked);

                boolrestest = EScopd.test_copd();
                int res_test_copd = EScopd.get_test_copd_score();

                lb_result.Text = String.Format("Результат: {0} баллов", res_test_copd);
                lb_result.BackColor = Color.White;
                lb_result.Visible = true;
                button_next.Visible = true;

            }

        }

        public void open(object obj)
        {

            Application.Run(new ExpertSystemForm(boolrestest));

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!correct_data)
            {
                MessageBox.Show("Введите все данные!", "Ошибка входных данных!", MessageBoxButtons.OK);
            }
            else
            {
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
        }
    }
}
