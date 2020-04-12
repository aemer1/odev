using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int x = new int();
        int addingdate = -1;
        List<String> namestring = new List<String>();
        List<String> addingdatestring = new List<String>();
        public Form1()
        {

            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int counter = 0;
                int newcounter = 0;
                int debt = Convert.ToInt32(textBox2.Text);
                
                addingdate++;
                

                char[] name = textBox1.Text.ToCharArray();
                char[] surname = textBox4.Text.ToCharArray();
                for (int i=0; i<name.Length;i++)
                {
                    x = Convert.ToInt32(name[i]);

                    if (((x >= 65) && (x <= 90)) || ((x >= 97) && (x <= 122)))
                    { }
                    else
                    {
                        counter++;
                    }
                  
                    
                }
                for (int i = 0; i < surname.Length; i++)
                {
                    x = Convert.ToInt32(surname[i]);

                    if (((x >= 65) && (x <= 90)) || ((x >= 97) && (x <= 122)))
                    { }
                    else
                    {
                        counter++;
                    }
                }
                for (int i = 0; i < name.Length; i++)
                {
                    x = Convert.ToInt32(name[i]);

                    if (((x >= 97) && (x <= 122) && (newcounter == 0)))
                    {
                        name[i] = Convert.ToChar(x - 32);
                        newcounter++;
                    }
                    else if ((x >= 65) && (x <= 90) && (newcounter == 0))
                    {
                        newcounter++;
                    }
                    else if ((x >= 65) && (x <= 90))
                    {
                        name[i] = Convert.ToChar(x + 32);
                    }

                }
                newcounter = 0;
                for (int i = 0; i < surname.Length; i++)
                {
                    x = Convert.ToInt32(surname[i]);

                    if (((x >= 97) && (x <= 122) && (newcounter==0 )))
                    {
                        surname[i] = Convert.ToChar(x - 32);
                        newcounter++;
                    }
                    else if ((x >= 65) && (x <= 90) && (newcounter == 0))
                    {
                        newcounter++;
                    }
                    else if ((x >= 65) && (x <= 90))
                    {
                        surname[i] = Convert.ToChar(x+32);
                    }
                    
                }
                string strname = new string(name);
                string strsurname = new string(surname);
                namestring.Add(strname + " " + strsurname + " : " + textBox2.Text);
                addingdatestring.Add(strname + " " + strsurname + " : " + textBox2.Text);
                if (counter==0)
                listBox1.Items.Add(strname + " " + strsurname + " : " + textBox2.Text);
                else
                MessageBox.Show("please write vaild informations");

            }
            catch
            {
                MessageBox.Show("please write vaild informations");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string change;
                int m = Convert.ToInt32(textBox3.Text);
                listBox1.Items.RemoveAt(m - 1);
                if(radioButton1.Checked)
                {
                change = addingdatestring[m-1];
                addingdatestring.RemoveAt(m - 1);
                    for (int i = 0; i < namestring.Count; i++)
                    {
                        if (namestring[i]==change)
                        {
                            namestring.RemoveAt(i);
                            break;

                        }
                    }
                }
                if (radioButton2.Checked)
                {
                change = namestring[m - 1];
                namestring.RemoveAt(m - 1);
                    for (int i = 0; i < addingdatestring.Count; i++)
                    {
                        if (addingdatestring[i] == change)
                        {
                            addingdatestring.RemoveAt(i);
                            break;

                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("please write a vaild number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is used to count the amount of money that a customer needs to pay for an apartmant/dorm ");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            namestring.Sort();
            for (int i=0;i< namestring.Count;i++)
            {
                listBox1.Items.Add(namestring[i]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < addingdatestring.Count; i++)
            {
                listBox1.Items.Add(addingdatestring[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
