namespace Formochka
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.types = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxLanguage = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.boxLevel = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(159, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(872, 35);
            this.textBox1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStart.Location = new System.Drawing.Point(911, 297);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 45);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // types
            // 
            this.types.AutoSize = true;
            this.types.BackColor = System.Drawing.Color.Transparent;
            this.types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.types.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.types.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.types.Location = new System.Drawing.Point(533, 308);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(81, 30);
            this.types.TabIndex = 2;
            this.types.Text = "Code";
            this.types.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.types.UseVisualStyleBackColor = false;
            this.types.CheckedChanged += new System.EventHandler(this.types_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(159, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 3);
            this.panel1.TabIndex = 7;
            // 
            // boxLanguage
            // 
            this.boxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.boxLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLanguage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.boxLanguage.FormattingEnabled = true;
            this.boxLanguage.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.boxLanguage.Location = new System.Drawing.Point(160, 308);
            this.boxLanguage.Name = "boxLanguage";
            this.boxLanguage.Size = new System.Drawing.Size(154, 30);
            this.boxLanguage.TabIndex = 8;
            this.boxLanguage.Text = "Language";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1199, 112);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Formochka.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(40, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Aqum two", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(1101, 40);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 43);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "×";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // boxLevel
            // 
            this.boxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.boxLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLevel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.boxLevel.FormattingEnabled = true;
            this.boxLevel.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Сложный"});
            this.boxLevel.Location = new System.Drawing.Point(346, 308);
            this.boxLevel.Name = "boxLevel";
            this.boxLevel.Size = new System.Drawing.Size(154, 30);
            this.boxLevel.TabIndex = 12;
            this.boxLevel.Text = "Difficulty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1200, 693);
            this.Controls.Add(this.boxLevel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.boxLanguage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.types);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KlavaCringe";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button buttonStart;
        private CheckBox types;
        private Panel panel1;
        private ComboBox boxLanguage;
        private Panel panel2;
        private Label closeButton;
        private ComboBox boxLevel;
        private PictureBox pictureBox2;
    }
}