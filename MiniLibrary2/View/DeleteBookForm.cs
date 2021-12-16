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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
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

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookList(ViewBooks);
        }

        private void ViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32( ViewBooks.Rows[e.RowIndex].Cells["BookId"].FormattedValue.ToString());
            Book book = new Book();
            book.DeleteBook(id);
            book.BookList(ViewBooks);
        }
    }
}
