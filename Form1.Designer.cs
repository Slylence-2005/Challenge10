namespace PhishingSoftware
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private TextBox GetTxtEmail()
        {
            return txtEmail;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(TextBox txtEmail)
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            radio100Gems = new RadioButton();
            radio500Gems = new RadioButton();
            radio1000Gems = new RadioButton();
            radio2000Gems = new RadioButton();
            groupBox4 = new GroupBox();
            radio10000Gold = new RadioButton();
            radio100000Gold = new RadioButton();
            radio1000000Gold = new RadioButton();
            radio10000000Gold = new RadioButton();
            Elixer = new GroupBox();
            radio10000Elixer = new RadioButton();
            radio100000Elixer = new RadioButton();
            radio1000000Elixer = new RadioButton();
            tabPage1 = new TabPage();
            radio10000000Elixer = new RadioButton();
            btnSend = new Button();
            tabControl1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            Elixer.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(503, 438);
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(495, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(18, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Setup";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 2;
           // txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 118);
            label2.Name = "Label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += Label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Elixer);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(radio2000Gems);
            groupBox2.Controls.Add(radio1000Gems);
            groupBox2.Controls.Add(radio500Gems);
            groupBox2.Controls.Add(radio100Gems);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(18, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 179);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Item";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(11, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(103, 157);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gems";
            // 
            // radio100Gems
            // 
            radio100Gems.AutoSize = true;
            radio100Gems.Location = new Point(11, 38);
            radio100Gems.Name = "radio100Gems";
            radio100Gems.Size = new Size(95, 24);
            radio100Gems.TabIndex = 0;
            radio100Gems.TabStop = true;
            radio100Gems.Text = "100 Gems";
            radio100Gems.UseVisualStyleBackColor = true;
            // 
            // radio500Gems
            // 
            radio500Gems.AutoSize = true;
            radio500Gems.Location = new Point(11, 68);
            radio500Gems.Name = "radio500Gems";
            radio500Gems.Size = new Size(95, 24);
            radio500Gems.TabIndex = 1;
            radio500Gems.TabStop = true;
            radio500Gems.Text = "500 Gems";
            radio500Gems.UseVisualStyleBackColor = true;
            // 
            // radio1000Gems
            // 
            radio1000Gems.AutoSize = true;
            radio1000Gems.Location = new Point(11, 98);
            radio1000Gems.Name = "radio1000Gems";
            radio1000Gems.Size = new Size(103, 24);
            radio1000Gems.TabIndex = 2;
            radio1000Gems.TabStop = true;
            radio1000Gems.Text = "1000 Gems";
            radio1000Gems.UseVisualStyleBackColor = true;
            // 
            // radio2000Gems
            // 
            radio2000Gems.AutoSize = true;
            radio2000Gems.Location = new Point(11, 128);
            radio2000Gems.Name = "radio2000Gems";
            radio2000Gems.Size = new Size(103, 24);
            radio2000Gems.TabIndex = 3;
            radio2000Gems.TabStop = true;
            radio2000Gems.Text = "2000 Gems";
            radio2000Gems.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radio10000000Gold);
            groupBox4.Controls.Add(radio1000000Gold);
            groupBox4.Controls.Add(radio100000Gold);
            groupBox4.Controls.Add(radio10000Gold);
            groupBox4.Location = new Point(160, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(130, 165);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gold";
            // 
            // radio10000Gold
            // 
            radio10000Gold.AutoSize = true;
            radio10000Gold.Location = new Point(0, 26);
            radio10000Gold.Name = "radio10000Gold";
            radio10000Gold.Size = new Size(106, 24);
            radio10000Gold.TabIndex = 0;
            radio10000Gold.TabStop = true;
            radio10000Gold.Text = "10000 Gold";
            radio10000Gold.UseVisualStyleBackColor = true;
            // 
            // radio100000Gold
            // 
            radio100000Gold.AutoSize = true;
            radio100000Gold.Location = new Point(0, 56);
            radio100000Gold.Name = "radio100000Gold";
            radio100000Gold.Size = new Size(114, 24);
            radio100000Gold.TabIndex = 1;
            radio100000Gold.TabStop = true;
            radio100000Gold.Text = "100000 Gold";
            radio100000Gold.UseVisualStyleBackColor = true;
            // 
            // radio1000000Gold
            // 
            radio1000000Gold.AutoSize = true;
            radio1000000Gold.Location = new Point(0, 84);
            radio1000000Gold.Name = "radio1000000Gold";
            radio1000000Gold.Size = new Size(122, 24);
            radio1000000Gold.TabIndex = 2;
            radio1000000Gold.TabStop = true;
            radio1000000Gold.Text = "1000000 Gold";
            radio1000000Gold.UseVisualStyleBackColor = true;
            // 
            // radio10000000Gold
            // 
            radio10000000Gold.AutoSize = true;
            radio10000000Gold.Location = new Point(0, 114);
            radio10000000Gold.Name = "radio10000000Gold";
            radio10000000Gold.Size = new Size(130, 24);
            radio10000000Gold.TabIndex = 3;
            radio10000000Gold.TabStop = true;
            radio10000000Gold.Text = "10000000 Gold";
            radio10000000Gold.UseVisualStyleBackColor = true;
            // 
            // Elixer
            // 
            Elixer.Controls.Add(radio10000000Elixer);
            Elixer.Controls.Add(radio1000000Elixer);
            Elixer.Controls.Add(radio100000Elixer);
            Elixer.Controls.Add(radio10000Elixer);
            Elixer.Location = new Point(296, 14);
            Elixer.Name = "Elixer";
            Elixer.Size = new Size(142, 157);
            Elixer.TabIndex = 6;
            Elixer.TabStop = false;
            Elixer.Text = "Elixer";
            // 
            // radio10000Elixer
            // 
            radio10000Elixer.AutoSize = true;
            radio10000Elixer.Location = new Point(0, 26);
            radio10000Elixer.Name = "radio10000Elixer";
            radio10000Elixer.Size = new Size(110, 24);
            radio10000Elixer.TabIndex = 0;
            radio10000Elixer.TabStop = true;
            radio10000Elixer.Text = "10000 Elixer";
            radio10000Elixer.UseVisualStyleBackColor = true;
            // 
            // radio100000Elixer
            // 
            radio100000Elixer.AutoSize = true;
            radio100000Elixer.Location = new Point(0, 54);
            radio100000Elixer.Name = "radio100000Elixer";
            radio100000Elixer.Size = new Size(118, 24);
            radio100000Elixer.TabIndex = 1;
            radio100000Elixer.TabStop = true;
            radio100000Elixer.Text = "100000 Elixer";
            radio100000Elixer.UseVisualStyleBackColor = true;
            // 
            // radio1000000Elixer
            // 
            radio1000000Elixer.AutoSize = true;
            radio1000000Elixer.Location = new Point(0, 84);
            radio1000000Elixer.Name = "radio1000000Elixer";
            radio1000000Elixer.Size = new Size(126, 24);
            radio1000000Elixer.TabIndex = 2;
            radio1000000Elixer.TabStop = true;
            radio1000000Elixer.Text = "1000000 Elixer";
            radio1000000Elixer.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "TabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(495, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += TabPage1_Click;
            // 
            // radio10000000Elixer
            // 
            radio10000000Elixer.AutoSize = true;
            radio10000000Elixer.Location = new Point(0, 114);
            radio10000000Elixer.Name = "radio10000000Elixer";
            radio10000000Elixer.Size = new Size(134, 24);
            radio10000000Elixer.TabIndex = 3;
            radio10000000Elixer.TabStop = true;
            radio10000000Elixer.Text = "10000000 Elixer";
            radio10000000Elixer.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(184, 353);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 46);
            btnSend.TabIndex = 6;
            btnSend.Text = "Hack";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Phishing Software";
            tabControl1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            Elixer.ResumeLayout(false);
            Elixer.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

       // private void txtEmail_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnSend;
        private GroupBox groupBox2;
        private GroupBox Elixer;
        private RadioButton radio10000000Elixer;
        private RadioButton radio1000000Elixer;
        private RadioButton radio100000Elixer;
        private RadioButton radio10000Elixer;
        private GroupBox groupBox4;
        private RadioButton radio10000000Gold;
        private RadioButton radio1000000Gold;
        private RadioButton radio100000Gold;
        private RadioButton radio10000Gold;
        private RadioButton radio2000Gems;
        private RadioButton radio1000Gems;
        private RadioButton radio500Gems;
        private RadioButton radio100Gems;
        private GroupBox groupBox3;
        private Label label2;
#pragma warning disable CS0649 // Field 'Form1.txtEmail' is never assigned to, and will always have its default value null
        private TextBox txtEmail;
#pragma warning restore CS0649 // Field 'Form1.txtEmail' is never assigned to, and will always have its default value null
        private Label label1;
        private TextBox txtPassword;
        private GroupBox groupBox1;
    }
}