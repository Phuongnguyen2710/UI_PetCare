namespace UI_PetCare
{
    partial class adopt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adopt));
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PetType = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetSex = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.petImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(120, 120);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1119, 280);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(87, 79);
            this.guna2ImageButton2.TabIndex = 1;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat Black", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(751, 532);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 47);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "ADOPT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.PetType.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetType.Location = new System.Drawing.Point(841, 263);
            this.PetType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetType.Name = "PetType";
            this.PetType.PasswordChar = '\0';
            this.PetType.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetType.PlaceholderText = "Enter Color";
            this.PetType.SelectedText = "";
            this.PetType.Size = new System.Drawing.Size(253, 54);
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
            this.PetBirth.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetBirth.Location = new System.Drawing.Point(841, 363);
            this.PetBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetBirth.Name = "PetBirth";
            this.PetBirth.PasswordChar = '\0';
            this.PetBirth.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetBirth.PlaceholderText = "";
            this.PetBirth.SelectedText = "";
            this.PetBirth.Size = new System.Drawing.Size(253, 54);
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
            this.PetSex.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSex.Location = new System.Drawing.Point(562, 363);
            this.PetSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetSex.Name = "PetSex";
            this.PetSex.PasswordChar = '\0';
            this.PetSex.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetSex.PlaceholderText = "";
            this.PetSex.SelectedText = "";
            this.PetSex.Size = new System.Drawing.Size(240, 54);
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
            this.PetName.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetName.Location = new System.Drawing.Point(562, 263);
            this.PetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetName.Name = "PetName";
            this.PetName.PasswordChar = '\0';
            this.PetName.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetName.PlaceholderText = "";
            this.PetName.SelectedText = "";
            this.PetName.Size = new System.Drawing.Size(240, 54);
            this.PetName.TabIndex = 25;
            // 
            // petImage
            // 
            this.petImage.Location = new System.Drawing.Point(111, 144);
            this.petImage.Margin = new System.Windows.Forms.Padding(2);
            this.petImage.Name = "petImage";
            this.petImage.Size = new System.Drawing.Size(342, 379);
            this.petImage.TabIndex = 29;
            this.petImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(87, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name\' Post people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Date Post";
            // 
            // adopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petImage);
            this.Controls.Add(this.PetType);
            this.Controls.Add(this.PetBirth);
            this.Controls.Add(this.PetSex);
            this.Controls.Add(this.PetName);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ImageButton2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adopt";
            this.Text = "adopt";
            this.Load += new System.EventHandler(this.adopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox PetType;
        private Guna.UI2.WinForms.Guna2TextBox PetBirth;
        private Guna.UI2.WinForms.Guna2TextBox PetSex;
        private Guna.UI2.WinForms.Guna2TextBox PetName;
        private System.Windows.Forms.PictureBox petImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}