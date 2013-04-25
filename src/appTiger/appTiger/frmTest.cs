using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appTiger
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnExecTest_Click(object sender, EventArgs e)
        {
            frmCalcator objTestForm = new frmCalcator();

            objTestForm.tbxExpression.Text = "10 * 10";
            objTestForm.btnExec_Click(sender,e);
            if (!isEqual(objTestForm.labResult.Text, string.Format("{0:N}", 100)))
                return;

            objTestForm.tbxExpression.Text = "1 * 2 * 3 * 4 * 5 * 6";
            objTestForm.btnExec_Click(sender, e);
            if (!isEqual(objTestForm.labResult.Text, string.Format("{0:N}", 720)))
                return;

            objTestForm.tbxExpression.Text = "5 + 5 + 10 * 2 + 1";
            objTestForm.btnExec_Click(sender, e);
            if (!isEqual(objTestForm.labResult.Text, string.Format("{0:N}", 31)))
                return;

            objTestForm.tbxExpression.Text = "100 / 5 - 5";
            objTestForm.btnExec_Click(sender, e);
            if (!isEqual(objTestForm.labResult.Text, string.Format("{0:N}", 15)))
                return;

            MessageBox.Show(
                "テストが成功しました。",
                clsConsts.strApplicationName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private bool isEqual(string strHope, string strReal)
        {
            if (strReal != strHope)
            {
                MessageBox.Show(
                    "テストが失敗しました。"
                    + "期待値=[" + strHope + "], "
                    + "実施値=[" + strReal + "]",
                    clsConsts.strApplicationName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}