using System;
using System.Collections.Generic;
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
        /// Список отсортированных выводимых на экран заметок.
        /// Используется только при выводе на экран
        /// </summary>
        private List<Note> _viewedNotes = new List<Note>();

        /// <summary>
        /// Создаёт экземпляр формы <see cref="MainForm">
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            CategoryComboBox.Items.Add("All");
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            CategoryComboBox.Items.AddRange(categories);
            CategoryComboBox.SelectedItem = "All";

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            RefreshListBox();

            //Выберает последнюю просматреваемую заметку, если таковая существует в списке
            if (NoteListBox.Items.Count > 0)
            {
                NoteListBox.SelectedIndex = _project.SelectedNoteIndex;
            }
        }

        /// <summary>
        /// Обновляет список заметок, отображаемых на главной форме
        /// </summary>
        public void RefreshListBox()
        {
            //Производит сортировку в соответствии с выбранной категорией
            if (CategoryComboBox.SelectedItem == (object)"All")
            {
                _project.Notes = _project.SortNotes(_project.Notes);
                _viewedNotes = _project.Notes.ToList();
            }
            else
            {
                _viewedNotes = _project.SortNotes(_project.Notes, (NoteCategory)CategoryComboBox.SelectedItem);
            }

            //Загружает поля в список заметок на экране
            NoteListBox.Items.Clear();
            foreach (Note note in _viewedNotes)
            {
                NoteListBox.Items.Add(note.Title);
            }

            if (NoteListBox.Items.Count > 0)
            {
                NoteListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обновляет отображение правой панели главной формы.
        /// Выводит название, текст, категорию и даты выбранной заметки
        /// </summary>
        public void RefreshRightPanel()
        {
            var selected = NoteListBox.SelectedIndex;
            if (selected == -1)
            {
                TextBox.Text = "";
                NoteTitleLabel.Text = "Title";
                NoteCategoryLabel.Text = "none";
                CreatedDateTimePicker.Value = DateTime.Now;
                ModifiedDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                var currentNote = _viewedNotes[selected];
                TextBox.Text = currentNote.Text;
                NoteTitleLabel.Text = currentNote.Title;
                NoteCategoryLabel.Text = currentNote.Category.ToString();
                CreatedDateTimePicker.Value = currentNote.Created;
                ModifiedDateTimePicker.Value = currentNote.Modified;
            }
        }

        /// <summary>
        /// Вызывает окно создания заметки
        /// </summary>
        private void AddNote()
        {
            var note = new Note();
            var noteForm = new NoteForm();
            noteForm.Note = note;
            noteForm.ShowDialog();
            if(noteForm.DialogResult == DialogResult.OK)
            {
                note = noteForm.Note;

                //Добавляет заметку в реальный список
                _project.Notes.Insert(0, note);
                //Добавляет заметку в ListBox
                NoteListBox.Items.Insert(0, note.Title);
                //Добавляет заметку в отображаемый список
                _viewedNotes.Insert(0, note);

                NoteListBox.SelectedIndex = 0;

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
                var note = _viewedNotes[selected];
                var editForm = new NoteForm();
                editForm.Note = note;
                editForm.ShowDialog(); 
                if (editForm.DialogResult == DialogResult.OK)
                {
                    note = editForm.Note;

                    //Заменяет заметку в реальном списке
                    var realIndex = _project.Notes.IndexOf(_viewedNotes[selected]);
                    _project.Notes.RemoveAt(realIndex);
                    _project.Notes.Insert(0, note);
                    //Заменяет заметку в отображаемом списке
                    _viewedNotes.RemoveAt(selected);
                    _viewedNotes.Insert(0, note);
                    //Заменяет заметку в ListBox
                    NoteListBox.Items.RemoveAt(selected);
                    NoteListBox.Items.Insert(0, note.Title);

                    NoteListBox.SelectedIndex = 0;

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
                    //Удаляет заметку в реальном списке
                    var realIndex = _project.Notes.IndexOf(_viewedNotes[selected]);
                    _project.Notes.RemoveAt(realIndex);
                    //Удаляет заметку в отображаемом  списке
                    _viewedNotes.RemoveAt(selected);
                    //Удаляет заметку в ListBox
                    NoteListBox.Items.RemoveAt(selected);

                    if (NoteListBox.Items.Count > 0)
                    {
                        NoteListBox.SelectedIndex = 0;
                    }

                    ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBox();
            RefreshRightPanel();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshRightPanel();
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
