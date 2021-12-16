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
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void WievBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookList(ViewBooks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindowForm main = new MainWindowForm();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
