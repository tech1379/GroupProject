using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Team3
{
    class Logon
    {
        public static string message = "An error has occurred in the program.";
        public static void Verify(string strUserName, string strPassword)
        {
            //password check routine, verify username and password then get person type
            try
            {
                string strQueryLogOnPass;
                string strQueryIsManager;
                string strQueryIsCustomer;
                string strIsManager;
                string strIsCustomer;
                string strResult;
                strQueryLogOnPass = "SELECT COUNT(*) FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "' AND Password = '"
                    + strPassword + "';";
                strResult = ProgOps.DatabaseCommandLogon(strQueryLogOnPass);
                int logon = Int32.Parse(strResult);
                strQueryIsManager = "SELECT isManager FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "' AND Password = '" +
                    strPassword + "';";
                strIsManager = ProgOps.DatabaseCommandLogon(strQueryIsManager);
                strQueryIsCustomer = "SELECT isCustomer FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "' AND Password = '" +
    strPassword + "';";
                strIsCustomer = ProgOps.DatabaseCommandLogon(strQueryIsCustomer);

                if (logon == 1)
                {
                    if (strIsManager == "True")
                    {
                        MessageBox.Show("Managers Form", "Managers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (strIsCustomer == "True")
                    {
                        MessageBox.Show("Customer Form", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee Form", "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You have been denied!", "Logon Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void VerifyLogon(string strUserName)
        {
            //verify logon, update with random password, send email
            string strQueryLogOn;
            string strQueryLogOnID;
            try
            {
                strQueryLogOn = "SELECT COUNT(*) FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "';";
                strQueryLogOnID = "SELECT LogOnID FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "';";
                string strLogOn = ProgOps.DatabaseCommandLogon(strQueryLogOn);
                string strLogOnID = ProgOps.DatabaseCommandLogon(strQueryLogOnID);
                int intLogOnID = Convert.ToInt32(strLogOnID);
                if (strLogOn != "1")
                {
                    MessageBox.Show("LogIn is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strRandomPassword = RandomPassword();
                string strUpdatePassword = "UPDATE group3fa212330.LogOn SET Password = '" + strRandomPassword + "' WHERE LogOnID = " + intLogOnID + ";";
                ProgOps.UpdateDatabase(strUpdatePassword);
                string strQueryIsManager;
                string strQueryIsCustomer;
                string strIsManager;
                string strIsCustomer;
                string strQueryEmail;
                string strEmail;
                strQueryIsManager = "SELECT isManager FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "';";
                strIsManager = ProgOps.DatabaseCommandLogon(strQueryIsManager);
                strQueryIsCustomer = "SELECT isCustomer FROM group3fa212330.LogOn WHERE LogonName = '" + strUserName + "';";
                strIsCustomer = ProgOps.DatabaseCommandLogon(strQueryIsCustomer);
                if (strIsManager == "True")
                {
                    strQueryEmail = "SELECT Email FROM group3fa212330.Employees e JOIN group3fa212330.LogOn l ON e.LogOnID = l.LogOnID WHERE l.LogOnID = " + strLogOnID + ";";
                    
                }
                else if(strIsCustomer == "True")
                {
                    strQueryEmail = "SELECT Email FROM group3fa212330.Customers c JOIN group3fa212330.LogOn l ON c.LogOnID = l.LogOnID WHERE l.LogOnID = " + strLogOnID + ";";
                   
                }
                else
                {
                    strQueryEmail = "SELECT Email FROM group3fa212330.Employees e JOIN group3fa212330.LogOn l ON e.LogOnID = l.LogOnID WHERE l.LogOnID = " + strLogOnID + ";";
                  
                }
                strEmail = ProgOps.DatabaseCommandLogon(strQueryEmail);
                Logon.SendEmail(strEmail, strRandomPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static string RandomPassword()
        {
            //generate a random password
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
        public static void SendEmail(string strEmail,string strRandomPassword)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("eric.tekell@gmail.com");
                message.To.Add(new MailAddress(strEmail));
                message.Subject = "Password Reset";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "Here is your key to reset your password. Key: " + strRandomPassword;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("eric.tekell@gmail.com", "Tech90#@!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
