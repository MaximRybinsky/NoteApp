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
            Note note1 = new Note();
            //note1.Name = "Product list";
            note1.Text = "1 - onion, 2 - carrot, 3 - bread";
            note1.Category = CategoryOfNote.Home;
            MessageBox.Show(note1.Name + ' ' + note1.Text + ' ' + note1.Category + ' '
                + note1.TimeOfCreation + ' ' + note1.TimeOfLastChange); 
            InitializeComponent();
        }
    }
}
