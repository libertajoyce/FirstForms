
namespace HelloForms
{
    partial class Form3
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
            this.labelName = new System.Windows.Forms.Label();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonAlien = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPresent = new System.Windows.Forms.DateTimePicker();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPresent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgres = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(62, 101);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(56, 21);
            this.radioButtonMan.TabIndex = 2;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(160, 101);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonAlien
            // 
            this.radioButtonAlien.AutoSize = true;
            this.radioButtonAlien.Location = new System.Drawing.Point(287, 101);
            this.radioButtonAlien.Name = "radioButtonAlien";
            this.radioButtonAlien.Size = new System.Drawing.Size(60, 21);
            this.radioButtonAlien.TabIndex = 4;
            this.radioButtonAlien.TabStop = true;
            this.radioButtonAlien.Text = "Alien";
            this.radioButtonAlien.UseVisualStyleBackColor = true;
            this.radioButtonAlien.CheckedChanged += new System.EventHandler(this.radioButtonAlien_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(127, 158);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerBirth.TabIndex = 5;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
            // 
            // dateTimePickerPresent
            // 
            this.dateTimePickerPresent.Location = new System.Drawing.Point(127, 201);
            this.dateTimePickerPresent.Name = "dateTimePickerPresent";
            this.dateTimePickerPresent.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerPresent.TabIndex = 6;
            this.dateTimePickerPresent.ValueChanged += new System.EventHandler(this.dateTimePickerPresent_ValueChanged);
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(62, 162);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(37, 17);
            this.labelBirth.TabIndex = 8;
            this.labelBirth.Text = "Birth";
            // 
            // labelPresent
            // 
            this.labelPresent.AutoSize = true;
            this.labelPresent.Location = new System.Drawing.Point(62, 201);
            this.labelPresent.Name = "labelPresent";
            this.labelPresent.Size = new System.Drawing.Size(57, 17);
            this.labelPresent.TabIndex = 9;
            this.labelPresent.Text = "Present";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(127, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // labelProgres
            // 
            this.labelProgres.AutoSize = true;
            this.labelProgres.Location = new System.Drawing.Point(59, 269);
            this.labelProgres.Name = "labelProgres";
            this.labelProgres.Size = new System.Drawing.Size(65, 17);
            this.labelProgres.TabIndex = 11;
            this.labelProgres.Text = "Progress";
            // 
            // buttonGo
            // 
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(134, 344);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(176, 58);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelloForms.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(465, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelProgres);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelPresent);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.dateTimePickerPresent);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonAlien);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.labelName);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonAlien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerPresent;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPresent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgres;
        private System.Windows.Forms.Button buttonGo;
    }
}