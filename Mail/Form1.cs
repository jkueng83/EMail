using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
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
        private string _subject;
        private string _body;
        private List<Attachment> _attachments;

        public Form1()
        {
            InitializeComponent();

            _attachments = new List<Attachment>();

            ReadConfigurationFile();
            LoadDefaultEmail();
        }

        private void LoadDefaultEmail()
        {

            tBoxSubject.Text = "Default E-Mail";

            tBoxBody.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt" +
                " ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                " dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit " +
                "  amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt " +
                "ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores" +
                " et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem " +
                "ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et " +
                "dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet" +
                " clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
        }

        private void ReadConfigurationFile()
        {
           string[] lines = System.IO.File.ReadAllLines(@"C:\EMail\Configuration.txt");

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

            WriteKonfigurationIntoInputData();
        }

        private void WriteKonfigurationIntoInputData()
        {
            tBoxFrom.Text = _from;
            tBoxPassword.Text = _password;
        }

        private void ReadInputData()
        {
            _to = tBoxTo.Text;
            _from = tBoxFrom.Text;            
            _password = tBoxPassword.Text;
            _subject = tBoxSubject.Text;
            _body = tBoxBody.Text + GetFooter();
        }

        private string GetFooter()
        {
            // Wird im Mail nicht schön dargestellt:
            //
            //string s = "\n";
            //string s2 = "***** created form JK with C# *****";

            //for (int i = 0; i < 3; i++)
            //{
            //    s += "\n";
            //    if (i % 2 == 0)
            //    {
            //        for (int j = 0; j < s2.Length; j++)
            //        {
            //            s += "=";
            //        }
            //    }
            //    else
            //    {
            //        s += s2;
            //    }
            //}
            //return s;

            string s = "\n\n***** created form JK with C# *****";
            return s;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {                
            SendEMail();
        }


        public void SendEMail()
        {
            ReadInputData();

            MailMessage message = new MailMessage(_from, _to);
            message.Subject = _subject;
            message.Body = _body;

            AddAttachmentToMail(ref message);

            SmtpClient client = new SmtpClient(_server);
            client.Port = _port;
            client.Credentials = new NetworkCredential(_from, _password);
            client.EnableSsl = true;

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

        private void AddAttachmentToMail( ref MailMessage message)
        {

            foreach (var attachement in _attachments)
            {
                message.Attachments.Add(attachement);
                
            }     
        }

        private void LoadAttachment(string path , string name)
        {

            string file = @""+ path;
            // Create  the file attachment for this email message.
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add time stamp information for the file.
            //ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = System.IO.File.GetCreationTime(file);
            //disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            //disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            // Add the file attachment to this email message.
           


            _attachments.Add(data);

            ViewAttachments();
        }



        private void btTakeFrom_Click(object sender, EventArgs e)
        {
            tBoxTo.Text = tBoxFrom.Text;
        }

        private void btAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                LoadAttachment(path, fileName);

               
            } 
        }

        private void ViewAttachments()
        {

            string[] fileNames = _attachments.Select(x => x.Name).ToArray();
            string attachmentString = "";
            foreach (var fileName in fileNames)
            {
                attachmentString += fileName + "; ";

            }
            tBoxAttachment.Text = attachmentString;
        }
    }
}
