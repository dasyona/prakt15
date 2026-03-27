using Microsoft.VisualBasic;
using prakt15;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prakt15
{
    public partial class Form1 : Form
    {
        private StudentGroup group = new StudentGroup();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ShowSearchResult(System.Collections.Generic.List<Student> result, string title)
        {
            if (result.Count == 0)
            {
                MessageBox.Show("Студенты не найдены.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = string.Join(Environment.NewLine, result.Select(s => s.ToString()));
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            var students = group.GetAllStudents();
            if (students.Any())
            {
                DataTable table = new DataTable();
                table.Columns.Add("Фамилия");
                table.Columns.Add("Имя");
                table.Columns.Add("Телефон");
                table.Columns.Add("Дата рождения");

                foreach (var s in students)
                {
                    DataRow row = table.NewRow();
                    row["Фамилия"] = s.LastName;
                    row["Имя"] = s.FirstName;
                    row["Телефон"] = s.Phone;
                    row["Дата рождения"] = s.BirthDate.ToShortDateString();
                    table.Rows.Add(row);
                }

                dataGridView1.DataSource = table;
            }
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text.Trim();
            string firstName = textBox2.Text.Trim();
            string phone = maskedTextBox1.Text.Trim();
            DateTime birthDate = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Фамилия и имя обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student newStudent = new Student(lastName, firstName, phone, birthDate);
            group.AddStudent(newStudent);

            // Обновляем DataGridView
            RefreshDataGridView();

            // Очистить поля
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text.Trim(); // используем существующее поле для фамилии
            if (!string.IsNullOrEmpty(lastName))
            {
                var result = group.FindByLastName(lastName);
                ShowSearchResult(result, $"Результаты поиска по фамилии \"{lastName}\":");
            }
            else
            {
                MessageBox.Show("Введите фамилию в поле 'Введите фамилию'", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Удалить выбранного студента
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                if (group.RemoveAt(index))
                {
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить студента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int i = 0;
        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                var sorted = group.SortByLastName();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = sorted.Select(s => new
                {
                    s.LastName,
                    s.FirstName,
                    s.Phone,
                    BirthDate = s.BirthDate.ToShortDateString()
                }).ToList();
                MessageBox.Show("Сортировка по фамилии", "Сортировка", MessageBoxButtons.OK);
                i++;
            }
            else if (i == 1)
            {
                var sorted = group.SortByBirthDate();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = sorted.Select(s => new
                {
                    s.LastName,
                    s.FirstName,
                    s.Phone,
                    BirthDate = s.BirthDate.ToShortDateString()
                }).ToList();
                MessageBox.Show("Сортировка по дате рождения", "Сортировка", MessageBoxButtons.OK);
                i++;
            }
            else if (i == 2)
            {
                MessageBox.Show("Сортировка отключена", "Сортировка", MessageBoxButtons.OK);
                RefreshDataGridView();
                i = 0;
            }
        }
    }
}