using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Diplom
{
    public class Controller
    {
       
        public void CreateMainForm()
        {

        }
        public void ShowExpertSystemForm()
        {

        }
        public void ShowFormPatient()
        {

        }
        public void ShowResultsForm()
        {

        }

        public bool check_tb_empty(object sender, string text)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                MessageBox.Show($"Введите {text}!", "Ошибка входных данных");
                return false;
            }
            return true;
        }

        public bool check_combobox_empty(object sender, string text)
        {
            if (string.IsNullOrEmpty((sender as ComboBox).Text))
            {

                MessageBox.Show($"Введите {text} пациента!", "Ошибка входных данных");
                return false;
            }
            return true;
        }


        public bool check_numericupdown_zero(object sender, string text)
        {
            if ((sender as NumericUpDown).Value > 0)
                return true;
            else {
                MessageBox.Show($"Введите {text} пациента!", "Ошибка входных данных");
                return false; }
        }

    }
}
