﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        int setMinutes;
        int setHours;

        Minutes m1 = new Minutes();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        { 
            timer1.Stop();
            StopButton.Text = "Stop";
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            setMinutes = int.Parse(SetMinTextBox.Text);
            setMinutes = Convert.ToInt32(SetMinTextBox.Text);
            
            

            if (setMinutes >= 60)//CONTROL SO THEY ENTER 1 - 59 FOR THE MINUTES
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else
            {
                minuteLabel.Text = setMinutes.ToString();//SETS THE USERINPUT FROM MINUTE TEXTBOX TO THE MINUTE LABEL
            }

        }

        private void SetHourTextBox_TextChanged(object sender, EventArgs e)
        {
            
            setHours = Convert.ToInt32(SetHourTextBox.Text);
            setHours = int.Parse(SetHourTextBox.Text);
            


            if (setHours >= 24)//CONTROL SO THEY ENTER 1 - 23 FOR THE MINUTES
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else
            {
                HourLabel.Text = setHours.ToString();//SETS THE USERINPUT FROM MINUTE TEXTBOX TO THE MINUTE LABEL
            }
        }

    }
}
