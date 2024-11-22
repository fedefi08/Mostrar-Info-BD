namespace ConexcionBdDiscos
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDiscos = new System.Windows.Forms.DataGridView();
            this.BtnDiscos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDiscos
            // 
            this.dtDiscos.ColumnHeadersHeight = 29;
            this.dtDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtDiscos.Location = new System.Drawing.Point(104, 12);
            this.dtDiscos.Name = "dtDiscos";
            this.dtDiscos.RowHeadersWidth = 51;
            this.dtDiscos.RowTemplate.Height = 24;
            this.dtDiscos.Size = new System.Drawing.Size(337, 158);
            this.dtDiscos.TabIndex = 1;
            // 
            // BtnDiscos
            // 
            this.BtnDiscos.Location = new System.Drawing.Point(104, 176);
            this.BtnDiscos.Name = "BtnDiscos";
            this.BtnDiscos.Size = new System.Drawing.Size(143, 40);
            this.BtnDiscos.TabIndex = 0;
            this.BtnDiscos.Text = "Mostrar Informacion";
            this.BtnDiscos.UseVisualStyleBackColor = true;
            this.BtnDiscos.Click += new System.EventHandler(this.btnCargarDiscos_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(530, 264);
            this.Controls.Add(this.dtDiscos);
            this.Controls.Add(this.BtnDiscos);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDiscos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtDiscos;
        private System.Windows.Forms.Button BtnDiscos;
    }
}

