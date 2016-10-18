namespace Parallel_Tasks
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchClient = new System.Windows.Forms.Button();
            this.done1 = new System.Windows.Forms.CheckBox();
            this.file1 = new System.Windows.Forms.Label();
            this.file2 = new System.Windows.Forms.Label();
            this.done2 = new System.Windows.Forms.CheckBox();
            this.searchProfile = new System.Windows.Forms.Button();
            this.file3 = new System.Windows.Forms.Label();
            this.done3 = new System.Windows.Forms.CheckBox();
            this.searchShop = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchClient
            // 
            this.searchClient.Location = new System.Drawing.Point(31, 12);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(141, 40);
            this.searchClient.TabIndex = 0;
            this.searchClient.Text = "Clientes";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // done1
            // 
            this.done1.AutoSize = true;
            this.done1.Enabled = false;
            this.done1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done1.Location = new System.Drawing.Point(178, 13);
            this.done1.Name = "done1";
            this.done1.Size = new System.Drawing.Size(90, 33);
            this.done1.TabIndex = 1;
            this.done1.Text = "Done";
            this.done1.UseVisualStyleBackColor = true;
            // 
            // file1
            // 
            this.file1.AutoSize = true;
            this.file1.Location = new System.Drawing.Point(28, 55);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(105, 13);
            this.file1.TabIndex = 2;
            this.file1.Text = "You should find a file";
            // 
            // file2
            // 
            this.file2.AutoSize = true;
            this.file2.Location = new System.Drawing.Point(28, 132);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(105, 13);
            this.file2.TabIndex = 6;
            this.file2.Text = "You should find a file";
            // 
            // done2
            // 
            this.done2.AutoSize = true;
            this.done2.Enabled = false;
            this.done2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done2.Location = new System.Drawing.Point(178, 87);
            this.done2.Name = "done2";
            this.done2.Size = new System.Drawing.Size(90, 33);
            this.done2.TabIndex = 5;
            this.done2.Text = "Done";
            this.done2.UseVisualStyleBackColor = true;
            // 
            // searchProfile
            // 
            this.searchProfile.Location = new System.Drawing.Point(31, 80);
            this.searchProfile.Name = "searchProfile";
            this.searchProfile.Size = new System.Drawing.Size(141, 40);
            this.searchProfile.TabIndex = 4;
            this.searchProfile.Text = "Perfiles";
            this.searchProfile.UseVisualStyleBackColor = true;
            this.searchProfile.Click += new System.EventHandler(this.searchProfile_Click);
            // 
            // file3
            // 
            this.file3.AutoSize = true;
            this.file3.Location = new System.Drawing.Point(28, 214);
            this.file3.Name = "file3";
            this.file3.Size = new System.Drawing.Size(105, 13);
            this.file3.TabIndex = 9;
            this.file3.Text = "You should find a file";
            // 
            // done3
            // 
            this.done3.AutoSize = true;
            this.done3.Enabled = false;
            this.done3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done3.Location = new System.Drawing.Point(178, 165);
            this.done3.Name = "done3";
            this.done3.Size = new System.Drawing.Size(90, 33);
            this.done3.TabIndex = 8;
            this.done3.Text = "Done";
            this.done3.UseVisualStyleBackColor = true;
            // 
            // searchShop
            // 
            this.searchShop.Location = new System.Drawing.Point(31, 158);
            this.searchShop.Name = "searchShop";
            this.searchShop.Size = new System.Drawing.Size(141, 40);
            this.searchShop.TabIndex = 7;
            this.searchShop.Text = "Compras";
            this.searchShop.UseVisualStyleBackColor = true;
            this.searchShop.Click += new System.EventHandler(this.searchShop_Click);
            // 
            // Process
            // 
            this.Process.Enabled = false;
            this.Process.Location = new System.Drawing.Point(295, 273);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(140, 34);
            this.Process.TabIndex = 10;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Secuencial",
            "Parallel"});
            this.comboBox1.Location = new System.Drawing.Point(31, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Execution Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.file3);
            this.Controls.Add(this.done3);
            this.Controls.Add(this.searchShop);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.done2);
            this.Controls.Add(this.searchProfile);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.done1);
            this.Controls.Add(this.searchClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.CheckBox done1;
        private System.Windows.Forms.Label file1;
        private System.Windows.Forms.Label file2;
        private System.Windows.Forms.CheckBox done2;
        private System.Windows.Forms.Button searchProfile;
        private System.Windows.Forms.Label file3;
        private System.Windows.Forms.CheckBox done3;
        private System.Windows.Forms.Button searchShop;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

