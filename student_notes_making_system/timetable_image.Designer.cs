namespace student_notes_making_system
{
    partial class timetable_image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timetable_image));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Back = new Button();
            Year_Label = new Label();
            Image = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Back);
            panel1.Controls.Add(Year_Label);
            panel1.Controls.Add(Image);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(624, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(8, 8);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Back
            // 
            Back.BackgroundImage = (Image)resources.GetObject("Back.BackgroundImage");
            Back.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.AppWorkspace;
            Back.Location = new Point(720, 405);
            Back.Name = "Back";
            Back.Size = new Size(68, 33);
            Back.TabIndex = 13;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button4_Click;
            // 
            // Year_Label
            // 
            Year_Label.AutoSize = true;
            Year_Label.BackColor = SystemColors.ControlDark;
            Year_Label.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Year_Label.Location = new Point(343, 0);
            Year_Label.Name = "Year_Label";
            Year_Label.Size = new Size(118, 25);
            Year_Label.TabIndex = 4;
            Year_Label.Text = "Third Year";
            // 
            // Image
            // 
            Image.Location = new Point(277, 36);
            Image.Name = "Image";
            Image.Size = new Size(261, 402);
            Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Image.TabIndex = 2;
            Image.TabStop = false;
            Image.Click += pictureBox3_Click;
            // 
            // timetable_image
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "timetable_image";
            Text = "timetable_image";
            Load += timetable_image_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Image;
        private Label Year_Label;
        private Button Back;
        private PictureBox pictureBox1;
    }
}