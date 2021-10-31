using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Team3
{
    class Validation
    {
        public static string message = "An error has occurred in the program.";
        public static bool ValidEmail(string strEmailAddress)
        {
            bool boolValidEmail = false;
            try
            {
                string strEmailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if ((Regex.Match(strEmailAddress, strEmailPattern).Success))
                {
                    boolValidEmail = true;
                }
                else
                {
                    boolValidEmail = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolValidEmail;
        }
        public static bool ValidCreditCard(string strCreditCard)
        {
            bool boolCreditCard = false;
            try
            {
                string strCreditCardPattern = @"^\d{4}-\d{4}-\d{4}-\d{4}$";
                if ((Regex.Match(strCreditCard, strCreditCardPattern).Success))
                {
                    boolCreditCard = true;
                }
                else
                {
                    boolCreditCard = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolCreditCard;
        }
        public static bool ValidExpiration(string strExpiration)
        {
            bool boolExpiration = false;
            try
            {
                string strExpirationPattern = @"^\d{2}/\d{2}$";
                if ((Regex.Match(strExpiration, strExpirationPattern).Success))
                {
                    boolExpiration = true;
                }
                else
                {
                    boolExpiration = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolExpiration;
        }
        public static bool ValidDecimal(string strDecimal)
        {
            bool boolValidDecimal = false;
            try
            {
                string strDecimalPattern = @"^-?[0-9]*\.?[0-9]+$";
                if ((Regex.Match(strDecimal, strDecimalPattern).Success))
                {
                    boolValidDecimal = true;
                }
                else
                {
                    boolValidDecimal = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolValidDecimal;
        }
    }
}
