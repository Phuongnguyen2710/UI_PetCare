namespace UI_PetCare
{
    partial class Form_post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_post));
            this.picturepet = new System.Windows.Forms.PictureBox();
            this.bttMoreDetail = new Guna.UI2.WinForms.Guna2Button();
            this.status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PostButton = new Guna.UI2.WinForms.Guna2Button();
            this.btt_Click = new Guna.UI2.WinForms.Guna2Button();
            this.PetColorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameClientTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetDofTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetSubtypeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetSexTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PetNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturepet)).BeginInit();
            this.SuspendLayout();
            // 
            // picturepet
            // 
            this.picturepet.Location = new System.Drawing.Point(59, 169);
            this.picturepet.Name = "picturepet";
            this.picturepet.Size = new System.Drawing.Size(361, 349);
            this.picturepet.TabIndex = 0;
            this.picturepet.TabStop = false;
            // 
            // bttMoreDetail
            // 
            this.bttMoreDetail.BackColor = System.Drawing.SystemColors.Window;
            this.bttMoreDetail.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bttMoreDetail.BorderRadius = 20;
            this.bttMoreDetail.BorderThickness = 2;
            this.bttMoreDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttMoreDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttMoreDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttMoreDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttMoreDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttMoreDetail.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMoreDetail.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bttMoreDetail.Location = new System.Drawing.Point(800, 436);
            this.bttMoreDetail.Name = "bttMoreDetail";
            this.bttMoreDetail.PressedColor = System.Drawing.Color.Transparent;
            this.bttMoreDetail.Size = new System.Drawing.Size(290, 36);
            this.bttMoreDetail.TabIndex = 14;
            this.bttMoreDetail.Text = "More Detail";
            this.bttMoreDetail.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Window;
            this.status.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.status.BorderRadius = 20;
            this.status.BorderThickness = 2;
            this.status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Font = new System.Drawing.Font("UTM Avo", 13.8F);
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.ItemHeight = 30;
            this.status.Items.AddRange(new object[] {
            "Adopt",
            "Find"});
            this.status.Location = new System.Drawing.Point(473, 205);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(290, 36);
            this.status.TabIndex = 13;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.Color.Transparent;
            this.PostButton.BorderRadius = 20;
            this.PostButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PostButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PostButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PostButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PostButton.FillColor = System.Drawing.Color.LightPink;
            this.PostButton.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PostButton.Location = new System.Drawing.Point(696, 534);
            this.PostButton.Name = "PostButton";
            this.PostButton.PressedColor = System.Drawing.Color.Transparent;
            this.PostButton.Size = new System.Drawing.Size(191, 63);
            this.PostButton.TabIndex = 11;
            this.PostButton.Text = "POST";
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // btt_Click
            // 
            this.btt_Click.BackColor = System.Drawing.Color.Transparent;
            this.btt_Click.BorderColor = System.Drawing.Color.LightPink;
            this.btt_Click.BorderRadius = 20;
            this.btt_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_Click.FillColor = System.Drawing.Color.LightPink;
            this.btt_Click.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Click.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btt_Click.Location = new System.Drawing.Point(139, 546);
            this.btt_Click.Name = "btt_Click";
            this.btt_Click.PressedColor = System.Drawing.Color.Transparent;
            this.btt_Click.Size = new System.Drawing.Size(184, 51);
            this.btt_Click.TabIndex = 10;
            this.btt_Click.Text = "Upload";
            this.btt_Click.Click += new System.EventHandler(this.btt_Click_Click);
            // 
            // PetColorTextBox
            // 
            this.PetColorTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetColorTextBox.BorderRadius = 10;
            this.PetColorTextBox.BorderThickness = 2;
            this.PetColorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetColorTextBox.DefaultText = "";
            this.PetColorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetColorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetColorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetColorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetColorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetColorTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetColorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetColorTextBox.Location = new System.Drawing.Point(800, 205);
            this.PetColorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetColorTextBox.Name = "PetColorTextBox";
            this.PetColorTextBox.PasswordChar = '\0';
            this.PetColorTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetColorTextBox.PlaceholderText = "Enter Color";
            this.PetColorTextBox.SelectedText = "";
            this.PetColorTextBox.Size = new System.Drawing.Size(290, 36);
            this.PetColorTextBox.TabIndex = 9;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PhoneTextBox.BorderRadius = 10;
            this.PhoneTextBox.BorderThickness = 2;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.DefaultText = "";
            this.PhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Location = new System.Drawing.Point(800, 376);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PhoneTextBox.PlaceholderText = "Enter Phone";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.Size = new System.Drawing.Size(290, 36);
            this.PhoneTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.EmailTextBox.BorderRadius = 10;
            this.EmailTextBox.BorderThickness = 2;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Location = new System.Drawing.Point(800, 315);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.EmailTextBox.PlaceholderText = "Enter Email";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(290, 36);
            this.EmailTextBox.TabIndex = 6;
            // 
            // NameClientTextBox
            // 
            this.NameClientTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NameClientTextBox.BorderRadius = 10;
            this.NameClientTextBox.BorderThickness = 2;
            this.NameClientTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameClientTextBox.DefaultText = "";
            this.NameClientTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameClientTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameClientTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameClientTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameClientTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameClientTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameClientTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameClientTextBox.Location = new System.Drawing.Point(800, 260);
            this.NameClientTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameClientTextBox.Name = "NameClientTextBox";
            this.NameClientTextBox.PasswordChar = '\0';
            this.NameClientTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.NameClientTextBox.PlaceholderText = "Enter Name Client";
            this.NameClientTextBox.ReadOnly = true;
            this.NameClientTextBox.SelectedText = "";
            this.NameClientTextBox.Size = new System.Drawing.Size(290, 36);
            this.NameClientTextBox.TabIndex = 5;
            // 
            // PetDofTextBox
            // 
            this.PetDofTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetDofTextBox.BorderRadius = 10;
            this.PetDofTextBox.BorderThickness = 2;
            this.PetDofTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetDofTextBox.DefaultText = "";
            this.PetDofTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetDofTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetDofTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetDofTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetDofTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetDofTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetDofTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetDofTextBox.Location = new System.Drawing.Point(473, 436);
            this.PetDofTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetDofTextBox.Name = "PetDofTextBox";
            this.PetDofTextBox.PasswordChar = '\0';
            this.PetDofTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetDofTextBox.PlaceholderText = "Enter Date of Birth";
            this.PetDofTextBox.SelectedText = "";
            this.PetDofTextBox.Size = new System.Drawing.Size(290, 36);
            this.PetDofTextBox.TabIndex = 4;
            // 
            // PetSubtypeTextBox
            // 
            this.PetSubtypeTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetSubtypeTextBox.BorderRadius = 10;
            this.PetSubtypeTextBox.BorderThickness = 2;
            this.PetSubtypeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetSubtypeTextBox.DefaultText = "";
            this.PetSubtypeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetSubtypeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetSubtypeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSubtypeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSubtypeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSubtypeTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetSubtypeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSubtypeTextBox.Location = new System.Drawing.Point(473, 375);
            this.PetSubtypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetSubtypeTextBox.Name = "PetSubtypeTextBox";
            this.PetSubtypeTextBox.PasswordChar = '\0';
            this.PetSubtypeTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetSubtypeTextBox.PlaceholderText = "Enter SubType";
            this.PetSubtypeTextBox.SelectedText = "";
            this.PetSubtypeTextBox.Size = new System.Drawing.Size(290, 36);
            this.PetSubtypeTextBox.TabIndex = 3;
            // 
            // PetSexTextBox
            // 
            this.PetSexTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetSexTextBox.BorderRadius = 10;
            this.PetSexTextBox.BorderThickness = 2;
            this.PetSexTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetSexTextBox.DefaultText = "";
            this.PetSexTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetSexTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetSexTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSexTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetSexTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSexTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetSexTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetSexTextBox.Location = new System.Drawing.Point(473, 320);
            this.PetSexTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetSexTextBox.Name = "PetSexTextBox";
            this.PetSexTextBox.PasswordChar = '\0';
            this.PetSexTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetSexTextBox.PlaceholderText = "Enter Sex";
            this.PetSexTextBox.SelectedText = "";
            this.PetSexTextBox.Size = new System.Drawing.Size(290, 36);
            this.PetSexTextBox.TabIndex = 2;
            // 
            // PetNameTextBox
            // 
            this.PetNameTextBox.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PetNameTextBox.BorderRadius = 10;
            this.PetNameTextBox.BorderThickness = 2;
            this.PetNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PetNameTextBox.DefaultText = "";
            this.PetNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PetNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PetNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PetNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetNameTextBox.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetNameTextBox.Location = new System.Drawing.Point(473, 265);
            this.PetNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PetNameTextBox.Name = "PetNameTextBox";
            this.PetNameTextBox.PasswordChar = '\0';
            this.PetNameTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PetNameTextBox.PlaceholderText = "Enter Pet Name";
            this.PetNameTextBox.SelectedText = "";
            this.PetNameTextBox.Size = new System.Drawing.Size(290, 36);
            this.PetNameTextBox.TabIndex = 1;
            // 
            // Form_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 630);
            this.Controls.Add(this.bttMoreDetail);
            this.Controls.Add(this.status);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.btt_Click);
            this.Controls.Add(this.PetColorTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameClientTextBox);
            this.Controls.Add(this.PetDofTextBox);
            this.Controls.Add(this.PetSubtypeTextBox);
            this.Controls.Add(this.PetSexTextBox);
            this.Controls.Add(this.PetNameTextBox);
            this.Controls.Add(this.picturepet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_post";
            this.Text = "Form_post";
            this.Load += new System.EventHandler(this.Form_post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturepet;
        private Guna.UI2.WinForms.Guna2TextBox PetNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PetSexTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PetSubtypeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PetDofTextBox;
        private Guna.UI2.WinForms.Guna2TextBox NameClientTextBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PetColorTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTextBox;
        private Guna.UI2.WinForms.Guna2Button btt_Click;
        private Guna.UI2.WinForms.Guna2Button PostButton;
        private Guna.UI2.WinForms.Guna2ComboBox status;
        private Guna.UI2.WinForms.Guna2Button bttMoreDetail;
    }
}