using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public class HealthRecords
        {
            private string firstName;
            private string lastName;
            private string gender;
            private int birthDay;
            private int birthMonth;
            private int height;
            private int weight;

            public string First
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            public string Last
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            public string Gender
            {
                get
                {
                    return gender;
                }
                set
                {
                    gender = value;
                }
            }
            public int BirthDay
            {
                get
                {
                    return birthDay;
                }
                set
                {
                    birthDay = value;
                }
            }
            public int BirthMonth
            {
                get
                {
                    return birthMonth;
                }
                set
                {
                    birthMonth = value;
                }
            }
            public int BirthYear
            {
                get
                {
                    return birthMonth;
                }
                set
                {
                    birthMonth = value;
                }
            }
            public int Height
            {
                get
                {
                    return height;
                }
                set
                {
                    height = value;
                }
            }
            public int Weight
            {
                get
                {
                    return weight;
                }
                set
                {
                    weight = value;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {
            this.Text = First_Name.Text;
        }

        private void Last_Name_TextChanged(object sender, EventArgs e)
        {
            this.Text = Last_Name.Text;
        }

        private void GENDER_TextChanged(object sender, EventArgs e)
        {
            this.Text = GENDER.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string gender;
            decimal birthDay;
            decimal birthMonth;
            decimal birthYear;
            decimal height;
            decimal weight;

            first = First_Name.Text;
            last = Last_Name.Text;
            gender = GENDER.Text;
            birthDay = numericUpDown1.Value;
            birthMonth = numericUpDown3.Value;
            birthYear = numericUpDown2.Value;
            weight = numericUpDown4.Value;
            height = numericUpDown5.Value;

            int currentYear = 2012;
            int age = currentYear - (int)birthYear;
            float bmi =(float)((weight * 703) / (height * height));
            int maxHeartRate = 220 - age;
            double tarMaxHR = (double)maxHeartRate * .85;
            int tarMinHR = maxHeartRate / 2;

            richTextBox1.Text = "Name: " + first + " " + last + "\r\n" +
            "Gender: " + gender + "\r\n" + "Age: " + age + "\r\n" +
            "Weight: " + weight + "\r\n" + "Height: " + height + "\r\n" +
            "Max Heart Rate: " + maxHeartRate + "\r\n" +
            "Target max heart rate: " + tarMaxHR + "\r\n" +
            "Target min heart rate: " + tarMinHR + "\r\n" + "BMI: " + bmi + "\r\n" + "\r\n" +
            "BMI Table " + "\r\n" + "Underweight: less than 18.5" + "\r\n" +
            "Normal: between 18.5 and 24.9" + "\r\n" + "Overweight: between 25 and 29.9" + "\r\n";

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = richTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Health Form";
        }

    }
}
