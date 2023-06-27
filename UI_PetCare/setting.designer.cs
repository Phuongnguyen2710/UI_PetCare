namespace UI_PetCare
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.uploadButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.phonetextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.locationtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernametextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cfpasstextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newavatarpic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newavatarpic)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.BorderRadius = 10;
            this.uploadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uploadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uploadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uploadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uploadButton.Font = new System.Drawing.Font("UTM Avo", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.Color.Black;
            this.uploadButton.Location = new System.Drawing.Point(1403, 519);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(211, 55);
            this.uploadButton.TabIndex = 21;
            this.uploadButton.Text = "Upload";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BorderRadius = 10;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.saveButton.Font = new System.Drawing.Font("Montserrat Black", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(829, 778);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(211, 84);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "SAVE";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phonetextbox
            // 
            this.phonetextbox.BackColor = System.Drawing.Color.Transparent;
            this.phonetextbox.BorderColor = System.Drawing.Color.Red;
            this.phonetextbox.BorderRadius = 20;
            this.phonetextbox.BorderThickness = 2;
            this.phonetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetextbox.DefaultText = "";
            this.phonetextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.phonetextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetextbox.Location = new System.Drawing.Point(679, 471);
            this.phonetextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.PasswordChar = '\0';
            this.phonetextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.phonetextbox.PlaceholderText = "Phone number";
            this.phonetextbox.SelectedText = "";
            this.phonetextbox.Size = new System.Drawing.Size(536, 66);
            this.phonetextbox.TabIndex = 23;
            // 
            // locationtextbox
            // 
            this.locationtextbox.BackColor = System.Drawing.Color.Transparent;
            this.locationtextbox.BorderColor = System.Drawing.Color.Red;
            this.locationtextbox.BorderRadius = 20;
            this.locationtextbox.BorderThickness = 2;
            this.locationtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationtextbox.DefaultText = "";
            this.locationtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.locationtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.locationtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationtextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.locationtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationtextbox.Location = new System.Drawing.Point(679, 382);
            this.locationtextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.locationtextbox.Name = "locationtextbox";
            this.locationtextbox.PasswordChar = '\0';
            this.locationtextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.locationtextbox.PlaceholderText = "Location";
            this.locationtextbox.SelectedText = "";
            this.locationtextbox.Size = new System.Drawing.Size(536, 66);
            this.locationtextbox.TabIndex = 24;
            // 
            // usernametextbox
            // 
            this.usernametextbox.BackColor = System.Drawing.Color.Transparent;
            this.usernametextbox.BorderColor = System.Drawing.Color.Red;
            this.usernametextbox.BorderRadius = 20;
            this.usernametextbox.BorderThickness = 2;
            this.usernametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametextbox.DefaultText = "";
            this.usernametextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usernametextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametextbox.Location = new System.Drawing.Point(679, 221);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.PasswordChar = '\0';
            this.usernametextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.usernametextbox.PlaceholderText = "Username";
            this.usernametextbox.SelectedText = "";
            this.usernametextbox.Size = new System.Drawing.Size(536, 66);
            this.usernametextbox.TabIndex = 25;
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.Color.Transparent;
            this.emailtextbox.BorderColor = System.Drawing.Color.Red;
            this.emailtextbox.BorderRadius = 20;
            this.emailtextbox.BorderThickness = 2;
            this.emailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtextbox.DefaultText = "";
            this.emailtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.emailtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtextbox.Location = new System.Drawing.Point(679, 299);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.PasswordChar = '\0';
            this.emailtextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.emailtextbox.PlaceholderText = "Email";
            this.emailtextbox.SelectedText = "";
            this.emailtextbox.Size = new System.Drawing.Size(536, 66);
            this.emailtextbox.TabIndex = 26;
            // 
            // passtextbox
            // 
            this.passtextbox.BackColor = System.Drawing.Color.Transparent;
            this.passtextbox.BorderColor = System.Drawing.Color.Red;
            this.passtextbox.BorderRadius = 20;
            this.passtextbox.BorderThickness = 2;
            this.passtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtextbox.DefaultText = "";
            this.passtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passtextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passtextbox.Location = new System.Drawing.Point(679, 568);
            this.passtextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.PasswordChar = '●';
            this.passtextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.passtextbox.PlaceholderText = "Password";
            this.passtextbox.SelectedText = "";
            this.passtextbox.Size = new System.Drawing.Size(536, 66);
            this.passtextbox.TabIndex = 27;
            this.passtextbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Change your Informations";
            // 
            // cfpasstextbox
            // 
            this.cfpasstextbox.BackColor = System.Drawing.Color.Transparent;
            this.cfpasstextbox.BorderColor = System.Drawing.Color.Red;
            this.cfpasstextbox.BorderRadius = 20;
            this.cfpasstextbox.BorderThickness = 2;
            this.cfpasstextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cfpasstextbox.DefaultText = "";
            this.cfpasstextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cfpasstextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cfpasstextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cfpasstextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cfpasstextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cfpasstextbox.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfpasstextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cfpasstextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cfpasstextbox.Location = new System.Drawing.Point(679, 655);
            this.cfpasstextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cfpasstextbox.Name = "cfpasstextbox";
            this.cfpasstextbox.PasswordChar = '●';
            this.cfpasstextbox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.cfpasstextbox.PlaceholderText = "Confirm Password";
            this.cfpasstextbox.SelectedText = "";
            this.cfpasstextbox.Size = new System.Drawing.Size(536, 66);
            this.cfpasstextbox.TabIndex = 29;
            this.cfpasstextbox.UseSystemPasswordChar = true;
            // 
            // newavatarpic
            // 
            this.newavatarpic.ImageRotate = 0F;
            this.newavatarpic.Location = new System.Drawing.Point(1330, 150);
            this.newavatarpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newavatarpic.Name = "newavatarpic";
            this.newavatarpic.Size = new System.Drawing.Size(322, 318);
            this.newavatarpic.TabIndex = 30;
            this.newavatarpic.TabStop = false;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1723, 882);
            this.Controls.Add(this.newavatarpic);
            this.Controls.Add(this.cfpasstextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.locationtextbox);
            this.Controls.Add(this.phonetextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.uploadButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newavatarpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button uploadButton;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2TextBox phonetextbox;
        private Guna.UI2.WinForms.Guna2TextBox locationtextbox;
        private Guna.UI2.WinForms.Guna2TextBox usernametextbox;
        private Guna.UI2.WinForms.Guna2TextBox emailtextbox;
        private Guna.UI2.WinForms.Guna2TextBox passtextbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox cfpasstextbox;
        private Guna.UI2.WinForms.Guna2PictureBox newavatarpic;
    }
}