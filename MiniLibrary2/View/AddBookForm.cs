using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLibrary2.View
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton(object sender, EventArgs e)
        {
            this.Hide();
            MainWindowForm main = new MainWindowForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.AddBook(textBoxTitle.Text, textBoxAuthor.Text, textBoxGenre.Text);
        }
    }
}
