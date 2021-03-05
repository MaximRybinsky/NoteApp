using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void EmaleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:maxim_2k@mail.ru");
                EmaleLinkLabel.LinkVisited = true;
            }
            catch
            {
                MessageBox.Show("Не удалось прейти по ссылке");
            }
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/MaximRybinsky/NoteApp");
                GitHubLinkLabel.LinkVisited = true;
            }
            catch
            {
                MessageBox.Show("Не удалось прейти по ссылке");
            }
        }
    }
}
