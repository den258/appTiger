using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appTiger
{
    public partial class frmCalcator : Form
    {
        public frmCalcator()
        {
            InitializeComponent();
        }

        public void btnExec_Click(object sender, EventArgs e)
        {

            if (this.tbxExpression.Text == "")
            {
            
                MessageBox.Show(
                    "式を入力してください。",
                    clsConsts.strApplicationName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            
            }

            clsExpression objExpression = 
                new clsExpression(this.tbxExpression.Text);

            if (objExpression.validate())
            {
                this.labResult.Text = string.Format("{0:N}",objExpression.execute());
            }

        }

    }

}