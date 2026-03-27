using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt15
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            private StudentGroup studentGroup;
            private ToolStripMenuItem студентToolStripMenuItem;
            private ToolStripMenuItem поискToolStripMenuItem;
            private ToolStripMenuItem сортировкаToolStripMenuItem;
            private ToolStripMenuItem данныеToolStripMenuItem;
            private ToolStripMenuItem справкаToolStripMenuItem;
            private MenuStrip menuStrip1;
            private Label label1;
            private TextBox textBox1;
            private Label label2;
            private TextBox textBox2;
            private Label label3;
            private MaskedTextBox maskedTextBox1;
            private Label label4;
            private DateTimePicker dateTimePicker1;
            private GroupBox groupBox1;
            private DataGridView dataGridView1;
            private Button button1;
            private Button button2;
            private Label label5;

            public Form1()
            {
                InitializeComponent();
                studentGroup = new StudentGroup();
                LoadSampleData();
                UpdateDataGridView();
            }

            private void InitializeComponent()
            {
                this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.label1 = new System.Windows.Forms.Label();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.label2 = new System.Windows.Forms.Label();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
                this.label4 = new System.Windows.Forms.Label();
                this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.button2 = new System.Windows.Forms.Button();
                this.button1 = new System.Windows.Forms.Button();
                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                this.label5 = new System.Windows.Forms.Label();
                this.groupBox1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                this.SuspendLayout();

             
                this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.студентToolStripMenuItem,
                this.поискToolStripMenuItem,
                this.сортировкаToolStripMenuItem,
                this.данныеToolStripMenuItem,
                this.справкаToolStripMenuItem});
                this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                this.menuStrip1.Name = "menuStrip1";
                this.menuStrip1.Size = new System.Drawing.Size(984, 24);
                this.menuStrip1.TabIndex = 0;
                this.menuStrip1.Text = "menuStrip1";

      
                this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
                this.студентToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
                this.студентToolStripMenuItem.Text = "Студент";
                this.студентToolStripMenuItem.Click += new System.EventHandler(this.СтудентToolStripMenuItem_Click);

                this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
                this.поискToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
                this.поискToolStripMenuItem.Text = "Поиск";
                this.поискToolStripMenuItem.Click += new System.EventHandler(this.ПоискToolStripMenuItem_Click);

             
                this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
                this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
                this.сортировкаToolStripMenuItem.Text = "Сортировка";
                this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.СортировкаToolStripMenuItem_Click);

             
                this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
                this.данныеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
                this.данныеToolStripMenuItem.Text = "Данные";
                this.данныеToolStripMenuItem.Click += new System.EventHandler(this.ДанныеToolStripMenuItem_Click);

          
                this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
                this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
                this.справкаToolStripMenuItem.Text = "Справка";
                this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);

         
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(12, 50);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(95, 13);
                this.label1.TabIndex = 1;
                this.label1.Text = "Введите фамилию:";

            
                this.textBox1.Location = new System.Drawing.Point(120, 47);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(150, 20);
                this.textBox1.TabIndex = 2;

             
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(12, 80);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(62, 13);
                this.label2.TabIndex = 3;
                this.label2.Text = "Введите имя:";

               
                this.textBox2.Location = new System.Drawing.Point(120, 77);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(150, 20);
                this.textBox2.TabIndex = 4;

                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(12, 110);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(108, 13);
                this.label3.TabIndex = 5;
                this.label3.Text = "Введите номер телефона:";

       
                this.maskedTextBox1.Location = new System.Drawing.Point(120, 107);
                this.maskedTextBox1.Mask = "+7 (999) 000-0000";
                this.maskedTextBox1.Name = "maskedTextBox1";
                this.maskedTextBox1.Size = new System.Drawing.Size(150, 20);
                this.maskedTextBox1.TabIndex = 6;

             
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(12, 140);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(97, 13);
                this.label4.TabIndex = 7;
                this.label4.Text = "Введите дату рождения:";

               
                this.dateTimePicker1.Location = new System.Drawing.Point(120, 137);
                this.dateTimePicker1.Name = "dateTimePicker1";
                this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
                this.dateTimePicker1.TabIndex = 8;

           
                this.groupBox1.Controls.Add(this.button2);
                this.groupBox1.Controls.Add(this.button1);
                this.groupBox1.Controls.Add(this.textBox1);
                this.groupBox1.Controls.Add(this.dateTimePicker1);
                this.groupBox1.Controls.Add(this.label1);
                this.groupBox1.Controls.Add(this.label4);
                this.groupBox1.Controls.Add(this.label2);
                this.groupBox1.Controls.Add(this.maskedTextBox1);
                this.groupBox1.Controls.Add(this.textBox2);
                this.groupBox1.Controls.Add(this.label3);
                this.groupBox1.Location = new System.Drawing.Point(12, 27);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(300, 200);
                this.groupBox1.TabIndex = 9;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "Данные студента";

            
                this.button2.Location = new System.Drawing.Point(195, 170);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(75, 23);
                this.button2.TabIndex = 10;
                this.button2.Text = "Удалить";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.Button2_Click);

                this.button1.Location = new System.Drawing.Point(120, 170);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 9;
                this.button1.Text = "Добавить";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.Button1_Click);

                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Location = new System.Drawing.Point(330, 50);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.Size = new System.Drawing.Size(642, 400);
                this.dataGridView1.TabIndex = 10;

                this.label5.AutoSize = true;
                this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label5.Location = new System.Drawing.Point(330, 27);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(154, 15);
                this.label5.TabIndex = 11;
                this.label5.Text = "Список студентов группы:";

                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(984, 461);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.dataGridView1);
                this.Controls.Add(this.groupBox1);
                this.Controls.Add(this.menuStrip1);
                this.MainMenuStrip = this.menuStrip1;
                this.Name = "Form1";
                this.Text = "Студенческая группа";
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private void LoadSampleData()
            {
                studentGroup.AddStudent(new Student("Иванов", "Иван", "+7 (999) 123-4567", new DateTime(2000, 5, 15)));
                studentGroup.AddStudent(new Student("Петров", "Петр", "+7 (999) 234-5678", new DateTime(2001, 8, 20)));
                studentGroup.AddStudent(new Student("Сидорова", "Анна", "+7 (999) 345-6789", new DateTime(2000, 3, 10)));
                studentGroup.AddStudent(new Student("Кузнецов", "Алексей", "+7 (999) 456-7890", new DateTime(2001, 11, 5)));
            }

            private void UpdateDataGridView()
            {
                var students = studentGroup.GetAllStudents();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students.Select(s => new
                {
                    Фамилия = s.LastName,
                    Имя = s.FirstName,
                    Телефон = s.PhoneNumber,
                    ДатаРождения = s.BirthDate.ToShortDateString()
                }).ToList();
                dataGridView1.AutoResizeColumns();
            }

            private void Button1_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Введите фамилию студента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Введите имя студента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!maskedTextBox1.MaskCompleted)
                {
                    MessageBox.Show("Введите номер телефона полностью!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Student newStudent = new Student(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    maskedTextBox1.Text,
                    dateTimePicker1.Value
                );

                studentGroup.AddStudent(newStudent);
                UpdateDataGridView();

                // Очистка полей
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                dateTimePicker1.Value = DateTime.Now;

                MessageBox.Show("Студент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void Button2_Click(object sender, EventArgs e)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    var students = studentGroup.GetAllStudents();
                    if (selectedIndex >= 0 && selectedIndex < students.Count)
                    {
                        studentGroup.RemoveStudent(students[selectedIndex]);
                        UpdateDataGridView();
                        MessageBox.Show("Студент успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите студента для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void СтудентToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Всего студентов в группе: " + studentGroup.Count, "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void ПоискToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SearchForm searchForm = new SearchForm(studentGroup);
                searchForm.ShowDialog();
                UpdateDataGridView();
            }

            private void СортировкаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SortForm sortForm = new SortForm(studentGroup);
                sortForm.ShowDialog();
                UpdateDataGridView();
            }

            private void ДанныеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (studentGroup.Count == 0)
                {
                    MessageBox.Show("Группа пуста!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string info = "Список всех студентов:\n\n";
                var students = studentGroup.GetAllStudents();
                for (int i = 0; i < students.Count; i++)
                {
                    info += $"{i + 1}. {students[i].LastName} {students[i].FirstName}\n";
                    info += $"   Телефон: {students[i].PhoneNumber}\n";
                    info += $"   Дата рождения: {students[i].BirthDate.ToShortDateString()}\n\n";
                }

                MessageBox.Show(info, "Данные группы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                string help = "Справка по программе \"Студенческая группа\"\n\n" +
                             "1. Добавление студента:\n" +
                             "   - Заполните все поля в группе \"Данные студента\"\n" +
                             "   - Нажмите кнопку \"Добавить\"\n\n" +
                             "2. Удаление студента:\n" +
                             "   - Выделите студента в таблице\n" +
                             "   - Нажмите кнопку \"Удалить\"\n\n" +
                             "3. Поиск:\n" +
                             "   - Выберите в меню \"Поиск\"\n" +
                             "   - Выберите критерий поиска\n\n" +
                             "4. Сортировка:\n" +
                             "   - Выберите в меню \"Сортировка\"\n" +
                             "   - Выберите поле для сортировки\n\n" +
                             "5. Просмотр данных:\n" +
                             "   - Выберите в меню \"Данные\" для просмотра списка\n" +
                             "   - Выберите в меню \"Студент\" для подсчета студентов";

                MessageBox.Show(help, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
