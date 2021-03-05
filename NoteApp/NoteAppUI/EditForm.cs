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
    /// <summary>
    /// Пользовательский интерфейс для создания и редактирования заметок
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary>
        /// Поле для временного хранения переданных данных
        /// </summary>
        private NoteApp.Note _note;
        /// <summary>
        /// Передаются данные извне
        /// </summary>
        public NoteApp.Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }

        public EditForm()
        {
            InitializeComponent();
            ShowIcon = false;
            
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Docs);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.People);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.SportAndHealth);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Work);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Title = TitleTextBox.Text;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.Category = (NoteApp.NoteCategory)CategoryComboBox.SelectedItem;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = MainTextBox.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = _note.Title;
            CategoryComboBox.SelectedItem = _note.Category;
            CreatedDateTimePicker.Value = _note.Created;
            ModifiedDateTimePicker.Value = _note.Modified;
            MainTextBox.Text = _note.Text;
        }
    }
}
