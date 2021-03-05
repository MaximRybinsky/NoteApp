
namespace NoteAppUI
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.NoteTitleLabel = new System.Windows.Forms.Label();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTitleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNoteButton.FlatAppearance.BorderSize = 0;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.Image = global::NoteAppUI.Properties.Resources.RemoveGuide_16x;
            this.DeleteNoteButton.Location = new System.Drawing.Point(64, 394);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(20, 20);
            this.DeleteNoteButton.TabIndex = 1;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = global::NoteAppUI.Properties.Resources.AddDocument_16x;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 394);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(20, 20);
            this.AddNoteButton.TabIndex = 0;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = global::NoteAppUI.Properties.Resources.EditDocument_16x;
            this.EditNoteButton.Location = new System.Drawing.Point(38, 394);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(20, 20);
            this.EditNoteButton.TabIndex = 0;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Location = new System.Drawing.Point(6, 27);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(257, 355);
            this.NoteListBox.TabIndex = 1;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 3);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(81, 13);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(90, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(173, 21);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Location = new System.Drawing.Point(54, 35);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(33, 13);
            this.NoteCategoryLabel.TabIndex = 6;
            this.NoteCategoryLabel.Text = "Other";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(154, 68);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 5;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(4, 68);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            // 
            // NoteTitleLabel
            // 
            this.NoteTitleLabel.AutoSize = true;
            this.NoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.NoteTitleLabel.Name = "NoteTitleLabel";
            this.NoteTitleLabel.Size = new System.Drawing.Size(100, 24);
            this.NoteTitleLabel.TabIndex = 3;
            this.NoteTitleLabel.Text = "Note Title";
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(210, 62);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.ModifiedDateTimePicker.TabIndex = 2;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(57, 62);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.CreatedDateTimePicker.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(3, 88);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(524, 335);
            this.TextBox.TabIndex = 0;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(4, 35);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label NoteTitleLabel;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label CategoryLabel;
    }
}

