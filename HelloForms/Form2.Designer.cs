
namespace HelloForms
{
    partial class Form2
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
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textMovie = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(68, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Location = new System.Drawing.Point(68, 167);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(100, 17);
            this.labelMovie.TabIndex = 1;
            this.labelMovie.Text = "Favorite Movie";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(68, 209);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(96, 17);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Favorite Color";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(68, 254);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(190, 123);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 4;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textMovie
            // 
            this.textMovie.Location = new System.Drawing.Point(190, 164);
            this.textMovie.Name = "textMovie";
            this.textMovie.Size = new System.Drawing.Size(100, 22);
            this.textMovie.TabIndex = 5;
            this.textMovie.TextChanged += new System.EventHandler(this.textMovie_TextChanged);
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(190, 209);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 22);
            this.textColor.TabIndex = 6;
            this.textColor.TextChanged += new System.EventHandler(this.textColor_TextChanged);
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(190, 254);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 22);
            this.textAge.TabIndex = 7;
            this.textAge.TextChanged += new System.EventHandler(this.textAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(356, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 8;
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Location = new System.Drawing.Point(71, 304);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(150, 28);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Don\'t Randomize";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.Enabled = false;
            this.ButtonRandom.Location = new System.Drawing.Point(248, 304);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(108, 28);
            this.ButtonRandom.TabIndex = 10;
            this.ButtonRandom.Text = "Random";
            this.ButtonRandom.UseVisualStyleBackColor = true;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Randomizer";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.textMovie);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelMovie);
            this.Controls.Add(this.labelName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textMovie;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.Label label2;
    }
}