
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
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(71, 43);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "send mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // tBoxFrom
            // 
            this.tBoxFrom.Location = new System.Drawing.Point(277, 95);
            this.tBoxFrom.Name = "tBoxFrom";
            this.tBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.tBoxFrom.TabIndex = 1;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPassword.Location = new System.Drawing.Point(277, 134);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.tBoxPassword.TabIndex = 2;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(172, 98);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(30, 13);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "From";
            // 
            // lBPassword
            // 
            this.lBPassword.AutoSize = true;
            this.lBPassword.Location = new System.Drawing.Point(175, 140);
            this.lBPassword.Name = "lBPassword";
            this.lBPassword.Size = new System.Drawing.Size(53, 13);
            this.lBPassword.TabIndex = 4;
            this.lBPassword.Text = "Password";
            // 
            // lBTo
            // 
            this.lBTo.AutoSize = true;
            this.lBTo.Location = new System.Drawing.Point(178, 180);
            this.lBTo.Name = "lBTo";
            this.lBTo.Size = new System.Drawing.Size(20, 13);
            this.lBTo.TabIndex = 5;
            this.lBTo.Text = "To";
            // 
            // tBoxTo
            // 
            this.tBoxTo.Location = new System.Drawing.Point(277, 180);
            this.tBoxTo.Name = "tBoxTo";
            this.tBoxTo.Size = new System.Drawing.Size(100, 20);
            this.tBoxTo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBoxTo);
            this.Controls.Add(this.lBTo);
            this.Controls.Add(this.lBPassword);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxFrom);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

