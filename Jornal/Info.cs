using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jornal
{
    public partial class Info : Form
    {
        Person pers;

        public Info(Person person)
        {
            InitializeComponent();

            textBox1.Text = person.Name;
            textBox2.Text = person.Surname;
            textBox3.Text = person.Mail;
            dateTimePicker1.Value = person.Birthday;

            pers = person;
        }

        private void Correctbt_Click(object sender, EventArgs e)
        {
            pers.Name = textBox1.Text;
            pers.Surname = textBox2.Text;
            pers.Mail = textBox3.Text;
            pers.Birthday = dateTimePicker1.Value;

            Close();
        }

        private void Cancelbt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
