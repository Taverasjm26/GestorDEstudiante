namespace GestorDeEstudiantes
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox GroupBox;
            BtnLimpiar = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            comboPromedio = new ComboBox();
            LblPromedio = new Label();
            TxtEmail = new TextBox();
            TxtNombre = new TextBox();
            LblEmail = new Label();
            TxtId = new TextBox();
            LblName = new Label();
            LblId = new Label();
            DgvEstudiantes = new DataGridView();
            GroupBox = new GroupBox();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.BackColor = Color.FromArgb(250, 245, 232);
            GroupBox.Controls.Add(BtnLimpiar);
            GroupBox.Controls.Add(BtnActualizar);
            GroupBox.Controls.Add(BtnEliminar);
            GroupBox.Controls.Add(BtnAgregar);
            GroupBox.Controls.Add(comboPromedio);
            GroupBox.Controls.Add(LblPromedio);
            GroupBox.Controls.Add(TxtEmail);
            GroupBox.Controls.Add(TxtNombre);
            GroupBox.Controls.Add(LblEmail);
            GroupBox.Controls.Add(TxtId);
            GroupBox.Controls.Add(LblName);
            GroupBox.Controls.Add(LblId);
            GroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox.Location = new Point(4, 6);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(857, 314);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "Gestor Estudiantes v2";
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(729, 20);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(116, 45);
            BtnLimpiar.TabIndex = 12;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(483, 20);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(117, 45);
            BtnActualizar.TabIndex = 11;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(606, 20);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(116, 45);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(366, 20);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(102, 45);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // comboPromedio
            // 
            comboPromedio.FormattingEnabled = true;
            comboPromedio.Items.AddRange(new object[] { "Malo", "Normal", "Bueno", "Excelente" });
            comboPromedio.Location = new Point(123, 189);
            comboPromedio.Name = "comboPromedio";
            comboPromedio.Size = new Size(234, 36);
            comboPromedio.TabIndex = 8;
            // 
            // LblPromedio
            // 
            LblPromedio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPromedio.Location = new Point(6, 195);
            LblPromedio.Name = "LblPromedio";
            LblPromedio.Size = new Size(140, 45);
            LblPromedio.TabIndex = 7;
            LblPromedio.Text = "Promedio";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(123, 150);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(234, 33);
            TxtEmail.TabIndex = 6;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(123, 102);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(234, 29);
            TxtNombre.TabIndex = 5;
            // 
            // LblEmail
            // 
            LblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(6, 150);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(140, 45);
            LblEmail.TabIndex = 4;
            LblEmail.Text = "Email";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(123, 60);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(89, 34);
            TxtId.TabIndex = 3;
            // 
            // LblName
            // 
            LblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblName.Location = new Point(6, 105);
            LblName.Name = "LblName";
            LblName.Size = new Size(140, 45);
            LblName.TabIndex = 1;
            LblName.Text = "Nombre";
            // 
            // LblId
            // 
            LblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblId.Location = new Point(6, 60);
            LblId.Name = "LblId";
            LblId.Size = new Size(140, 45);
            LblId.TabIndex = 0;
            LblId.Text = "Id";
            // 
            // DgvEstudiantes
            // 
            DgvEstudiantes.AllowUserToAddRows = false;
            DgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEstudiantes.Location = new Point(4, 320);
            DgvEstudiantes.Name = "DgvEstudiantes";
            DgvEstudiantes.ReadOnly = true;
            DgvEstudiantes.RowHeadersWidth = 62;
            DgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEstudiantes.Size = new Size(857, 323);
            DgvEstudiantes.TabIndex = 1;
            DgvEstudiantes.CellClick += DgvEstudiantes_CellClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 648);
            Controls.Add(DgvEstudiantes);
            Controls.Add(GroupBox);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LblName;
        private Label LblId;
        private TextBox TxtId;
        private Label LblPromedio;
        private TextBox TxtEmail;
        private TextBox TxtNombre;
        private Label LblEmail;
        private ComboBox comboPromedio;
        private DataGridView DgvEstudiantes;
        private Button BtnAgregar;
        private Button BtnLimpiar;
        private Button BtnActualizar;
        private Button BtnEliminar;
    }
}
