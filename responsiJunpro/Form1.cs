using Npgsql;
using System.Data;

namespace responsiJunpro
{
    public partial class Form1 : Form
    {
        private readonly EmployeeManager _employeeManager;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsiJunpro";
            _employeeManager = new EmployeeManager(connString);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (_employeeManager.InsertEmployee(tbNama.Text, cbDep.Text, cbJabatan.Text))
                {
                    MessageBox.Show("Data berhasil diinput!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label6.Text);
                if (_employeeManager.UpdateEmployee(id, tbNama.Text, cbDep.Text, cbJabatan.Text))
                {
                    MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label6.Text);
                if (_employeeManager.DeleteEmployee(id))
                {
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvDataKaryawan.DataSource = _employeeManager.LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDataKaryawan.Rows[e.RowIndex];
                label6.Text = row.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = row.Cells["nama_karyawan"].Value.ToString();
                cbDep.Text = row.Cells["nama_departemen"].Value.ToString();
                cbJabatan.Text = row.Cells["nama_jabatan"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDep.Items.AddRange(new string[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbJabatan.Items.AddRange(new string[] { "Kepala Departemen", "Manager", "Staff", "Intern" });
        }
    }
}