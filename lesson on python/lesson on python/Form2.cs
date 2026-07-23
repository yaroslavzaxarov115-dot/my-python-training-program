using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_on_python
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //не нужно
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //не нужно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sc = 0;

            if (checkBox1.Checked) sc++;
            if (checkBox7.Checked) sc++;
            if (checkBox12.Checked) sc++;
            if (checkBox16.Checked) sc++;

            label5.Text = $"Количество баллов: {sc}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
