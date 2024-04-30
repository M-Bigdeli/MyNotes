namespace MyNotes
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.navbar = new System.Windows.Forms.Panel();
            this.createNewButton = new System.Windows.Forms.PictureBox();
            this.selectedPaneLine = new System.Windows.Forms.PictureBox();
            this.openNotesPanel = new System.Windows.Forms.Button();
            this.openTodoPanel = new System.Windows.Forms.Button();
            this.selectedPaneLineMove = new System.Timers.Timer();
            this.todoPanel = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createNewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPaneLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPaneLineMove)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.navbar.Controls.Add(this.createNewButton);
            this.navbar.Controls.Add(this.selectedPaneLine);
            this.navbar.Controls.Add(this.openNotesPanel);
            this.navbar.Controls.Add(this.openTodoPanel);
            this.navbar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbar.Location = new System.Drawing.Point(10, 10);
            this.navbar.Margin = new System.Windows.Forms.Padding(0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(780, 60);
            this.navbar.TabIndex = 0;
            // 
            // createNewButton
            // 
            this.createNewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewButton.Image = global::MyNotes.Properties.Resources.plus_01;
            this.createNewButton.Location = new System.Drawing.Point(10, 10);
            this.createNewButton.Margin = new System.Windows.Forms.Padding(0);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(40, 40);
            this.createNewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.createNewButton.TabIndex = 3;
            this.createNewButton.TabStop = false;
            this.createNewButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.createNewButton_MouseDown);
            this.createNewButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.createNewButton_MouseUp);
            // 
            // selectedPaneLine
            // 
            this.selectedPaneLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedPaneLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.selectedPaneLine.ErrorImage = null;
            this.selectedPaneLine.InitialImage = null;
            this.selectedPaneLine.Location = new System.Drawing.Point(400, 56);
            this.selectedPaneLine.Name = "selectedPaneLine";
            this.selectedPaneLine.Size = new System.Drawing.Size(100, 4);
            this.selectedPaneLine.TabIndex = 2;
            this.selectedPaneLine.TabStop = false;
            // 
            // openNotesPanel
            // 
            this.openNotesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openNotesPanel.BackColor = System.Drawing.Color.Transparent;
            this.openNotesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openNotesPanel.FlatAppearance.BorderSize = 0;
            this.openNotesPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openNotesPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openNotesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNotesPanel.Location = new System.Drawing.Point(280, 0);
            this.openNotesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.openNotesPanel.Name = "openNotesPanel";
            this.openNotesPanel.Size = new System.Drawing.Size(100, 56);
            this.openNotesPanel.TabIndex = 1;
            this.openNotesPanel.TabStop = false;
            this.openNotesPanel.Text = "Notes";
            this.openNotesPanel.UseVisualStyleBackColor = false;
            this.openNotesPanel.Click += new System.EventHandler(this.openNotesPanel_Click);
            this.openNotesPanel.MouseEnter += new System.EventHandler(this.openPanel_MouseEnter);
            this.openNotesPanel.MouseLeave += new System.EventHandler(this.openPanel_MouseLeave);
            // 
            // openTodoPanel
            // 
            this.openTodoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openTodoPanel.BackColor = System.Drawing.Color.Transparent;
            this.openTodoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openTodoPanel.FlatAppearance.BorderSize = 0;
            this.openTodoPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openTodoPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openTodoPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTodoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.openTodoPanel.Location = new System.Drawing.Point(400, 0);
            this.openTodoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.openTodoPanel.Name = "openTodoPanel";
            this.openTodoPanel.Size = new System.Drawing.Size(100, 56);
            this.openTodoPanel.TabIndex = 0;
            this.openTodoPanel.TabStop = false;
            this.openTodoPanel.Text = "Todo";
            this.openTodoPanel.UseVisualStyleBackColor = false;
            this.openTodoPanel.Click += new System.EventHandler(this.openTodoPanel_Click);
            this.openTodoPanel.MouseEnter += new System.EventHandler(this.openPanel_MouseEnter);
            this.openTodoPanel.MouseLeave += new System.EventHandler(this.openPanel_MouseLeave);
            // 
            // selectedPaneLineMove
            // 
            this.selectedPaneLineMove.Interval = 1D;
            this.selectedPaneLineMove.SynchronizingObject = this;
            this.selectedPaneLineMove.Elapsed += new System.Timers.ElapsedEventHandler(this.selectedPaneLineMove_Elapsed);
            // 
            // todoPanel
            // 
            this.todoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.todoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.todoPanel.Location = new System.Drawing.Point(10, 90);
            this.todoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.todoPanel.Name = "todoPanel";
            this.todoPanel.Size = new System.Drawing.Size(780, 350);
            this.todoPanel.TabIndex = 1;
            // 
            // Index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.todoPanel);
            this.Controls.Add(this.navbar);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(558, 300);
            this.Name = "Index";
            this.Text = "My Notes";
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createNewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPaneLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPaneLineMove)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox createNewButton;

        private System.Windows.Forms.Panel todoPanel;

        private System.Timers.Timer selectedPaneLineMove;

        private System.Windows.Forms.PictureBox selectedPaneLine;

        private System.Windows.Forms.Button openNotesPanel;

        private System.Windows.Forms.Button openTodoPanel;

        private System.Windows.Forms.Panel navbar;

        #endregion
    }
}