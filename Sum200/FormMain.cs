using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i <= 200; i++) 
            {
                sum += i;
                if(i == 100) TxtHalfway.Text = Convert.ToString(sum);
                Console.WriteLine("i = " + i + " sum = " + sum);
            }

            TxtTotal.Text = Convert.ToString(sum);
        }//end button event 
    }//end class
}//end namespace
