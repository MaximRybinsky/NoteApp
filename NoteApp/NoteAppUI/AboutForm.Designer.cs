
namespace NoteAppUI
{
    partial class AboutForm
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
            this.NoteAppLable = new System.Windows.Forms.Label();
            this.VersionLable = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmaleLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmaleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteAppLable
            // 
            this.NoteAppLable.AutoSize = true;
            this.NoteAppLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteAppLable.Location = new System.Drawing.Point(12, 9);
            this.NoteAppLable.Name = "NoteAppLable";
            this.NoteAppLable.Size = new System.Drawing.Size(92, 24);
            this.NoteAppLable.TabIndex = 0;
            this.NoteAppLable.Text = "NoteApp";
            // 
            // VersionLable
            // 
            this.VersionLable.AutoSize = true;
            this.VersionLable.Location = new System.Drawing.Point(13, 33);
            this.VersionLable.Name = "VersionLable";
            this.VersionLable.Size = new System.Drawing.Size(40, 13);
            this.VersionLable.TabIndex = 1;
            this.VersionLable.Text = "v 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(13, 64);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(120, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Maxim Rybinsky";
            // 
            // EmaleLabel
            // 
            this.EmaleLabel.AutoSize = true;
            this.EmaleLabel.Location = new System.Drawing.Point(13, 107);
            this.EmaleLabel.Name = "EmaleLabel";
            this.EmaleLabel.Size = new System.Drawing.Size(107, 13);
            this.EmaleLabel.TabIndex = 3;
            this.EmaleLabel.Text = "e-male for feedback: ";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(13, 130);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(46, 13);
            this.GitHubLabel.TabIndex = 4;
            this.GitHubLabel.Text = "GitHub: ";
            // 
            // EmaleLinkLabel
            // 
            this.EmaleLinkLabel.AutoSize = true;
            this.EmaleLinkLabel.Location = new System.Drawing.Point(126, 107);
            this.EmaleLinkLabel.Name = "EmaleLinkLabel";
            this.EmaleLinkLabel.Size = new System.Drawing.Size(95, 13);
            this.EmaleLinkLabel.TabIndex = 5;
            this.EmaleLinkLabel.TabStop = true;
            this.EmaleLinkLabel.Text = "maxim_2k@mail.ru";
            this.EmaleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmaleLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(65, 130);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(127, 13);
            this.GitHubLinkLabel.TabIndex = 6;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "MaximRybinsky/NoteApp";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "2020 Maxim Rybinsky";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmaleLinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmaleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLable);
            this.Controls.Add(this.NoteAppLable);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteAppLable;
        private System.Windows.Forms.Label VersionLable;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmaleLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel EmaleLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label label1;
    }
}