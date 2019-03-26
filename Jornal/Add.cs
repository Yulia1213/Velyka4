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
    public partial class Add : Form
    {
        Book newBook;
        public Add()
        {
            InitializeComponent();
        }

        public Add(Book book)
        {
            InitializeComponent();
            newBook = book;
        }


        private void Addbt_Click(object sender, EventArgs e)
        {
            Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value);
            newBook.AddClient(person);

            Close();
        }

        private void Cancelbt_Click(object sender, EventArgs e)
        {
            Close();
        }

        //internal Book GetPerson()
        //{
        //    return newBook;
        //}
    }
}
