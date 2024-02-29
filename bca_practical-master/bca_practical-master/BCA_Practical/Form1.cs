using BCA_Practical.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_Practical
{
    public partial class Form1 : Form
    {
        int fn, sn;  //these are global variables
        public Form1()
        {
            InitializeComponent();
            Days d = Days.Sunday;

            d.ToString();
            int noOfDays = (int)d;
        }

        void getNumberValues()
        {
            int fn = Convert.ToInt32(txtFirstNumber.Text);
            int sn = Convert.ToInt32(txtSecondNumber.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string pn = txtPersonName.Text;
            string cn = txtCountryName.Text;

            if (string.IsNullOrEmpty(pn))  // pn == ""
            {
                MessageBox.Show("Enter Person Name");
            }
            else if (string.IsNullOrEmpty(cn))
            {
                MessageBox.Show("Enter Country Name");
            }
            else
            {
                //string msg = "Hello " + pn + ". Welcome to " + cn;
                string msg = string.Format("Hello {0}. Welcome to {1}. Have fun {0}!!"
                                        , pn, cn);
                MessageBox.Show(msg);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            getNumberValues();

            int sum = fn + sn;
            string msg = "The sum of two number is " + sum.ToString();
            MessageBox.Show(msg, "SUM");
        }

        private void btnIsEqual_Click(object sender, EventArgs e)
        {
            getNumberValues();
            string msg = fn == sn ? "The numbers are EQUAL" : "NOT EQUAL";
            MessageBox.Show(msg);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            getNumberValues();
            fn += 5;
            sn -= 10;

            string msg = "First Number is increased by 5. RESULT = " + fn.ToString();
            MessageBox.Show(msg);

            msg = "Second number is decreased by 10. RESULT = " + sn.ToString();
            MessageBox.Show(msg);
        }

        private void btnSum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle c1, c2;
            //string rad = txtRadius.Text;
            //if (string.IsNullOrEmpty(rad))
            //{
            //    rad = "0";
            //}

            //c1 = new Circle(Convert.ToInt32(rad));
            c1 = new Circle(3);
            c2 = new Circle(5);
            Circle c3 = c1 + c2;
            MessageBox.Show("The radius of big circle is : " + c3.radius.ToString());
            //MessageBox.Show(c1.GetArea());
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            List<int> marks = new List<int>();
            marks.Add(10);
            marks.Add(20);
            marks.Add(30);
            marks.Add(40);
            marks.Add(50);
            marks.Add(60);
            marks.Add(70);

            foreach (int item in marks)
            {
                if (item % 3 == 0)
                {
                    break;
                }
                MessageBox.Show(item.ToString());
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Fullname", "Ram");
            d.Add("Age", "20");
            d.Add("Address", "Kathmandu");

            foreach (var item in d)
            {
                MessageBox.Show("Key: " + item.Key + " & Value: " + item.Value);
            }
        }

        private void btnGoToStudent_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Circle> c = new List<Circle>();
            List<Circle> c2 = new List<Circle>();
            c.Add(new Circle()
            {
                radius = 1
            });
            c.Add(new Circle()
            {
                radius = 5
            });
            c.Add(new Circle()
            {
                radius = 10
            });

            c2.AddRange(c);
            c2.Add(new Circle()
            {
                radius = 20
            });


            foreach (Circle item in c)
            {
                MessageBox.Show("The radius of circle is " + item.radius.ToString());
            }

            MessageBox.Show(string.Format("There are {0} items in list", c.Count.ToString()));
            c.Clear();
            MessageBox.Show(string.Format("There are {0} items in list", c.Count.ToString()));

        }
    }
}
