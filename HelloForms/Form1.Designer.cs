
namespace HelloForms
{
    partial class GamingStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamingStoreForm));
            this.gameName = new System.Windows.Forms.Label();
            this.gameNameText = new System.Windows.Forms.TextBox();
            this.releaseDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genreDropDown = new System.Windows.Forms.ListBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.checkBoxUsed = new System.Windows.Forms.CheckBox();
            this.NewCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(172, 443);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(401, 49);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Name of the game";
            // 
            // gameNameText
            // 
            this.gameNameText.Location = new System.Drawing.Point(643, 444);
            this.gameNameText.Name = "gameNameText";
            this.gameNameText.Size = new System.Drawing.Size(581, 49);
            this.gameNameText.TabIndex = 1;
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDate.Location = new System.Drawing.Point(172, 556);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(290, 49);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(643, 556);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(581, 49);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // genreDropDown
            // 
            this.genreDropDown.FormattingEnabled = true;
            this.genreDropDown.ItemHeight = 42;
            this.genreDropDown.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "RPG",
            "Fantasy",
            "Sports",
            "Horror"});
            this.genreDropDown.Location = new System.Drawing.Point(643, 658);
            this.genreDropDown.Name = "genreDropDown";
            this.genreDropDown.Size = new System.Drawing.Size(586, 46);
            this.genreDropDown.TabIndex = 6;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(172, 655);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(280, 49);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Game Genre";
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPicBox.InitialImage")));
            this.logoPicBox.Location = new System.Drawing.Point(83, 12);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(1420, 383);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 8;
            this.logoPicBox.TabStop = false;
            // 
            // checkBoxUsed
            // 
            this.checkBoxUsed.AutoSize = true;
            this.checkBoxUsed.Location = new System.Drawing.Point(643, 778);
            this.checkBoxUsed.Name = "checkBoxUsed";
            this.checkBoxUsed.Size = new System.Drawing.Size(154, 48);
            this.checkBoxUsed.TabIndex = 13;
            this.checkBoxUsed.Text = "Used";
            this.checkBoxUsed.UseVisualStyleBackColor = true;
            // 
            // NewCheckBox
            // 
            this.NewCheckBox.AutoSize = true;
            this.NewCheckBox.Location = new System.Drawing.Point(643, 854);
            this.NewCheckBox.Name = "NewCheckBox";
            this.NewCheckBox.Size = new System.Drawing.Size(141, 48);
            this.NewCheckBox.TabIndex = 14;
            this.NewCheckBox.Text = "New";
            this.NewCheckBox.UseVisualStyleBackColor = true;
            // 
            // GamingStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2118, 1237);
            this.Controls.Add(this.NewCheckBox);
            this.Controls.Add(this.checkBoxUsed);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreDropDown);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.gameNameText);
            this.Controls.Add(this.gameName);
            this.Name = "GamingStoreForm";
            this.Text = "Gaming Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.TextBox gameNameText;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox genreDropDown;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.CheckBox checkBoxUsed;
        private System.Windows.Forms.CheckBox NewCheckBox;
    }
}

