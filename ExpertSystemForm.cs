using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Diplom
{
    public partial class ExpertSystemForm : Form
    {
        bool testCOPD;
        ExpertSystem es;
        public ExpertSystemForm(bool test_COPD)
        {
            InitializeComponent();
            testCOPD = test_COPD;
        }


        private void ExpertSystemForm_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            es = new ExpertSystem();
            es.createES();
            es.restart(Start, lb,resinfo, bt1, bt2);
        }

        private void bt1_Click(object sender, EventArgs e)
        {

            es.ca = 0;
            es.checkans(lb, resinfo ,bt1, bt2);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            es.ca = 1;
            es.checkans(lb, resinfo, bt1, bt2);
        }
    }
}
