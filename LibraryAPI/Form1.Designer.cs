
namespace LibraryAPI
{
    partial class Form1
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
            this.AddLibrary = new System.Windows.Forms.Button();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.LibraryNameTextbox = new System.Windows.Forms.TextBox();
            this.AuthorFirstNameBox = new System.Windows.Forms.TextBox();
            this.AuthorLastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LibraryLocationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorFirstName = new System.Windows.Forms.Label();
            this.AuthorLastName = new System.Windows.Forms.Label();
            this.AddGenre = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddLibrary
            // 
            this.AddLibrary.Location = new System.Drawing.Point(12, 12);
            this.AddLibrary.Name = "AddLibrary";
            this.AddLibrary.Size = new System.Drawing.Size(100, 34);
            this.AddLibrary.TabIndex = 0;
            this.AddLibrary.Text = "AddLibrary";
            this.AddLibrary.UseVisualStyleBackColor = true;
            this.AddLibrary.Click += new System.EventHandler(this.AddLibrary_Click);
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(493, 116);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(149, 30);
            this.AddAuthor.TabIndex = 1;
            this.AddAuthor.Text = "Add Author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // LibraryNameTextbox
            // 
            this.LibraryNameTextbox.Location = new System.Drawing.Point(63, 63);
            this.LibraryNameTextbox.Name = "LibraryNameTextbox";
            this.LibraryNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.LibraryNameTextbox.TabIndex = 2;
            // 
            // AuthorFirstNameBox
            // 
            this.AuthorFirstNameBox.Location = new System.Drawing.Point(493, 152);
            this.AuthorFirstNameBox.Name = "AuthorFirstNameBox";
            this.AuthorFirstNameBox.Size = new System.Drawing.Size(149, 20);
            this.AuthorFirstNameBox.TabIndex = 3;
            // 
            // AuthorLastNameBox
            // 
            this.AuthorLastNameBox.Location = new System.Drawing.Point(493, 178);
            this.AuthorLastNameBox.Name = "AuthorLastNameBox";
            this.AuthorLastNameBox.Size = new System.Drawing.Size(149, 20);
            this.AuthorLastNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // LibraryLocationTextbox
            // 
            this.LibraryLocationTextbox.Location = new System.Drawing.Point(63, 100);
            this.LibraryLocationTextbox.Name = "LibraryLocationTextbox";
            this.LibraryLocationTextbox.Size = new System.Drawing.Size(100, 20);
            this.LibraryLocationTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // AuthorFirstName
            // 
            this.AuthorFirstName.AutoSize = true;
            this.AuthorFirstName.Location = new System.Drawing.Point(648, 155);
            this.AuthorFirstName.Name = "AuthorFirstName";
            this.AuthorFirstName.Size = new System.Drawing.Size(57, 13);
            this.AuthorFirstName.TabIndex = 8;
            this.AuthorFirstName.Text = "First Name";
            // 
            // AuthorLastName
            // 
            this.AuthorLastName.AutoSize = true;
            this.AuthorLastName.Location = new System.Drawing.Point(648, 184);
            this.AuthorLastName.Name = "AuthorLastName";
            this.AuthorLastName.Size = new System.Drawing.Size(58, 13);
            this.AuthorLastName.TabIndex = 9;
            this.AuthorLastName.Text = "Last Name";
            // 
            // AddGenre
            // 
            this.AddGenre.Location = new System.Drawing.Point(37, 235);
            this.AddGenre.Name = "AddGenre";
            this.AddGenre.Size = new System.Drawing.Size(75, 23);
            this.AddGenre.TabIndex = 10;
            this.AddGenre.Text = "Add Genre";
            this.AddGenre.UseVisualStyleBackColor = true;
            this.AddGenre.Click += new System.EventHandler(this.AddGenre_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(40, 264);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(72, 20);
            this.GenreBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.AddGenre);
            this.Controls.Add(this.AuthorLastName);
            this.Controls.Add(this.AuthorFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LibraryLocationTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorLastNameBox);
            this.Controls.Add(this.AuthorFirstNameBox);
            this.Controls.Add(this.LibraryNameTextbox);
            this.Controls.Add(this.AddAuthor);
            this.Controls.Add(this.AddLibrary);
            this.Name = "Form1";
            this.Text = "te";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLibrary;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.TextBox LibraryNameTextbox;
        private System.Windows.Forms.TextBox AuthorFirstNameBox;
        private System.Windows.Forms.TextBox AuthorLastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LibraryLocationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AuthorFirstName;
        private System.Windows.Forms.Label AuthorLastName;
        private System.Windows.Forms.Button AddGenre;
        private System.Windows.Forms.TextBox GenreBox;
    }
}

