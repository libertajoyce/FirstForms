using System;
using System.Windows.Forms;

namespace HelloForms
{
    public partial class Form2 : Form
    {
        private static Person input = new Person();
        private Random generateRandom = new Random();

        private string[] randomArray = { input.Name, input.Movie, input.Color };

        public Form2()
        {
            InitializeComponent();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            input.Name = textName.Text; //Puts text value into name property
            checkButton(); //Method that checks if
        }

        private void textMovie_TextChanged(object sender, EventArgs e)
        {
            input.Movie = textMovie.Text;
            checkButton();
        }

        private void textColor_TextChanged(object sender, EventArgs e)
        {
            input.Color = textColor.Text;
            checkButton();
        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {
            int age = 0;

            if (int.TryParse(textAge.Text, out age)) //TryParse = converts and returns true or false depending if it succeeded
            {
                input.Age = age;
            }
            else
            {
                input.Age = 0;
            }
            checkButton();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            label1.Text = $"Hello {input.Name} your favorite movie is {input.Movie} \r\n favorite color is {input.Color} and your age is {input.Age}";
        }

        private void checkButton()
        {
            buttonDone.Enabled = input.IsValid; //Turns on button if all fields are valid
            ButtonRandom.Enabled = input.IsValid;
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            int option = generateRandom.Next(1, 4);
            if (option == 1)
            {
                label1.Text = $"Hello {input.Age} your favorite movie is {input.Color} \r\n favorite color is {input.Name} and your age is {input.Movie}";
            }
            else if (option == 2)
            {
                label1.Text = $"Hello {input.Color} your favorite movie is {input.Movie} \r\n favorite color is {input.Age} and your age is {input.Name}";
            }
            else
            {
                label1.Text = $"Hello {input.Movie} your favorite movie is {input.Age} \r\n favorite color is {input.Movie} and your age is {input.Color}";
            }
        }
    }
}