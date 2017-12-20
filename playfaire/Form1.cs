using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace playfaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alpha = "abcdefghiklmnopqrstuvwxyz";
            string key = textBox1.Text;
            string conbArray = key + alpha, outputArray = null;
           
            bool flag;
          
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;

            dataGridView2.ColumnCount = 5;
            dataGridView2.RowCount = 5;

            //وضع الحروف الابجدية في داتا كريد على شكل مصفوفة//
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    dataGridView1[j, i].Value = alpha[count++];

            }
         
           for (int i1 = 0; i1 < conbArray.Length; i1++)
           {
               flag = false;
               for (int j1 = 0; j1 < i1; j1++)
               {
                   if (conbArray[i1] == conbArray[j1])
                   {
                       flag = true;
                       break;
                   }
               }
               if (flag == false)
               {
                   outputArray += conbArray[i1];
                   
                 
               }
               
           }
           textBox2.Text = outputArray;
           //وضع الحروف الابجدية في داتا كريد على شكل مصفوفة//
           count = 0;
           for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
                   dataGridView2[j, i].Value = outputArray[count++];

           }
          
           
        }

     
    }
}
