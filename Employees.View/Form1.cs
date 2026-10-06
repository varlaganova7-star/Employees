using System;
using System.Windows.Forms;
using Employees.BusinessLogic;
using Employees.DataAccessLayer;
using Employees.Model;

namespace Employees.View
{
    public partial class Form1 : Form
    {
        // Вот здесь выбирается сценарий работы с БД:
        // new DapperRepository(...) — сценарий Dapper (твой)
        // new EFRepository()        — сценарий EF (Викин)
        private readonly EmployeeService _service =
            new EmployeeService(new DapperRepository(DbConfig.ConnectionString));

        public Form1()
        {
            InitializeComponent();
            RefreshList();
        }
        private void labelLastName_Click(object sender, EventArgs e)
        {
            // пустой обработчик, нужен только чтобы дизайнер не ругался
        }
        private void RefreshList()
        {
            try
            {
                dataGridViewEmployees.DataSource = null;
                dataGridViewEmployees.DataSource = _service.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списка: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string position = textBoxPosition.Text.Trim();

            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                _service.Add(new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Position = position
                });

                RefreshList();

                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxPosition.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["Id"].Value);
                _service.Remove(id);
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}