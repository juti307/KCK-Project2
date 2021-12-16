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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/usj6frFHDBgAAAAj/adventure-compass.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button2.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/4WOtLSx1cU4AAAAi/future-my-love.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/hbBYKJJwJKUAAAAj/gun-pointing.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/h9osFAUhNS0AAAAj/magic-harry-potter.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/akVxtlj4QE4AAAAi/docville-documentary-film-festival.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/rqLaujzJPmgAAAAj/your-choice-up-to-you.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, button7.Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://c.tenor.com/DPWImesUB6MAAAAi/gentleman-gentleman-parrot.gif");
            Book book = new Book();
            book.FindByGenre(viewBooks, text.Text);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
