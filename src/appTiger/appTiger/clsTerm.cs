using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace appTiger
{
    class clsTerm
    {
        private string strTerm = null;
        private string strTag = null;

        public const string CONST_NUMBER = "Number";
        public const string CONST_OPERATOR = "Operator";
        public const string CONST_ERROR = "Error";
        public const string CONST_OTHER = "";

        public clsTerm(string strArgTerm)
        {
            this.strTerm = strArgTerm;
            this.strTag = getType(strArgTerm);
        }

        public string getStrTag()
        {
            return strTag;
        }

        public string getStrTerm()
        {
            return strTerm;
        }

        public string getType(string strArgTerm)
        {
            if (isNumber(strArgTerm))
            {
                return CONST_NUMBER;
            }
            else
            {
                if (isOperator(strArgTerm))
                {
                    return CONST_OPERATOR;
                }
                else
                {
                    return CONST_ERROR;
                }
            }

        }

        public bool isNumber(string strArgTerm)
        {
            if (strArgTerm.Substring(0, 1) == "+"
                    || strArgTerm.Substring(0, 1) == "-")
            {
                return false;
            }
            else
            {
                double dblOutReturn = new double();
                return double.TryParse(strArgTerm, out dblOutReturn);
            }
        }

        public bool isOperator(string strArgTerm)
        {
            switch (strArgTerm)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    MessageBox.Show(
                        "演算子以外の文字列が使われているようです。",
                        clsConsts.strApplicationName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
            }
        }

        public bool validate()
        {
            switch ( getType(this.strTerm) ) 
            {
                case CONST_NUMBER:
                    return true;
                case CONST_OPERATOR:
                    return true;
                case CONST_ERROR:
                    return false;
                default:
                    return false;
            }
        }

    }
}
