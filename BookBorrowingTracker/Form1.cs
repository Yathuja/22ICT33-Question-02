using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string bookTitle = txtBookTitle.Text;
            DateTime borrowDate = dtpBorrowDate.Value;

            string record = studentName + " - " + bookTitle + " - " + borrowDate.ToString("dd/MM/yyyy");
            lstBorrowedBooks.Items.Add(record);

            // Clear fields after adding
            txtStudentName.Clear();
            txtBookTitle.Clear();
            dtpBorrowDate.Value = DateTime.Today;
        }
    }
}
