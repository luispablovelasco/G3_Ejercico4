namespace G3_Ejercicio04
{
    partial class FrmRecibe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnllenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnllenar
            // 
            this.btnllenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllenar.Location = new System.Drawing.Point(192, 273);
            this.btnllenar.Name = "btnllenar";
            this.btnllenar.Size = new System.Drawing.Size(102, 35);
            this.btnllenar.TabIndex = 1;
            this.btnllenar.Text = "LLENAR";
            this.btnllenar.UseVisualStyleBackColor = true;
            this.btnllenar.Click += new System.EventHandler(this.btnllenar_Click);
            // 
            // FrmRecibe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 365);
            this.Controls.Add(this.btnllenar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRecibe";
            this.Text = "Formulario Recibe";
            this.Load += new System.EventHandler(this.FrmRecibe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnllenar;
    }
}