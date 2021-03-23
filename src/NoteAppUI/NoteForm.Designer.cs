
namespace NoteAppUI
{
    partial class NoteForm
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
            this.components = new System.ComponentModel.Container();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLlabel = new System.Windows.Forms.Label();
            this.TitleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(272, 377);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(353, 377);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(12, 91);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainTextBox.Size = new System.Drawing.Size(416, 280);
            this.MainTextBox.TabIndex = 5;
            this.MainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(59, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(369, 20);
            this.TitleTextBox.TabIndex = 3;
            this.TitleToolTip.SetToolTip(this.TitleTextBox, "Too many characters");
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(59, 65);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.CreatedDateTimePicker.TabIndex = 4;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(219, 65);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.ModifiedDateTimePicker.TabIndex = 5;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(59, 38);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(9, 41);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(48, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Categiry:";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(166, 68);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 9;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLlabel
            // 
            this.CreatedLlabel.AutoSize = true;
            this.CreatedLlabel.Location = new System.Drawing.Point(9, 68);
            this.CreatedLlabel.Name = "CreatedLlabel";
            this.CreatedLlabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLlabel.TabIndex = 10;
            this.CreatedLlabel.Text = "Created:";
            // 
            // TitleToolTip
            // 
            this.TitleToolTip.Active = false;
            this.TitleToolTip.ShowAlways = true;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 414);
            this.Controls.Add(this.CreatedLlabel);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.MinimumSize = new System.Drawing.Size(458, 453);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLlabel;
        private System.Windows.Forms.ToolTip TitleToolTip;
    }
}