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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            show_todos();
        }

        private bool todo_panel_enabled = true;

        // Connect to access DB.
        private OleDbConnection connect_db =
            new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projecs\\MyNotes\\MyNotes\\DB.mdb;");

        // Get todo & notes data from DB.
        private OleDbDataReader get_data()
        {
            connect_db.Open();
            OleDbCommand select = new OleDbCommand();
            select.Connection = connect_db;
            select.CommandText = "Select * From Todo;";
            OleDbDataReader reader = select.ExecuteReader();
            return reader;
        }

        // Create checkbox for todos.
        private void show_todos()
        {
            OleDbDataReader data = get_data();

            foreach (CheckBox i in todoPanel.Controls.OfType<CheckBox>().ToList())
            {
                todoPanel.Controls.Remove(i);
            }

            CheckBox todo;
            int y = 15;
            while (data.Read())
            {
                todo = new CheckBox();
                todo.Name = "todo_" + data[0].ToString();
                todo.Text = data[2].ToString();
                todo.Top = y;
                y = y + 35 + 15;
                todo.Left = 15;
                todo.Width = 710;
                todo.Height = 35;
                
                todo.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                todo.BackColor = Color.FromArgb(152, 193, 217);
                todo.Cursor = Cursors.Hand;
                todo.Margin = new Padding(0);
                todo.TabStop = false;
                todo.UseVisualStyleBackColor = false;
                todoPanel.Controls.Add(todo);
            }
            connect_db.Close();
        }

        // openNotesPanel & openTodoPanel enter.
        private void openPanel_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(238, 108, 77);
        }

        // openNotesPanel & openTodoPanel leave.
        private void openPanel_MouseLeave(object sender, EventArgs e)
        {
            if (todo_panel_enabled)
            {
                openNotesPanel.ForeColor = Color.FromArgb(41, 50, 65);
            }
            else
            {
                openTodoPanel.ForeColor = Color.FromArgb(41, 50, 65);
            }
        }

        // openNotesPanel & openTodoPanel click. Select enable panel.
        private void openNotesPanel_Click(object sender, EventArgs e)
        {
            todo_panel_enabled = false;

            selectedPaneLineMove.Enabled = true;

            openTodoPanel.ForeColor = Color.FromArgb(41, 50, 65);
            openNotesPanel.ForeColor = Color.FromArgb(238, 108, 77);

            todoPanel.Visible = false;
            //notePanelRight.Visible = true;
            //notePanelLeft.Visible = true;
        }

        private void openTodoPanel_Click(object sender, EventArgs e)
        {
            todo_panel_enabled = true;

            selectedPaneLineMove.Enabled = true;

            openNotesPanel.ForeColor = Color.FromArgb(41, 50, 65);
            openTodoPanel.ForeColor = Color.FromArgb(238, 108, 77);

            todoPanel.Visible = true;
            //notePanelRight.Visible = false;
            //notePanelLeft.Visible = false;
        }

        // Moving selectedPaneLine with
        private void selectedPaneLineMove_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (todo_panel_enabled)
            {
                if (selectedPaneLine.Left >= openTodoPanel.Left)
                {
                    selectedPaneLineMove.Enabled = false;
                }
                else
                {
                    selectedPaneLine.Left += 5;
                }
            }
            else
            {
                if (selectedPaneLine.Left <= openNotesPanel.Left)
                {
                    selectedPaneLineMove.Enabled = false;
                }
                else
                {
                    selectedPaneLine.Left -= 5;
                }
            }
        }

        // Change color of new button. create new todo or note.
        private void createNewButton_MouseDown(object sender, MouseEventArgs e)
        {
            createNewButton.Image = MyNotes.Properties.Resources.plus_02;
        }

        private void createNewButton_MouseUp(object sender, MouseEventArgs e)
        {
            createNewButton.Image = MyNotes.Properties.Resources.plus_01;

            connect_db.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Todo ( todo_text , is_done ) VALUES ('dffhdf' , 1)",
                connect_db);
            cmd.ExecuteNonQuery();
            connect_db.Close();
            show_todos();
        }
    }
}