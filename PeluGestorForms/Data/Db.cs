using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace PeluGestor.Data
{
    public static class Db
    {
        public const string ConexionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PeluGestorBD;Integrated Security=True;TrustServerCertificate=True;";

        public static DataTable Consulta(string sql, params SqlParameter[] parameters)
        {
            try
            {
                var con = new SqlConnection(ConexionString);
                var cmd = new SqlCommand(sql, con);

                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();

                con.Open();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al realizar la consulta a la base de datos.\n\n" + ex.Message,
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return new DataTable();
            }
        }

        public static int EjecutarCRUD(string sql, params SqlParameter[] parameters)
        {
            try
            {
                var con = new SqlConnection(ConexionString);
                var cmd = new SqlCommand(sql, con);

                if (parameters != null && parameters.Length > 0)
                {
                    foreach (var p in parameters)
                    {
                        if (p.Value == null)
                            p.Value = DBNull.Value;
                    }
                    cmd.Parameters.AddRange(parameters);
                }

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al ejecutar la operacion en la base de datos.\n\n" + ex.Message,
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return -1;
            }
        }
    }
}
