using System;
using System.Text;
using System.Windows.Forms;

namespace AddWords
{
    public partial class FrmMain : Form
    {
        //Main file handling class
        WriteTo writer;
        public FrmMain() => InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e) => writer = new WriteTo();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Will only write if the fields aren't blank
            if (!string.IsNullOrEmpty(txtWord.Text) && !string.IsNullOrEmpty(txtTranslation.Text))
                writer.WriteToFile(txtWord.Text, txtTranslation.Text);

            else
                MessageBox.Show("Cannot enter empty fields!");

            ClearFields();
        }

        //Clears all text fields
        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        //Overwrites the text file
        private void btnPurge_Click(object sender, EventArgs e) => writer.Purge();

        #region LetterButtons
        private void btnCh_Click(object sender, EventArgs e) => AddLetter("Č", true);
        private void btnLCh_Click(object sender, EventArgs e) => AddLetter("Č", false);

        private void btnTj_Click(object sender, EventArgs e) => AddLetter("Ć", true);
        private void btnLTj_Click(object sender, EventArgs e) => AddLetter("Ć", false);

        private void btnDz_Click(object sender, EventArgs e) => AddLetter("Dž", true);
        private void btnLDz_Click(object sender, EventArgs e) => AddLetter("Dž", false);

        private void btnDj_Click(object sender, EventArgs e) => AddLetter("Đ", true);
        private void btnLDj_Click(object sender, EventArgs e) => AddLetter("Đ", false);

        private void btnSh_Click(object sender, EventArgs e) => AddLetter("Š", true);
        private void btnLSh_Click(object sender, EventArgs e) => AddLetter("Š", false);

        private void btnZh_Click(object sender, EventArgs e) => AddLetter("Ž", true);
        private void btnLZh_Click(object sender, EventArgs e) => AddLetter("Ž", false);
        #endregion
        //Appends the chosen character to the input field
        private void AddLetter(string letter, bool upper) => txtWord.Text = writer.AddLetter(letter, txtWord.Text, upper);

        //Method for clearing all text fields, any added fields can be added here easily without changing the btnClear_Click event
        private void ClearFields()
        {
            txtWord.Clear();
            txtTranslation.Clear();
        }
    }
}
