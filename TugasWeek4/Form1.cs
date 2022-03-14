using System;
using System.Data;
using System.Windows.Forms;

namespace TugasWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable dataPersonal = new DataTable();

        public static Form1 Instance { get; set; }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataPersonal.Columns.Add("Nama");
            dataPersonal.Columns.Add("Alamat");
            dataPersonal.Columns.Add("Telp");

            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            buttonKembali.Visible = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            dataPersonal.Rows.Add(textBoxNama.Text, textBoxAlamat.Text, textBoxTelp.Text);
            /*labelOutput.Text = dataPersonal.Rows[0][0].ToString();*/

            if (dataPersonal.Rows.Count < 10)
            {
                textBoxNama.Text = SetValueForText1;
                textBoxAlamat.Text = SetValueForText2;
                textBoxTelp.Text = SetValueForText3;
            }
            else
            {
                MessageBox.Show("Data telah penuh!");
            }

            /*
             SetValueForText1 = textBoxNama.Text;
            SetValueForText2 = textBoxAlamat.Text;
            SetValueForText3 = textBoxTelp.Text;
             */

            /*
            textBoxNama.Text = SetValueForText1;
            textBoxAlamat.Text = SetValueForText2;
            textBoxTelp.Text = SetValueForText3;
            */
        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = dataPersonal.Rows[counter][0].ToString();
            textBoxAlamat.Text = dataPersonal.Rows[counter][1].ToString();
            textBoxTelp.Text = dataPersonal.Rows[counter][2].ToString();

            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxTelp.Enabled = false;

            buttonNext.Visible = true;
            buttonPrev.Visible = true;
            buttonKembali.Visible = true;
            buttonLihatData.Visible = false;

            this.Text = "Form Tampilan Data";
            /*
             * this.Hide();
            forum.Show();
            Form2 form = new Form2();
            form.Show();
            */
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonLihatData.Visible = false;
            if ((counter + 1) != dataPersonal.Rows.Count)
            {
                counter++;
                textBoxNama.Text = dataPersonal.Rows[counter][0].ToString();
                textBoxAlamat.Text = dataPersonal.Rows[counter][1].ToString();
                textBoxTelp.Text = dataPersonal.Rows[counter][2].ToString();
            }
            else
            {
                MessageBox.Show("sudah max");
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            buttonLihatData.Visible = false;
            if ((counter-1) >= 0)
            {
                counter--;
                textBoxNama.Text = dataPersonal.Rows[counter][0].ToString();
                textBoxAlamat.Text = dataPersonal.Rows[counter][1].ToString();
                textBoxTelp.Text = dataPersonal.Rows[counter][2].ToString();
            }
            else
            {
                MessageBox.Show("sudah max");
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelp.Text = "";

            textBoxNama.ReadOnly = false;
            textBoxAlamat.ReadOnly = false;
            textBoxTelp.ReadOnly = false;

            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            buttonKembali.Visible = false;
            buttonLihatData.Visible = true;
        }
    }
}
