namespace student_notes_making_system
{
    partial class notes_and_timet3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notes_and_timet3));
            btntimetbl = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btntimetbl
            // 
            btntimetbl.BackgroundImage = (Image)resources.GetObject("btntimetbl.BackgroundImage");
            btntimetbl.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btntimetbl.ForeColor = SystemColors.AppWorkspace;
            btntimetbl.Location = new Point(85, 44);
            btntimetbl.Name = "btntimetbl";
            btntimetbl.Size = new Size(208, 64);
            btntimetbl.TabIndex = 0;
            btntimetbl.Text = "Timetable";
            btntimetbl.UseVisualStyleBackColor = true;
            btntimetbl.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.AppWorkspace;
            button2.Location = new Point(226, 164);
            button2.Name = "button2";
            button2.Size = new Size(208, 62);
            button2.TabIndex = 1;
            button2.Text = "Subjects";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // notes_and_timet3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btntimetbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "notes_and_timet3";
            Text = "notes_and_timet";
            Load += notes_and_timet3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btntimetbl;
        private Button button2;
    }
}