using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace appTiger
{
    class clsExpression
    {
        List<clsTerm> objExpression = new List<clsTerm>();
     
        public clsExpression(string strExpression)
        {
            foreach (string strTerm in strExpression.Split(' '))
            {
                objExpression.Add(new clsTerm(strTerm));

            }

        }

        public bool validate()
        {
        
            foreach (clsTerm objTerm in objExpression)
            {
                if (objTerm.getStrTag() == "Error")
                {

                    MessageBox.Show(
                        "式の値と演算子がスペースで区切られていないようです。",
                        clsConsts.strApplicationName,
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);

                    return false;

                }

            }

            for (int intIndex = 0; intIndex < objExpression.Count; intIndex++ )
            {
                if (objExpression[intIndex].getStrTag() == clsTerm.CONST_OPERATOR)
                {
                    if (intIndex == 0 || intIndex+1 > objExpression.Count - 1)
                    {
                        MessageBox.Show(
                            "構文に誤りがあるようです。演算子の前後を指定してください。",
                            clsConsts.strApplicationName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (!objExpression[intIndex - 1].getStrTag().Equals(clsTerm.CONST_NUMBER) ||
                                !objExpression[intIndex + 1].getStrTag().Equals(clsTerm.CONST_NUMBER))
                        {
                            MessageBox.Show(
                                "構文に誤りがあるようです。演算子の前後には、数値を指定してください。",
                                clsConsts.strApplicationName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

            }

            return true;

        }

        public double execute(string strArgNumber1,string strArgOperator,string strArgNumber2)
        {

            double dblNumber1 = new double();
            double dblNumber2 = new double();

            double.TryParse(strArgNumber1, out dblNumber1);
            double.TryParse(strArgNumber2, out dblNumber2);
            
            switch (strArgOperator)
            {
                case "+":
                    return dblNumber1 + dblNumber2;
                case "-":
                    return dblNumber1 - dblNumber2;
                case "*":
                    return dblNumber1 * dblNumber2;
                case "/":
                    return dblNumber1 / dblNumber2;
                default:
                    return 0;
            }

        }

        public double execute()
        {

            List<int> objExecSeqList = new List<int>();

            for (int intIndex = 0; intIndex < objExpression.Count; intIndex++)
            {
                if (objExpression[intIndex].getStrTag() == clsTerm.CONST_OPERATOR)
                {
                    if (objExpression[intIndex].getStrTerm() == "*"
                            || objExpression[intIndex].getStrTerm() == "/")
                    {
                        objExecSeqList.Add(intIndex);
                    }
                }
            }

            for (int intIndex = 0; intIndex < objExpression.Count; intIndex++)
            {
                if (objExpression[intIndex].getStrTag() == clsTerm.CONST_OPERATOR)
                {
                    if (objExpression[intIndex].getStrTerm() == "+"
                            || objExpression[intIndex].getStrTerm() == "-")
                    {
                        objExecSeqList.Add(intIndex);
                    }
                }
            }

            for (int intIndex0 = 0; intIndex0 < objExecSeqList.Count; intIndex0++ )
            {

                string strNumber =
                    string.Format("{0:N}",
                        execute(
                            objExpression[objExecSeqList[intIndex0] - 1].getStrTerm(),
                            objExpression[objExecSeqList[intIndex0]].getStrTerm(),
                            objExpression[objExecSeqList[intIndex0] + 1].getStrTerm()));

                objExpression.RemoveAt(objExecSeqList[intIndex0] - 1);
                objExpression.RemoveAt(objExecSeqList[intIndex0] - 1);
                objExpression.RemoveAt(objExecSeqList[intIndex0] - 1);

                objExpression.Insert(objExecSeqList[intIndex0] - 1, new clsTerm(strNumber));

                for (int intIndex1 = 0; intIndex1 < objExecSeqList.Count; intIndex1++)
                {
                    if (objExecSeqList[intIndex1] > objExecSeqList[intIndex0])
                    {
                        objExecSeqList[intIndex1] -= 2;
                    }
                }

            }

            return double.Parse(objExpression[0].getStrTerm());

        }

    }
}
