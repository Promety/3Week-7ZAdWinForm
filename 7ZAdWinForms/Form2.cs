using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7ZAdWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str = Convert.ToString(textBox1.Text);
            char c = char.Parse(textBox2.Text);
            textBox3.Text += (Regex.Replace(str, $@"\w*{c}\w*", "", RegexOptions.IgnoreCase));
            if (!str.Contains(c))
            {
                textBox3.Text = null;
                MessageBox.Show ("В словах нет данного символа", "Error");
                return;
            }
            
        }

       // если потребуется посмотреть 1 форму перейдите в Program.cs
    }
}
