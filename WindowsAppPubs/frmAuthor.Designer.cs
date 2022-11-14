namespace WindowsAppPubs
{
    partial class frmAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            this.btnTraerUno = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridTraer = new System.Windows.Forms.DataGridView();
            this.GridViewTraerUno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTraer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTraerUno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(343, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por Id";
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(563, 139);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodo.TabIndex = 2;
            this.btnTraerTodo.Text = "Traer Todos";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // btnTraerUno
            // 
            this.btnTraerUno.Location = new System.Drawing.Point(440, 139);
            this.btnTraerUno.Name = "btnTraerUno";
            this.btnTraerUno.Size = new System.Drawing.Size(75, 23);
            this.btnTraerUno.TabIndex = 3;
            this.btnTraerUno.Text = "Traer Uno";
            this.btnTraerUno.UseVisualStyleBackColor = true;
            this.btnTraerUno.Click += new System.EventHandler(this.btnTraerUno_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(78, 139);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(203, 139);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(319, 139);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridTraer
            // 
            this.dataGridTraer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTraer.Location = new System.Drawing.Point(93, 222);
            this.dataGridTraer.Name = "dataGridTraer";
            this.dataGridTraer.Size = new System.Drawing.Size(240, 150);
            this.dataGridTraer.TabIndex = 7;
            // 
            // GridViewTraerUno
            // 
            this.GridViewTraerUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTraerUno.Location = new System.Drawing.Point(440, 222);
            this.GridViewTraerUno.Name = "GridViewTraerUno";
            this.GridViewTraerUno.Size = new System.Drawing.Size(240, 150);
            this.GridViewTraerUno.TabIndex = 8;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewTraerUno);
            this.Controls.Add(this.dataGridTraer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnTraerUno);
            this.Controls.Add(this.btnTraerTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTraer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTraerUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraerTodo;
        private System.Windows.Forms.Button btnTraerUno;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridTraer;
        private System.Windows.Forms.DataGridView GridViewTraerUno;
    }
}