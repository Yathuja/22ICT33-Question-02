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

            string studentName = txtStudentName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();
            DateTime borrowDate = dtpBorrowDate.Value;

            // Validate student name
            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the student's name.", "Validation Error");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(studentName, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Student name must contain only alphabetic characters.", "Validation Error");
                return;
            }

            // Validate book title
            if (string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Please enter the book title.", "Validation Error");
                return;
            }

            // Add record
            string record = studentName + " - " + bookTitle + " - " + borrowDate.ToString("dd/MM/yyyy");
            lstBorrowedBooks.Items.Add(record);

            // Optionally clear inputs
            txtStudentName.Clear();
            txtBookTitle.Clear();
            dtpBorrowDate.Value = DateTime.Today;
        }
    }
}
