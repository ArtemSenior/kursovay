using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovay
{
    public partial class doctor_form : Form
    {
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"(local)",
                InitialCatalog = "Poliklinika", //Database
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = "Vladimirov_admin",
                Password = "adm123"            
            };
            return sqlString.ToString();
        }

        public doctor_form()
        {
            InitializeComponent();
        }
        public string connectionString;
        public void UpdateDataGrid()
        {
            using (Model1 db = new Model1(connectionString))
            {
                var doctors = db.med_card;
                dataGridView1.DataSource = doctors.ToList();

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[14].Visible= false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчетво";
                dataGridView1.Columns[4].HeaderText = "Дата рождения";
                dataGridView1.Columns[5].HeaderText = "Номер телефона";
                dataGridView1.Columns[6].HeaderText = "Серия паспорта";
                dataGridView1.Columns[7].HeaderText = "Номер паспорта";
                dataGridView1.Columns[8].HeaderText = "Снилс";
                dataGridView1.Columns[9].HeaderText = "Область";
                dataGridView1.Columns[10].HeaderText = "Город";
                dataGridView1.Columns[11].HeaderText = "Улица";
                dataGridView1.Columns[12].HeaderText = "Дом";
                dataGridView1.Columns[13].HeaderText = "Квартира";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var date = DateTime.Now.Date;
                var priemToday = db.istoria_priemov.Where(p => p.date_of_priem == date /*&& p.ID_doctor = id_doctor*/); 
                dataGridView2.DataSource = priemToday.ToList();
                var analize = db.list_tests;
                dataGridView3.DataSource = analize.ToList();
                dataGridView3.Columns[3].Visible = false;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void doctor_form_Load(object sender, EventArgs e)
        {
            connectionString = GetRemoteConnectionString("11", "12");

            UpdateDataGrid();
        }
    }
}
