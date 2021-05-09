using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddLibrary_Click(object sender, EventArgs e)
        {
            string LibraryName = LibraryNameTextbox.Text;
            string LibraryLocation = LibraryLocationTextbox.Text;

        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            string AuthorFirstName = AuthorFirstNameBox.Text;
            string AuthorLastName = AuthorLastNameBox.Text;

        }

        private void AddGenre_Click(object sender, EventArgs e)
        {
            string Genre = GenreBox.Text;
        }
    }
}
