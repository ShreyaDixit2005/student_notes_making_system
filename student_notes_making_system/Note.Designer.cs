namespace student_notes_making_system
{
    partial class Note
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            panel1 = new Panel();
            Save = new Button();
            Content = new RichTextBox();
            Pin = new Button();
            TitleName = new TextBox();
            TitleLable = new Label();
            Delete = new Button();
            Update = new Button();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(Save);
            panel1.Controls.Add(Content);
            panel1.Controls.Add(Pin);
            panel1.Controls.Add(TitleName);
            panel1.Controls.Add(TitleLable);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Update);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Save
            // 
            Save.BackgroundImage = (Image)resources.GetObject("Save.BackgroundImage");
            Save.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = SystemColors.AppWorkspace;
            Save.Location = new Point(696, 262);
            Save.Name = "Save";
            Save.Size = new Size(92, 39);
            Save.TabIndex = 12;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Content
            // 
            Content.BackColor = SystemColors.InactiveCaptionText;
            Content.Location = new Point(0, 106);
            Content.Name = "Content";
            Content.Size = new Size(684, 345);
            Content.TabIndex = 11;
            Content.Text = "";
            Content.TextChanged += richTextBox1_TextChanged;
            // 
            // Pin
            // 
            Pin.BackgroundImage = (Image)resources.GetObject("Pin.BackgroundImage");
            Pin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pin.ForeColor = SystemColors.AppWorkspace;
            Pin.Location = new Point(696, 307);
            Pin.Name = "Pin";
            Pin.Size = new Size(92, 39);
            Pin.TabIndex = 9;
            Pin.Text = "Pin";
            Pin.UseVisualStyleBackColor = true;
            // 
            // TitleName
            // 
            TitleName.BackColor = Color.DimGray;
            TitleName.BorderStyle = BorderStyle.None;
            TitleName.Location = new Point(21, 56);
            TitleName.Multiline = true;
            TitleName.Name = "TitleName";
            TitleName.Size = new Size(255, 34);
            TitleName.TabIndex = 7;
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.Font = new Font("Times New Roman", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLable.ForeColor = Color.White;
            TitleLable.Location = new Point(12, 10);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(84, 43);
            TitleLable.TabIndex = 6;
            TitleLable.Text = "Title";
            TitleLable.Click += label1_Click;
            // 
            // Delete
            // 
            Delete.BackgroundImage = (Image)resources.GetObject("Delete.BackgroundImage");
            Delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = SystemColors.AppWorkspace;
            Delete.Location = new Point(696, 397);
            Delete.Name = "Delete";
            Delete.Size = new Size(92, 39);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += button3_Click;
            // 
            // Update
            // 
            Update.BackgroundImage = (Image)resources.GetObject("Update.BackgroundImage");
            Update.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = SystemColors.AppWorkspace;
            Update.Location = new Point(696, 352);
            Update.Name = "Update";
            Update.Size = new Size(92, 39);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += button1_Click;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Note";
            Text = "Note";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TitleLable;
        private Button Delete;
        private Button Update;
        private TextBox TitleName;
        private BindingSource bindingSource1;
        private Button Pin;
        private RichTextBox Content;
        private Button Save;
    }
}