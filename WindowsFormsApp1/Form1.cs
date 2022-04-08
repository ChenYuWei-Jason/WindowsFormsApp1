using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] names = new string[] { "aaa", "bbb", "ccc", "Mary", "Tom" };
            int x=names[0].Length;
            string s="";
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > x)
                { x = names[i].Length;
                    s = names[i];
                }
            }
            MessageBox.Show(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            String[] names = new string[] { "aaa", "bbb", "ccc", "Mary", "Tom" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains('C') || names[i].Contains('c'))
                {
                    sum++;
                }
            }
            MessageBox.Show(sum.ToString());
        }

        void a(int[] b)
        {

            int max = b[0];
            int min = b[0];

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                }
                if (b[i] < min)
                {
                    min = b[i];
                }
          
            }
            MessageBox.Show("ANS:  "+max.ToString()+" "+ min.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 44, 66, 99, 100, 78 };
            a(nums);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a=0;
            int b=0;

            int[] nums = new int[] { 44, 66, 99, 100, 78 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
            { a++; }
            else
            { b++; }
            }

            MessageBox.Show("偶數:" + a + "個\n" + "奇數" + b + "個");
        }
    
    }
}
