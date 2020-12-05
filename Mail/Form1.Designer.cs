
namespace Mail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tBoxFrom = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lBPassword = new System.Windows.Forms.Label();
            this.lBTo = new System.Windows.Forms.Label();
            this.tBoxTo = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tBoxSubject = new System.Windows.Forms.TextBox();
            this.lbBody = new System.Windows.Forms.Label();
            this.tBoxBody = new System.Windows.Forms.TextBox();
            this.btAddFile = new System.Windows.Forms.Button();
            this.tBoxAttachment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(112, 379);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(445, 23);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "send mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // tBoxFrom
            // 
            this.tBoxFrom.Location = new System.Drawing.Point(112, 26);
            this.tBoxFrom.Name = "tBoxFrom";
            this.tBoxFrom.Size = new System.Drawing.Size(445, 20);
            this.tBoxFrom.TabIndex = 1;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPassword.Location = new System.Drawing.Point(112, 65);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(445, 20);
            this.tBoxPassword.TabIndex = 2;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(24, 26);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(30, 13);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "From";
            // 
            // lBPassword
            // 
            this.lBPassword.AutoSize = true;
            this.lBPassword.Location = new System.Drawing.Point(24, 68);
            this.lBPassword.Name = "lBPassword";
            this.lBPassword.Size = new System.Drawing.Size(53, 13);
            this.lBPassword.TabIndex = 4;
            this.lBPassword.Text = "Password";
            // 
            // lBTo
            // 
            this.lBTo.AutoSize = true;
            this.lBTo.Location = new System.Drawing.Point(24, 108);
            this.lBTo.Name = "lBTo";
            this.lBTo.Size = new System.Drawing.Size(20, 13);
            this.lBTo.TabIndex = 5;
            this.lBTo.Text = "To";
            // 
            // tBoxTo
            // 
            this.tBoxTo.Location = new System.Drawing.Point(112, 105);
            this.tBoxTo.Name = "tBoxTo";
            this.tBoxTo.Size = new System.Drawing.Size(445, 20);
            this.tBoxTo.TabIndex = 6;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(24, 147);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(43, 13);
            this.lbSubject.TabIndex = 8;
            this.lbSubject.Text = "Subject";
            this.lbSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxSubject
            // 
            this.tBoxSubject.Location = new System.Drawing.Point(112, 144);
            this.tBoxSubject.Name = "tBoxSubject";
            this.tBoxSubject.Size = new System.Drawing.Size(445, 20);
            this.tBoxSubject.TabIndex = 9;
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Location = new System.Drawing.Point(24, 188);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(31, 13);
            this.lbBody.TabIndex = 10;
            this.lbBody.Text = "Body";
            // 
            // tBoxBody
            // 
            this.tBoxBody.Location = new System.Drawing.Point(112, 185);
            this.tBoxBody.Multiline = true;
            this.tBoxBody.Name = "tBoxBody";
            this.tBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxBody.Size = new System.Drawing.Size(445, 138);
            this.tBoxBody.TabIndex = 11;
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(24, 336);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(75, 23);
            this.btAddFile.TabIndex = 12;
            this.btAddFile.Text = "Add File";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // tBoxAttachment
            // 
            this.tBoxAttachment.Location = new System.Drawing.Point(112, 338);
            this.tBoxAttachment.Name = "tBoxAttachment";
            this.tBoxAttachment.Size = new System.Drawing.Size(445, 20);
            this.tBoxAttachment.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 435);
            this.Controls.Add(this.tBoxAttachment);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.tBoxBody);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.tBoxSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.tBoxTo);
            this.Controls.Add(this.lBTo);
            this.Controls.Add(this.lBPassword);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxFrom);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Send E-Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox tBoxFrom;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lBPassword;
        private System.Windows.Forms.Label lBTo;
        private System.Windows.Forms.TextBox tBoxTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tBoxSubject;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.TextBox tBoxBody;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.TextBox tBoxAttachment;
    }
}

