using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyNotes
{
    public partial class CreateTodo : Form
    {
        public CreateTodo()
        {
            InitializeComponent();
        }

        // Connect to access DB.
        private OleDbConnection connect_db =
            new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projecs\\MyNotes\\MyNotes\\DB.mdb;");

        private void ok_Click(object sender, EventArgs e)
        {
            connect_db.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Todo ( todo_text , is_done ) VALUES ('"+ textBox1.Text +"!' , 0);",
                connect_db);
            cmd.ExecuteNonQuery();
            connect_db.Close();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}