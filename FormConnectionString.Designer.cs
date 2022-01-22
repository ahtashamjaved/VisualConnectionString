namespace VisualConnectionString
{
    partial class FormConnectionString
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbtnFalse = new System.Windows.Forms.RadioButton();
            this.rbtnTrue = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(71, 224);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(73, 16);
            this.lblMessage.TabIndex = 102;
            this.lblMessage.Text = "Welcome";
            // 
            // rbtnFalse
            // 
            this.rbtnFalse.AutoSize = true;
            this.rbtnFalse.Location = new System.Drawing.Point(185, 109);
            this.rbtnFalse.Name = "rbtnFalse";
            this.rbtnFalse.Size = new System.Drawing.Size(50, 17);
            this.rbtnFalse.TabIndex = 101;
            this.rbtnFalse.Text = "False";
            this.rbtnFalse.UseVisualStyleBackColor = true;
            // 
            // rbtnTrue
            // 
            this.rbtnTrue.AutoSize = true;
            this.rbtnTrue.Location = new System.Drawing.Point(132, 109);
            this.rbtnTrue.Name = "rbtnTrue";
            this.rbtnTrue.Size = new System.Drawing.Size(47, 17);
            this.rbtnTrue.TabIndex = 100;
            this.rbtnTrue.Text = "True";
            this.rbtnTrue.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(330, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 98;
            this.txtPassword.Text = "1234";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 132);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 20);
            this.txtUsername.TabIndex = 96;
            this.txtUsername.Text = "Your Db userName";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(332, 106);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(129, 20);
            this.txtTimeout.TabIndex = 94;
            this.txtTimeout.Text = "25";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(132, 81);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(329, 20);
            this.txtDatabase.TabIndex = 91;
            this.txtDatabase.Text = "OMR Database name";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(132, 55);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(329, 20);
            this.txtServer.TabIndex = 89;
            this.txtServer.Text = "Your Server ip or name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Int Security";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Server";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // FormConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.rbtnFalse);
            this.Controls.Add(this.rbtnTrue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Name = "FormConnectionString";
            this.Opacity = 0.85D;
            this.Text = "Connection Details";
            this.Load += new System.EventHandler(this.FormConnectionString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.RadioButton rbtnFalse;
        public System.Windows.Forms.RadioButton rbtnTrue;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtTimeout;
        public System.Windows.Forms.TextBox txtDatabase;
        public System.Windows.Forms.TextBox txtServer;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSave;

    }
}