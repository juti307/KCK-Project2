using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLibrary2
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Date { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Julita\\Desktop\\KCK\\project_2\\MiniLibrary2\\BooksDB.mdf;Integrated Security=True ");


        public void AddBook(string name, string author, string genre)
        {
            if (name.Length == 0) { return; }
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Julita\\Desktop\\KCK\\project_2\\MiniLibrary2\\BooksDB.mdf;Integrated Security=True "))
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into [Books]values(@name,@author,@genre,@date)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);

                int a = cmd.ExecuteNonQuery();
                if (a>0)
                {
                    MessageBox.Show("Book succesfully added!");
                }
            }
            return;
        }

        public void DeleteBook(int id)
        {
            if (MessageBox.Show("Are you sure to delete?","Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Julita\\Desktop\\KCK\\project_2\\MiniLibrary2\\BooksDB.mdf;Integrated Security=True "))
                {
                    SqlCommand com = new SqlCommand("Delete Books where BookId = '" + id + "' ", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    con.Close();
                }
            }
         }


        public void BookList(DataGridView dgv1)
        {
           con.Open();
        SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Books",con);
        DataTable dtbl = new DataTable();
        sqlDa.Fill(dtbl);

        dgv1.DataSource = dtbl;
        }
        public void FindByAuthor(DataGridView dgv1, string author)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Books where Author LIKE '%"+ author+"%' ", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgv1.DataSource = dtbl;
        }
        public void FindByTitle(DataGridView dgv1, string title)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Books where Name LIKE '%" + title + "%' ", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgv1.DataSource = dtbl;
        }
        public void FindByGenre(DataGridView dgv1, string genre)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Books where Genre LIKE '%" + genre + "%' ", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgv1.DataSource = dtbl;
        }

      
    }
}
