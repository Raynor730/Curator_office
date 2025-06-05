using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using сurator_office.AddForm;
using сurator_office.Models;
using AppContext = сurator_office.Models.AppContext;

namespace сurator_office.TableForm
{
    public partial class FormTableDisciplines : Form
    {
        private AppContext db;
        public FormTableDisciplines()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Disciplines.Load();
            this.dataGridViewDisciplines.DataSource = this.db.Disciplines.Local.OrderBy(o => o.DisciplineName).ToList();

            //скрытие столбцов
            dataGridViewDisciplines.Columns["Id"].Visible = false;
            dataGridViewDisciplines.Columns["DisciplinesTeachers"].Visible = false;

            //Изменение название заголовков столбцов
            dataGridViewDisciplines.Columns["Kode"].HeaderText = "Код дисциплины";
            dataGridViewDisciplines.Columns["DisciplineName"].HeaderText = "Название дисциплины";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddDiscipline formAddDiscipline = new();
            DialogResult result = formAddDiscipline.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Discipline discipline = new();
            discipline.Kode = formAddDiscipline.textBoxKode.Text;
            discipline.DisciplineName = formAddDiscipline.textBoxDisciplineName.Text;

            db.Disciplines.Add(discipline);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewDisciplines.DataSource = this.db.Disciplines.Local.OrderBy(o => o.DisciplineName).ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisciplines.SelectedRows.Count == 0)
            {
                return;
            }
            int index = dataGridViewDisciplines.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewDisciplines[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Discipline discipline = db.Disciplines.Find(id);
            FormAddDiscipline formAddDiscipline = new FormAddDiscipline();
            
            formAddDiscipline.textBoxKode.Text = discipline.Kode;
            formAddDiscipline.textBoxDisciplineName.Text = discipline.DisciplineName;
            
            
            DialogResult result = formAddDiscipline.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            discipline.Kode = formAddDiscipline.textBoxKode.Text;
            discipline.DisciplineName = formAddDiscipline.textBoxDisciplineName.Text;
            

            db.Disciplines.Update(discipline);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewDisciplines.DataSource = this.db.Disciplines.Local.OrderBy(o => o.DisciplineName).ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisciplines.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                return;
            }

            int index = dataGridViewDisciplines.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewDisciplines[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Discipline discipline = db.Disciplines.Find(id);

            db.Disciplines.Remove(discipline);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewDisciplines.DataSource = this.db.Disciplines.Local.OrderBy(o => o.DisciplineName).ToList();
        }
    }
}
