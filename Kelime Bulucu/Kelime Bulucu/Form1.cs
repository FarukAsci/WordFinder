using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kelime_Bulucu
{
    public partial class Form1 : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        string lastQuery;
        string abc = "abcçdefgğhıijklmnoöprsştuüvyz";

        public Form1()
        {
            InitializeComponent();
        }

        public string sqlForLetters(string word, string beginning, string include, string ending, string maxLetter, string minLetter)
        {
            string sqlQuery = "Select * From Kelimeler where ";

            foreach (char l in word)
            {
                sqlQuery = sqlQuery + "kelime like '%" + l + "%' and ";
            }


            if (maxLetter.Length != 0)
            {
                sqlQuery += "length(kelime) <= " + maxLetter;
                sqlQuery += " and length(kelime) >= " + minLetter;
            }
            else
            {
                int lenght = sqlQuery.Length;
                sqlQuery = sqlQuery.Substring(0, lenght - 5);
            }

            if (beginning.Length > 0)
            {
                sqlQuery += " and kelime like '" + beginning + "%'";
            }

            if (include.Length > 0)
            {
                sqlQuery += " and kelime like '%" + include + "%'";
            }

            if (ending.Length > 0)
            {
                sqlQuery += " and kelime like '%" + ending + "'";
            }

            return sqlQuery;
        }

        public string sqlForSomeLetters(string word, string beginning, string include, string ending, string maxLetter, string minLetter)
        {
            string sqlQuery = "Select * From Kelimeler where ";
            bool isInWord = false;

            foreach (char a in abc)
            {
                foreach (char l in word)
                {
                    if (a.Equals(l))
                    {
                        isInWord = true;
                    }
                }
                if (isInWord)
                {
                    isInWord = false;
                }
                else
                {
                    sqlQuery = sqlQuery + "kelime not like '%" + a + "%' and ";
                }
            }
            
            if (maxLetter.Length != 0)
            {
                sqlQuery += "length(kelime) <= " + maxLetter;
                sqlQuery += " and length(kelime) >= " + minLetter;
            }
            else
            {
                int lenght = sqlQuery.Length;
                sqlQuery = sqlQuery.Substring(0, lenght - 5);
            }

            if (beginning.Length > 0)
            {
                sqlQuery += " and kelime like '" + beginning + "%'";
            }

            if (include.Length > 0)
            {
                sqlQuery += " and kelime like '%" + include + "%'";
            }

            if (ending.Length > 0)
            {
                sqlQuery += " and kelime like '%" + ending + "'";
            }

            return sqlQuery;
        }

        private void UpdateDB()
        {
            con = new SQLiteConnection("Data Source=.\\Kelimeler.db;Version=3;");
            da = new SQLiteDataAdapter(lastQuery, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kelimeler");
            dgvKelime.DataSource = ds.Tables["Kelimeler"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=.\\Kelimeler.db;Version=3;");
            da = new SQLiteDataAdapter("Select * From Kelimeler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kelimeler");
            dgvKelime.DataSource = ds.Tables["Kelimeler"];
            con.Close();
            lastQuery = "Select * From Kelimeler";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranacak = txtAra.Text.ToString();
            string maxLetter = tbxNumber.Text.ToString();
            string minLetter = tbxMinLetter.Text.ToString();
            string beginning = tbxBegin.Text.ToString();
            string include = tbxInclude.Text.ToString();
            string ending = tbxEnd.Text.ToString();
            string sqlQuery = sqlForLetters(aranacak, beginning, include, ending, maxLetter, minLetter);

            da = new SQLiteDataAdapter(sqlQuery, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kelimeler");
            dgvKelime.DataSource = ds.Tables["Kelimeler"];
            con.Close();

            lastQuery = sqlQuery;
        }

        private void tbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int rowindex = dgvKelime.CurrentCell.RowIndex;

            string word = dgvKelime.Rows[rowindex].Cells[1].Value.ToString();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Kelimeler where Kelime='" + word + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            UpdateDB();
        }

        private void btnSearchLetters_Click(object sender, EventArgs e)
        {
            string aranacak = txtAra.Text.ToString();
            string maxLetter = tbxNumber.Text.ToString();
            string minLetter = tbxMinLetter.Text.ToString();
            string beginning = tbxBegin.Text.ToString();
            string include = tbxInclude.Text.ToString();
            string ending = tbxEnd.Text.ToString();
            string sqlQuery = sqlForSomeLetters(aranacak, beginning, include, ending, maxLetter, minLetter);

            da = new SQLiteDataAdapter(sqlQuery, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kelimeler");
            dgvKelime.DataSource = ds.Tables["Kelimeler"];
            con.Close();

            lastQuery = sqlQuery;
        }

    }
}
