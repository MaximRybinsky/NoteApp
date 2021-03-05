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

        private NoteApp.Project _project;

        public MainForm()
        {
            InitializeComponent();
            ShowIcon = false;
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Docs);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.People);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.SportAndHealth);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Work);

            _project = new Project();
            
            try
            {
                _project = NoteApp.ProjectManager.LoadFromFile(NoteApp.ProjectManager.defaultPath);

                for (int i = 0; i < _project.NotesList.Count; i++)
                {
                    NoteListBox.Items.Add(_project.NotesList[i].Title);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл");
            }
        }

        private void AddNote()
        {
            var _note = new Note();
            var editForm = new EditForm();
            editForm.Note = _note;
            editForm.ShowDialog();
            if(editForm.DialogResult == DialogResult.OK)
            {
                _note = editForm.Note;
                _project.NotesList.Add(_note);
                NoteListBox.Items.Add(_note.Title);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;

                NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.defaultPath);
            }
        }

        private void EditNote()
        {
            var selected = NoteListBox.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Выберите заметку для редактирования", "Сообщение",
                    MessageBoxButtons.OK);
                return;
            }
            else
            {
                var _note = _project.NotesList[selected];
                var editForm = new EditForm();
                editForm.Note = _note;
                editForm.ShowDialog(); 
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _note = editForm.Note;
                    _project.NotesList.RemoveAt(selected);
                    NoteListBox.Items.RemoveAt(selected);
                    _project.NotesList.Insert(selected, _note);
                    NoteListBox.Items.Insert(selected, _note.Title);
                    NoteListBox.SelectedIndex = selected;

                    NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.defaultPath);
                }
            }
        }

        private void RemoveNote()
        {
            var selected = NoteListBox.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Выберите заметку для удаления", "Сообщение",
                    MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _project.NotesList.RemoveAt(selected);
                    NoteListBox.Items.RemoveAt(selected);
                    NoteListBox.SelectedIndex = -1;

                    NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.defaultPath);
                }
            }
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = NoteListBox.SelectedIndex;
            if(selected == -1)
            {
                return;
            }
            TextBox.Text = _project.NotesList[selected].Text;
            NoteTitleLable.Text = _project.NotesList[selected].Title;
            NoteCategoryLable.Text = "Category: " + _project.NotesList[selected].Category.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
