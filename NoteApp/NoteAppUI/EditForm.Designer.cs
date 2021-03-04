
namespace NoteAppUI
{
    partial class EditForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ModifiedLable = new System.Windows.Forms.Label();
            this.CreatedLlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(272, 377);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(353, 377);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 280);
            this.textBox1.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(59, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(59, 65);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.CreatedDateTimePicker.TabIndex = 4;
            // 
            // ModifiedDateTimePicker
            // 
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
            this.CategoryComboBox.TabIndex = 6;
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
            // ModifiedLable
            // 
            this.ModifiedLable.AutoSize = true;
            this.ModifiedLable.Location = new System.Drawing.Point(166, 71);
            this.ModifiedLable.Name = "ModifiedLable";
            this.ModifiedLable.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLable.TabIndex = 9;
            this.ModifiedLable.Text = "Modified:";
            // 
            // CreatedLlabel
            // 
            this.CreatedLlabel.AutoSize = true;
            this.CreatedLlabel.Location = new System.Drawing.Point(9, 71);
            this.CreatedLlabel.Name = "CreatedLlabel";
            this.CreatedLlabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLlabel.TabIndex = 10;
            this.CreatedLlabel.Text = "Created:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 414);
            this.Controls.Add(this.CreatedLlabel);
            this.Controls.Add(this.ModifiedLable);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ModifiedLable;
        private System.Windows.Forms.Label CreatedLlabel;
    }
}