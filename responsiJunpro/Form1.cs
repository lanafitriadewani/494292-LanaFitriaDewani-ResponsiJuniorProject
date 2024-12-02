using Npgsql;
using System.Data;

namespace responsiJunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsiJunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_insert(:_nama_karyawan, :_nama_dep, :_nama_jabatan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_nama_karyawan", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDep.Text);
                        cmd.Parameters.AddWithValue("_nama_jabatan", cbJabatan.Text);
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data berhasil diinput!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoad.PerformClick();
                            tbNama.Clear();
                            cbDep.SelectedIndex = -1;
                            cbJabatan.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_update(:_id_karyawan, :_nama_karyawan, :_nama_dep, :_nama_jabatan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label6.Text);
                        cmd.Parameters.AddWithValue("_nama_karyawan", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDep.Text);
                        cmd.Parameters.AddWithValue("_nama_jabatan", cbJabatan.Text);
                        if ((int)cmd.ExecuteScalar() == 200)
                        {
                            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoad.PerformClick();
                            tbNama.Clear();
                            cbDep.SelectedIndex = -1;
                            cbJabatan.SelectedIndex = -1;
                        }
                        else if ((int)cmd.ExecuteScalar() == 404)
                        {
                            MessageBox.Show("Data karyawan tidak ditemukan", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_delete(:_id_karyawan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label6.Text);
                        if ((int)cmd.ExecuteScalar() == 200)
                        {
                            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoad.PerformClick();
                            label6.Text = string.Empty;
                        }
                        else if ((int)cmd.ExecuteScalar() == 404)
                        {
                            MessageBox.Show("Data karyawan tidak ditemukan", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_load()";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        dt = new DataTable();
                        using (var rd = cmd.ExecuteReader())
                        {
                            dt.Load(rd);
                        }
                        dgvDataKaryawan.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                r = dgvDataKaryawan.Rows[e.RowIndex];
                label6.Text = r.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = r.Cells["nama_karyawan"].Value.ToString();
                cbDep.Text = r.Cells["nama_departemen"].Value.ToString();
                cbJabatan.Text = r.Cells["nama_jabatan"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDep.Items.Add("HR");
            cbDep.Items.Add("ENG");
            cbDep.Items.Add("DEV");
            cbDep.Items.Add("PM");
            cbDep.Items.Add("FIN");

            cbJabatan.Items.Add("Kepala Departemen");
            cbJabatan.Items.Add("Manager");
            cbJabatan.Items.Add("Staff");
            cbJabatan.Items.Add("Intern");
        }
    }
}