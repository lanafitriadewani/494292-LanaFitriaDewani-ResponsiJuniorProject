using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiJunpro
{
    public class DatabaseManager
    {
        public readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public DataTable ExecuteQuery(string sql, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string sql, NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }

    // Inheritence
    public class EmployeeManager : DatabaseManager
    {
        public EmployeeManager(string connectionString) : base(connectionString) { }

        public bool InsertEmployee(string name, string department, string position)
        {
            string sql = @"SELECT * FROM st_insert(:_nama_karyawan, :_nama_dep, :_nama_jabatan)";
            var parameters = new[]
            {
                new NpgsqlParameter("_nama_karyawan", name),
                new NpgsqlParameter("_nama_dep", department),
                new NpgsqlParameter("_nama_jabatan", position)
            };
            return ExecuteNonQuery(sql, parameters) == 1;
        }

        public bool UpdateEmployee(int id, string name, string department, string position)
        {
            string sql = @"SELECT * FROM st_update(:_id_karyawan, :_nama_karyawan, :_nama_dep, :_nama_jabatan)";
            var parameters = new[]
            {
                new NpgsqlParameter("_id_karyawan", id),
                new NpgsqlParameter("_nama_karyawan", name),
                new NpgsqlParameter("_nama_dep", department),
                new NpgsqlParameter("_nama_jabatan", position)
            };
            return ExecuteNonQuery(sql, parameters) == 200;
        }

        public bool DeleteEmployee(int id)
        {
            string sql = @"SELECT * FROM st_delete(:_id_karyawan)";
            var parameters = new[]
            {
                new NpgsqlParameter("_id_karyawan", id)
            };
            return ExecuteNonQuery(sql, parameters) == 200;
        }

        public DataTable LoadEmployees()
        {
            string sql = @"SELECT * FROM st_load()";
            return ExecuteQuery(sql);
        }
    }
}
