using System;
using System.Windows.Forms;

namespace HelloForms
{
    public partial class Form3 : Form
    {
        private Person formAge = new Person();
       


        public Form3()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DateTime startdate = dateTimePickerBirth.Value;
            DateTime enddate = dateTimePickerPresent.Value;
         
            ageGenerator(startdate, enddate).ToString();
            MessageBox.Show($"Hello {formAge.Name}, you are a {formAge.Gender} and your age is: { ageGenerator(startdate, enddate).ToString()}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            formAge.Name = textBoxName.Text;
            checkButton();
            progressBar1.Value = 10;
        }

        private void checkButton()
        {
            buttonGo.Enabled = formAge.IsValid2; //Turns on button if all fields are valid
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            formAge.Gender = Gender.Male;
            checkButton();
            pictureSelection();
            progressBar1.Value = 30;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            formAge.Gender = Gender.Female;
            checkButton();
            pictureSelection();
            progressBar1.Value = 30;
        }

        private void radioButtonAlien_CheckedChanged(object sender, EventArgs e)
        {
            formAge.Gender = Gender.Alien;
            pictureSelection();
            progressBar1.Value = 30;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureSelection();
        }

        private void pictureSelection()
        {
            if (radioButtonMan.Checked)
            {
                pictureBox1.Image = Properties.Resources.mario;
            }
            else if (radioButtonFemale.Checked)
            {
                pictureBox1.Image = Properties.Resources.Peach;
            }
            else if (radioButtonAlien.Checked)
            {
                pictureBox1.Image = Properties.Resources.cute_alien;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.download;
            }
        }

        private  void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 90;
        }

        private void dateTimePickerPresent_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }
       public long ageGenerator(System.DateTime Startdate, System.DateTime EndDate)
        {
        
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - Startdate.Ticks);
            age = (long)(ts.Days / 365);
            return age;
        }
    }
}