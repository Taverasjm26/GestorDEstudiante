using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace GestorDeEstudiantes
{
    public partial class Main : Form

    {
        private string connectionString =
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\taver\Documents\EscuelaDb.mdf;Integrated Security=True;Connect Timeout=30"; private List<Estudiante> estudiantes = new List<Estudiante>();
        public Main()
        {
            InitializeComponent();
            LlenarComboPromedio();
            CargarEstudiantes();
        }

        private void LlenarComboPromedio()
        {
            comboPromedio.Items.Clear();
            comboPromedio.Items.Add("Malo");
            comboPromedio.Items.Add("Normal");
            comboPromedio.Items.Add("Bueno");
            comboPromedio.Items.Add("Excelente");
            comboPromedio.SelectedIndex = -1;
        }

        private void CargarEstudiantes()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Nombre, Email, Promedio FROM Estudiantes";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvEstudiantes.DataSource = dt;
            }

            DgvEstudiantes.AutoGenerateColumns = true;
            DgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEstudiantes.ReadOnly = true;
            DgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEstudiantes.MultiSelect = false;
            DgvEstudiantes.ClearSelection();
        }

        private void LimpiarCampos()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            comboPromedio.SelectedIndex = -1;
            DgvEstudiantes.ClearSelection();
        }

        // ====== BOTÓN AGREGAR ======
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string sql = "INSERT INTO Estudiantes (Nombre, Email, Promedio) " +
                             "VALUES (@Nombre, @Email, @Promedio)";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Promedio", comboPromedio.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEstudiantes();
            LimpiarCampos();
        }

        // ====== BOTÓN ACTUALIZAR ======
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Selecciona primero un estudiante de la tabla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string sql = @"UPDATE Estudiantes
                               SET Nombre = @Nombre,
                                   Email = @Email,
                                   Promedio = @Promedio
                               WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Promedio", comboPromedio.Text);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas == 0)
                    {
                        MessageBox.Show("No se encontró un estudiante con ese Id en la base de datos.");
                    }
                }
            }

            CargarEstudiantes();
        }

        // ====== BOTÓN ELIMINAR ======
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Selecciona primero un estudiante de la tabla.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar este estudiante?",
                                          "Confirmar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string sql = "DELETE FROM Estudiantes WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0)
                    {
                        MessageBox.Show("No se encontró un estudiante con ese Id en la base de datos.");
                    }
                }
            }

            CargarEstudiantes();
            LimpiarCampos();
        }

        // ====== BOTÓN LIMPIAR ======
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ====== EVENTO DEL DATAGRIDVIEW ======
        private void DgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (DgvEstudiantes.Columns.Count < 4)
                return;

            DataGridViewRow row = DgvEstudiantes.Rows[e.RowIndex];

            TxtId.Text = row.Cells[0].Value?.ToString();
            TxtNombre.Text = row.Cells[1].Value?.ToString();
            TxtEmail.Text = row.Cells[2].Value?.ToString();
            comboPromedio.Text = row.Cells[3].Value?.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        // Comentario agregado en la rama feature/comentario-estudiante

        //ya se actualizo el texbox de id 

    }
}