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

namespace MyNotes
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private bool todo_panel_enabled = true;

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
            notePanelRight.Visible = true;
            notePanelLeft.Visible = true;
        }

        private void openTodoPanel_Click(object sender, EventArgs e)
        {
            todo_panel_enabled = true;

            selectedPaneLineMove.Enabled = true;

            openNotesPanel.ForeColor = Color.FromArgb(41, 50, 65);
            openTodoPanel.ForeColor = Color.FromArgb(238, 108, 77);

            todoPanel.Visible = true;
            notePanelRight.Visible = false;
            notePanelLeft.Visible = false;
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
    }
}