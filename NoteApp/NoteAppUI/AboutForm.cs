using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Содержит сведения о приложении
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Создаёт экземпляр формы <see cref="AboutForm">
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Failed to follow the link");
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
                MessageBox.Show("Failed to follow the link");
            }
        }
    }
}
