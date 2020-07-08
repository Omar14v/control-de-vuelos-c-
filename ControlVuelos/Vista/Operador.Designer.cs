namespace Ejemplo.Interfaz
{
    partial class Operador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtAterrizaje = new System.Windows.Forms.DateTimePicker();
            this.dtDespegue = new System.Windows.Forms.DateTimePicker();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraAterrizaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoraDespegue = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAterrizaje
            // 
            this.dtAterrizaje.Location = new System.Drawing.Point(307, 110);
            this.dtAterrizaje.Name = "dtAterrizaje";
            this.dtAterrizaje.Size = new System.Drawing.Size(249, 20);
            this.dtAterrizaje.TabIndex = 98;
            // 
            // dtDespegue
            // 
            this.dtDespegue.Location = new System.Drawing.Point(15, 109);
            this.dtDespegue.Name = "dtDespegue";
            this.dtDespegue.Size = new System.Drawing.Size(249, 20);
            this.dtDespegue.TabIndex = 97;
            this.dtDespegue.Value = new System.DateTime(2020, 2, 25, 16, 26, 17, 0);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(307, 44);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(249, 20);
            this.txtDestino.TabIndex = 96;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(601, 43);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(155, 20);
            this.txtTipo.TabIndex = 95;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(601, 110);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(155, 20);
            this.txtEstado.TabIndex = 94;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(15, 43);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(249, 20);
            this.txtOrigen.TabIndex = 76;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(462, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 30);
            this.btnModificar.TabIndex = 93;
            this.btnModificar.Text = "Actualizar Datos";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(6)))), ((int)(((byte)(34)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(617, 192);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 30);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar Datos";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "Tipo del Vuelo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(598, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Código del Vuelo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(704, 150);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 20);
            this.txtCodigo.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Hora del Aterrizaje:";
            // 
            // txtHoraAterrizaje
            // 
            this.txtHoraAterrizaje.Location = new System.Drawing.Point(494, 150);
            this.txtHoraAterrizaje.Name = "txtHoraAterrizaje";
            this.txtHoraAterrizaje.Size = new System.Drawing.Size(62, 20);
            this.txtHoraAterrizaje.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Hora del Despegue:";
            // 
            // txtHoraDespegue
            // 
            this.txtHoraDespegue.Location = new System.Drawing.Point(202, 150);
            this.txtHoraDespegue.Name = "txtHoraDespegue";
            this.txtHoraDespegue.Size = new System.Drawing.Size(62, 20);
            this.txtHoraDespegue.TabIndex = 85;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(307, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 30);
            this.btnAgregar.TabIndex = 84;
            this.btnAgregar.Text = "Ingresar Datos";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "VUELOS PROGRAMADOS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Estado del Vuelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Aterrizaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Despegue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ciudad Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ciudad Origen:";
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgregar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(15, 239);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.Size = new System.Drawing.Size(798, 270);
            this.dgvAgregar.TabIndex = 77;
            // 
            // Operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtAterrizaje);
            this.Controls.Add(this.dtDespegue);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHoraAterrizaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHoraDespegue);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAgregar);
            this.Name = "Operador";
            this.Size = new System.Drawing.Size(825, 520);
            this.Load += new System.EventHandler(this.Operador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtAterrizaje;
        private System.Windows.Forms.DateTimePicker dtDespegue;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoraAterrizaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoraDespegue;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgregar;
    }
}
