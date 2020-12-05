using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class Form1 : Form
    {

        private string _to;
        private string _from;
        private string _server;
        private string _password;
        private int _port;

        public Form1()
        {
            InitializeComponent();          

            ReadConfigurationFile();
            ReadInputData();
        
       }

        private void ReadConfigurationFile()
        {
           string[] lines = System.IO.File.ReadAllLines("Configuration.txt");

            foreach (var line in lines)
            {   
                string[] word = line.Split(';');

                if (word.Length >= 2)
                {
                    if (word[0] == "from")
                    {
                        _from = word[1];
                    }
                    else if (word[0] == "password")
                    {
                        _password = word[1];
                    }
                    else if (word[0] == "server") 
                    {
                        _server = word[1];
                    }
                    else if (word[0] == "port")
                    {
                        _port = int.Parse(word[1]);
                    }    
                }
            }
        }

        private void ReadInputData()
        {
            _to = tBoxTo.Text;
            _from = tBoxFrom.Text;            
            _password = tBoxPassword.Text;           
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {


            ReadInputData();           
            SendEMail();

        }


        public void SendEMail()
        {

            MailMessage message = new MailMessage(_from, _to);
            message.Subject = "Using the new SMTP client.";

            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient(_server);

            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.Port = _port;
            client.Credentials = new NetworkCredential(_from, _password);
            client.EnableSsl = true;


            //client.UseDefaultCredentials = true;


            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }

       


    }
}
