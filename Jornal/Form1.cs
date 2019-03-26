using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jornal
{
    public partial class Form1 : Form
    {
        public Book book;

        public Form1()
        {
            InitializeComponent();
            book = new Book();
            DesirializeBook();
            ShowAllClients();
        }

        private void DesirializeBook()
        {
            if (File.Exists("People.txt"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("People.txt", FileMode.OpenOrCreate))
                {
                    if (fs.Length != 0)
                        book = (Book)formatter.Deserialize(fs);
                }
            }
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(book);
            addForm.ShowDialog();
            //book = addForm.GetPerson();
            ShowAllClients();
        }

        private void Infobt_Click(object sender, EventArgs e)
        {
            

            Info infoForm = new Info(book.AllPeople[dataGridView1.CurrentCell.RowIndex]);
            infoForm.ShowDialog();

            ShowAllClients();
        }

        public void ShowAllClients()
        {
            dataGridView1.Rows.Clear();
            int i = 0; 
            foreach (Person per in book.AllPeople)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = per.Name;
                dataGridView1.Rows[i++].Cells[1].Value = per.Surname;
                dataGridView1.Rows[i - 1].Cells[2].Value = per.Mail;
                dataGridView1.Rows[i - 1].Cells[3].Value = per.Birthday;
                dataGridView1.Rows[i - 1].Cells[4].Value = per.IsAdult;
                dataGridView1.Rows[i - 1].Cells[5].Value = per.IsBirthday;
                dataGridView1.Rows[i - 1].Cells[6].Value = per.ChineseSign;
                dataGridView1.Rows[i - 1].Cells[7].Value = per.SunSign;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("People.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, book);
            }
            Close();
        }

        private void Removebt_Click(object sender, EventArgs e)
        {
            book.AllPeople.Remove(book.AllPeople[dataGridView1.CurrentCell.RowIndex]);

            ShowAllClients();
        }
    }
}
