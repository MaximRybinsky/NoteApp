using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var fileName = Environment.GetFolderPath
                (Environment.SpecialFolder.ApplicationData) + "\\NoteApp.notes";

            //var note1 = new Note();
            //note1.Name = "Product list";
            //note1.Text = "1 - onion, 2 - carrot, 3 - bread";
            //note1.Category = NoteCategory.Home;

            var project = new Project();
            ProjectManager.SaveToFile(project, fileName);
            Project loadProject = ProjectManager.LoadFromFile(fileName);
            if (loadProject == null)
            {
                MessageBox.Show("null");
            }
            else
            {
                MessageBox.Show("success");
            }
            
            //MessageBox.Show(loadNote.Name + ' ' + loadNote.Text + ' ' + loadNote.Category + ' '
            //                + loadNote.Created + ' ' + loadNote.Modified);
            InitializeComponent();
        }
    }
}
