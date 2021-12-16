
namespace MiniLibrary2.View
{
    partial class DeleteBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBookForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBooks = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.button1.Location = new System.Drawing.Point(664, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select item you want to delete:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewBooks
            // 
            this.ViewBooks.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.ViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBooks.Location = new System.Drawing.Point(65, 91);
            this.ViewBooks.Name = "ViewBooks";
            this.ViewBooks.RowHeadersWidth = 62;
            this.ViewBooks.RowTemplate.Height = 28;
            this.ViewBooks.Size = new System.Drawing.Size(824, 470);
            this.ViewBooks.TabIndex = 2;
            this.ViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewBooks_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 552);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(950, 677);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ViewBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DeleteBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBookForm";
            this.Load += new System.EventHandler(this.DeleteBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewBooks;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}