using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek4
{
    public partial class Form2 : Form
    {
        public static Form1 forum = new Form1();
        public static int counter = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public DataTable dataPersonal = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxNamaForm2.Text = Form1.SetValueForText1;
            textBoxAlamatForm2.Text = Form1.SetValueForText2;
            textBoxTelpForm2.Text = Form1.SetValueForText3;
        } 
        private void buttonNextData_Click(object sender, EventArgs e)
        {   
            if (counter != 10)
            {
                textBoxNamaForm2.Text = forum.dataPersonal.Rows[counter + 1][0].ToString();
                textBoxAlamatForm2.Text = forum.dataPersonal.Rows[counter + 1][1].ToString();
                textBoxTelpForm2.Text = forum.dataPersonal.Rows[counter + 1][2].ToString();
                counter++;
            }
            else
            {
                MessageBox.Show("sudah max");
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
