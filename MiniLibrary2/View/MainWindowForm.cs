 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiniLibrary2.View;

namespace MiniLibrary2
{
    public partial class MainWindowForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Julita\\Desktop\\KCK\\project_2\\MiniLibrary2\\BooksDB.mdf;Integrated Security=True ");
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Books",con);
            //DataTable dtbl = new DataTable();
            //sqlDa.Fill(dtbl);

            //dgv1.DataSource = dtbl;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titleButton(object sender, EventArgs e)
        {
            this.Hide();
            YourBookland titleList = new YourBookland();
            titleList.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewListButton(object sender, EventArgs e)
        {
            this.Hide();
            BookListForm bookList = new BookListForm();
            bookList.Show();
        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void addButton(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addNew = new AddBookForm();
            addNew.Show();
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBookForm deleteBook = new DeleteBookForm();
            deleteBook.Show();
        }

        private void genreButton(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm genreList = new CategoryForm();
            genreList.Show();
        }

        private void authorButton(object sender, EventArgs e)
        {
            this.Hide();
            AuthorForm authorList = new AuthorForm();
            authorList.Show();
        }
    }
}
