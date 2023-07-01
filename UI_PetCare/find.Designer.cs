namespace UI_PetCare
{
    partial class find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(find));
            this.petImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preOwner = new Guna.UI2.WinForms.Guna2TextBox();
            this.Vaccine = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetType = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetSex = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Adopt_Button = new Guna.UI2.WinForms.Guna2Button();
            this.next_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.petImage)).BeginInit();
            this.SuspendLayout();
            // 
            // petImage
            // 
            this.petImage.Location = new System.Drawing.Point(77, 105);
            this.petImage.Margin = new System.Windows.Forms.Padding(2);
            this.petImage.Name = "petImage";
            this.petImage.Size = new System.Drawing.Size(215, 290);
            this.petImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petImage.TabIndex = 29;
            this.petImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name\' Post people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Date Post";
            // 
            // preOwner
            // 
            this.preOwner.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.preOwner.BorderRadius = 10;
            this.preOwner.BorderThickness = 2;
            this.preOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.preOwner.DefaultText = "Previous Owner";
            this.preOwner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.preOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.preOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.preOwner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.preOwner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.preOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOwner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.preOwner.Location = new System.Drawing.Point(609, 351);
            this.preOwner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.preOwner.Name = "preOwner";
            this.preOwner.PasswordChar = '\0';
            this.preOwner.PlaceholderForeColor = System.Drawing.Color.Red;
            this.preOwner.PlaceholderText = "";
            this.preOwner.SelectedText = "";
            this.preOwner.Size = new System.Drawing.Size(190, 44);
            this.preOwner.TabIndex = 34;
            // 
            // Vaccine
            // 
            this.Vaccine.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Vaccine.BorderRadius = 10;
            this.Vaccine.BorderThickness = 2;
            this.Vaccine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vaccine.DefaultText = "Vaccine";
            this.Vaccine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Vaccine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Vaccine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vaccine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vaccine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaccine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vaccine.Location = new System.Drawing.Point(372, 351);
            this.Vaccine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Vaccine.Name = "Vaccine";
            this.Vaccine.PasswordChar = '\0';
            this.Vaccine.PlaceholderForeColor = System.Drawing.Color.Red;
            this.Vaccine.PlaceholderText = "";
            this.Vaccine.SelectedText = "";
            this.Vaccine.Size = new System.Drawing.Size(180, 44);
            this.Vaccine.TabIndex = 33;
            // 
            // PetType
            // 
            this.PetType.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetType.BorderRadius = 10;
            this.PetType.BorderThickness = 2;
            this.PetType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetType.DefaultText = "Subtype: ";
            this.PetType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetType.Location = new System.Drawing.Point(609, 161);
            this.PetType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PetType.Name = "PetType";
            this.PetType.PasswordChar = '\0';
            this.PetType.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetType.PlaceholderText = "Enter Color";
            this.PetType.SelectedText = "";
            this.PetType.Size = new System.Drawing.Size(190, 44);
            this.PetType.TabIndex = 28;
            // 
            // PetBirth
            // 
            this.PetBirth.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetBirth.BorderRadius = 10;
            this.PetBirth.BorderThickness = 2;
            this.PetBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetBirth.DefaultText = "Date of Birth: ";
            this.PetBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetBirth.Location = new System.Drawing.Point(609, 255);
            this.PetBirth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PetBirth.Name = "PetBirth";
            this.PetBirth.PasswordChar = '\0';
            this.PetBirth.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetBirth.PlaceholderText = "";
            this.PetBirth.SelectedText = "";
            this.PetBirth.Size = new System.Drawing.Size(190, 44);
            this.PetBirth.TabIndex = 27;
            // 
            // PetSex
            // 
            this.PetSex.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetSex.BorderRadius = 10;
            this.PetSex.BorderThickness = 2;
            this.PetSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetSex.DefaultText = "Sex: ";
            this.PetSex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetSex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetSex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSex.Location = new System.Drawing.Point(372, 255);
            this.PetSex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PetSex.Name = "PetSex";
            this.PetSex.PasswordChar = '\0';
            this.PetSex.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetSex.PlaceholderText = "";
            this.PetSex.SelectedText = "";
            this.PetSex.Size = new System.Drawing.Size(180, 44);
            this.PetSex.TabIndex = 26;
            // 
            // PetName
            // 
            this.PetName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetName.BorderRadius = 10;
            this.PetName.BorderThickness = 2;
            this.PetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetName.DefaultText = "Name: ";
            this.PetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetName.Location = new System.Drawing.Point(372, 161);
            this.PetName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PetName.Name = "PetName";
            this.PetName.PasswordChar = '\0';
            this.PetName.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetName.PlaceholderText = "";
            this.PetName.SelectedText = "";
            this.PetName.Size = new System.Drawing.Size(180, 44);
            this.PetName.TabIndex = 25;
            // 
            // Adopt_Button
            // 
            this.Adopt_Button.BackColor = System.Drawing.Color.Transparent;
            this.Adopt_Button.BorderRadius = 10;
            this.Adopt_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Adopt_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Adopt_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Adopt_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Adopt_Button.Enabled = false;
            this.Adopt_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Adopt_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adopt_Button.ForeColor = System.Drawing.Color.Black;
            this.Adopt_Button.Location = new System.Drawing.Point(511, 424);
            this.Adopt_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Adopt_Button.Name = "Adopt_Button";
            this.Adopt_Button.Size = new System.Drawing.Size(140, 38);
            this.Adopt_Button.TabIndex = 14;
            this.Adopt_Button.Text = "I FOUND";
            this.Adopt_Button.Click += new System.EventHandler(this.Find_ButtonClick);
            // 
            // next_Button
            // 
            this.next_Button.BackColor = System.Drawing.Color.Transparent;
            this.next_Button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.next_Button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.next_Button.Image = ((System.Drawing.Image)(resources.GetObject("next_Button.Image")));
            this.next_Button.ImageOffset = new System.Drawing.Point(0, 0);
            this.next_Button.ImageRotate = 0F;
            this.next_Button.ImageSize = new System.Drawing.Size(120, 120);
            this.next_Button.Location = new System.Drawing.Point(834, 244);
            this.next_Button.Margin = new System.Windows.Forms.Padding(2);
            this.next_Button.Name = "next_Button";
            this.next_Button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.next_Button.Size = new System.Drawing.Size(65, 64);
            this.next_Button.TabIndex = 0;
            this.next_Button.Click += new System.EventHandler(this.next_ButtonClick);
            // 
            // find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 503);
            this.Controls.Add(this.next_Button);
            this.Controls.Add(this.preOwner);
            this.Controls.Add(this.Vaccine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petImage);
            this.Controls.Add(this.PetType);
            this.Controls.Add(this.PetBirth);
            this.Controls.Add(this.PetSex);
            this.Controls.Add(this.PetName);
            this.Controls.Add(this.Adopt_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "find";
            this.Load += new System.EventHandler(this.find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Adopt_Button;
        private Guna.UI2.WinForms.Guna2TextBox PetType;
        private Guna.UI2.WinForms.Guna2TextBox PetBirth;
        private Guna.UI2.WinForms.Guna2TextBox PetSex;
        private Guna.UI2.WinForms.Guna2TextBox PetName;
        private System.Windows.Forms.PictureBox petImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox preOwner;
        private Guna.UI2.WinForms.Guna2TextBox Vaccine;
        private Guna.UI2.WinForms.Guna2ImageButton next_Button;
    }
}