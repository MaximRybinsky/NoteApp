using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Пользовательский интерфейс для выбора и чтения заметок
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр проекта для сериализации и десериализации
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Начальный конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            CategoryComboBox.Items.Add("All");
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            CategoryComboBox.Items.AddRange(categories);
            CategoryComboBox.SelectedItem = "All";

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);

            //Загружает поля в список заметок на экране
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                NoteListBox.Items.Add(_project.Notes[i].Title);
            }
            if(NoteListBox.Items.Count > 0)
            {
                NoteListBox.SelectedIndex = NoteListBox.TopIndex;
            }

            //Выберает последнюю просматреваемую заметку, если таковая существует в списке
            try
            {
                NoteListBox.SelectedIndex = _project.SelectedNoteIndex;
            }
            catch
            {
                NoteListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Обновляет отображение заметок на главной форме
        /// </summary>
        public void RefreshMainForm()
        {
            ;
        }

        /// <summary>
        /// Вызывает окно создания заметки
        /// </summary>
        private void AddNote()
        {
            var note = new Note();
            var editForm = new NoteForm();
            editForm.Note = note;
            editForm.ShowDialog();
            if(editForm.DialogResult == DialogResult.OK)
            {
                note = editForm.Note;
                _project.Notes.Add(note);
                NoteListBox.Items.Add(note.Title);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;

                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            }
        }

        /// <summary>
        /// Вызывает окно редактирования заметки
        /// </summary>
        private void EditNote()
        {
            var selected = NoteListBox.SelectedIndex;

            if (selected == -1)
            {
                return;
            }
            else
            {
                var note = _project.Notes[selected];
                var editForm = new NoteForm();
                editForm.Note = note;
                editForm.ShowDialog(); 
                if (editForm.DialogResult == DialogResult.OK)
                {
                    note = editForm.Note;
                    _project.Notes.RemoveAt(selected);
                    NoteListBox.Items.RemoveAt(selected);
                    _project.Notes.Insert(selected, note);
                    NoteListBox.Items.Insert(selected, note.Title);
                    NoteListBox.SelectedIndex = selected;

                    ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                }
            }
        }

        /// <summary>
        /// Удаляет заметку при подтверждении
        /// </summary>
        private void RemoveNote()
        {
            var selected = NoteListBox.SelectedIndex;

            if (selected == -1)
            {
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Delete note?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _project.Notes.RemoveAt(selected);
                    NoteListBox.Items.RemoveAt(selected);
                    NoteListBox.SelectedIndex = 0;

                    ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                _project.SortNotes(_project.Notes);
            }
            else
            {
                _project.SortNotes(_project.Notes, (NoteCategory)CategoryComboBox.SelectedItem);
            }
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = NoteListBox.SelectedIndex;
            if(selected == -1)
            {
                return;
            }

            TextBox.Text = _project.Notes[selected].Text;
            NoteTitleLabel.Text = _project.Notes[selected].Title;
            NoteCategoryLabel.Text = _project.Notes[selected].Category.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Delete")
            {
                RemoveNote();
            }
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _project.SelectedNoteIndex = NoteListBox.SelectedIndex;
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }
    }
}
