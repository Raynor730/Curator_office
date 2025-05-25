using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using сurator_office.Models;
using AppContext = сurator_office.Models.AppContext;

namespace сurator_office
{
    public partial class FormTableStudents : Form
    {
        private AppContext db;
        public FormTableStudents()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Students.Load();
            this.dataGridViewStudents.DataSource = this.db.Students.Local.OrderBy(o => o.Surname).ToList();

            //скрытие столбцов
            dataGridViewStudents.Columns["Id"].Visible = false;
            dataGridViewStudents.Columns["CurrentStatementsStudents"].Visible = false;
            dataGridViewStudents.Columns["IdGroupNavigation"].Visible = false;
            dataGridViewStudents.Columns["IdRoleNavigation"].Visible = false;
            dataGridViewStudents.Columns["IntermediateAttestationStudetns"].Visible = false;

            //Изменение название заголовков столбцов
            dataGridViewStudents.Columns["Surname"].HeaderText = "Фалимия";
            dataGridViewStudents.Columns["Name"].HeaderText = "Имя";
            dataGridViewStudents.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridViewStudents.Columns["Birthday"].HeaderText = "День рождения";
            dataGridViewStudents.Columns["Email"].HeaderText = "Электронная почта";
            dataGridViewStudents.Columns["ActualAddress"].HeaderText = "Фактический адрес проживания";
            dataGridViewStudents.Columns["Subgroup"].HeaderText = "Подгруппа";
            dataGridViewStudents.Columns["IdGroup"].HeaderText = "Группа";
            dataGridViewStudents.Columns["IdRole"].HeaderText = "Роль в группе";
            dataGridViewStudents.Columns["PhoneNumber"].HeaderText = "Номер телефона";
            dataGridViewStudents.Columns["FullAge"].HeaderText = "Совершеннолетний";
            dataGridViewStudents.Columns["Excluded"].HeaderText = "Отчислен";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new();
            DialogResult result = formAddStudent.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Student student = new Student();
            student.Surname = formAddStudent.textBoxSurname.Text;
            student.Name = formAddStudent.textBoxName.Text;
            student.Patronymic = formAddStudent.textBoxPatronymic.Text;


        }
    }
}
