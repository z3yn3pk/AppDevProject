namespace WindowsFormsApp1
{
    partial class FreeEstimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeEstimationForm));
            this.Title = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.Title3 = new System.Windows.Forms.Label();
            this.servicesList = new System.Windows.Forms.CheckedListBox();
            this.frButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(257, 244);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(517, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Free Estimation | Contact Form";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.Location = new System.Drawing.Point(86, 330);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(210, 32);
            this.Title2.TabIndex = 1;
            this.Title2.Text = "Select Services";
            // 
            // Title3
            // 
            this.Title3.AutoSize = true;
            this.Title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title3.Location = new System.Drawing.Point(712, 330);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(246, 32);
            this.Title3.TabIndex = 2;
            this.Title3.Text = "Approximate Price";
            // 
            // servicesList
            // 
            this.servicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Items.AddRange(new object[] {
            "General Pressure Washing                                                     $123" +
                ",99",
            "Graffiti Removal                                                                 " +
                "     $270,50",
            "Truck Fleet Cleaning                                                             " +
                "  $180,45",
            "Gutter Cleaning & Installation                                                 $3" +
                "99,99",
            "Stain Removal                                                                    " +
                "     $135,00",
            "Paint Stripping                                                                  " +
                "       $220,50"});
            this.servicesList.Location = new System.Drawing.Point(92, 383);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(866, 208);
            this.servicesList.TabIndex = 3;
            this.servicesList.SelectedIndexChanged += new System.EventHandler(this.servicesList_SelectedIndexChanged);
            // 
            // frButton
            // 
            this.frButton.Location = new System.Drawing.Point(896, 61);
            this.frButton.Name = "frButton";
            this.frButton.Size = new System.Drawing.Size(62, 45);
            this.frButton.TabIndex = 4;
            this.frButton.Text = "FR";
            this.frButton.UseVisualStyleBackColor = true;
            this.frButton.Click += new System.EventHandler(this.frButton_Click);
            // 
            // enButton
            // 
            this.enButton.Location = new System.Drawing.Point(828, 61);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(62, 45);
            this.enButton.TabIndex = 5;
            this.enButton.Text = "EN";
            this.enButton.UseVisualStyleBackColor = true;
            this.enButton.Click += new System.EventHandler(this.enButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(323, 725);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(374, 30);
            this.numberBox.TabIndex = 7;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(323, 795);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(374, 30);
            this.addressBox.TabIndex = 8;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // companyNameBox
            // 
            this.companyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameBox.Location = new System.Drawing.Point(324, 856);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(374, 30);
            this.companyNameBox.TabIndex = 9;
            this.companyNameBox.TextChanged += new System.EventHandler(this.companyNameBox_TextChanged);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox.Location = new System.Drawing.Point(323, 922);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(374, 30);
            this.questionBox.TabIndex = 10;
            this.questionBox.TextChanged += new System.EventHandler(this.questionBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(324, 659);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(178, 30);
            this.nameBox.TabIndex = 11;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(520, 658);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(177, 30);
            this.emailBox.TabIndex = 12;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // notesBox
            // 
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(323, 994);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(373, 96);
            this.notesBox.TabIndex = 13;
            this.notesBox.Text = "";
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(420, 1108);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(177, 53);
            this.sendMessageButton.TabIndex = 14;
            this.sendMessageButton.Text = "Send Message";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(329, 636);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(329, 702);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(115, 20);
            this.numberLabel.TabIndex = 17;
            this.numberLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(329, 772);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 18;
            this.addressLabel.Text = "Address";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(329, 833);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(192, 20);
            this.companyLabel.TabIndex = 19;
            this.companyLabel.Text = "Company Name (optional)";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(329, 899);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(221, 20);
            this.questionLabel.TabIndex = 20;
            this.questionLabel.Text = "Where did you hear about us?";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(329, 971);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(137, 20);
            this.notesLabel.TabIndex = 21;
            this.notesLabel.Text = "Additional Notes...";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(526, 636);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 20);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "E-Mail";
            // 
            // FreeEstimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 1173);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.enButton);
            this.Controls.Add(this.frButton);
            this.Controls.Add(this.servicesList);
            this.Controls.Add(this.Title3);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "FreeEstimationForm";
            this.Text = "Free Estimation Form";
            this.Load += new System.EventHandler(this.FreeEstimationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.CheckedListBox servicesList;
        private System.Windows.Forms.Button frButton;
        private System.Windows.Forms.Button enButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}