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
    public partial class Analiz : Form
    {
        Form2 f2 = new Form2();
        public Analiz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(LenghtA.Text);
            int b = int.Parse(LenghtB.Text);
            int c = int.Parse(LenghtC.Text);

            if (a == b && a == c && c == b)
            {
                f2.Answer.Text += " равносторонний";
                this.Visible = false;
                f2.Show();
            }

            if (a == b || a == c || c == b)
            {
                f2.Answer.Text += " равнобедренный";
                this.Visible = false;
                f2.Show();
            }

            if (a != b && a != c && c != b)
            {
                f2.Answer.Text += " разносторонний";
                this.Visible = false;
                f2.Show();
            }

           
            

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void LenghtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
