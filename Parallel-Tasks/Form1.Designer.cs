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
            this.file1Label = new System.Windows.Forms.Label();
            this.file2 = new System.Windows.Forms.Label();
            this.searchProfile = new System.Windows.Forms.Button();
            this.file3 = new System.Windows.Forms.Label();
            this.searchShop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchClient
            // 
            this.searchClient.Location = new System.Drawing.Point(12, 12);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(81, 40);
            this.searchClient.TabIndex = 0;
            this.searchClient.Text = "Clientes";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // file1Label
            // 
            this.file1Label.AutoSize = true;
            this.file1Label.Location = new System.Drawing.Point(99, 26);
            this.file1Label.Name = "file1Label";
            this.file1Label.Size = new System.Drawing.Size(90, 13);
            this.file1Label.TabIndex = 2;
            this.file1Label.Text = "Busca un archivo";
            // 
            // file2
            // 
            this.file2.AutoSize = true;
            this.file2.Location = new System.Drawing.Point(99, 72);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(90, 13);
            this.file2.TabIndex = 6;
            this.file2.Text = "Busca un archivo";
            // 
            // searchProfile
            // 
            this.searchProfile.Location = new System.Drawing.Point(12, 58);
            this.searchProfile.Name = "searchProfile";
            this.searchProfile.Size = new System.Drawing.Size(81, 40);
            this.searchProfile.TabIndex = 4;
            this.searchProfile.Text = "Perfiles";
            this.searchProfile.UseVisualStyleBackColor = true;
            this.searchProfile.Click += new System.EventHandler(this.searchProfile_Click);
            // 
            // file3
            // 
            this.file3.AutoSize = true;
            this.file3.Location = new System.Drawing.Point(99, 118);
            this.file3.Name = "file3";
            this.file3.Size = new System.Drawing.Size(90, 13);
            this.file3.TabIndex = 9;
            this.file3.Text = "Busca un archivo";
            this.file3.Click += new System.EventHandler(this.file3_Click);
            // 
            // searchShop
            // 
            this.searchShop.Location = new System.Drawing.Point(12, 104);
            this.searchShop.Name = "searchShop";
            this.searchShop.Size = new System.Drawing.Size(81, 40);
            this.searchShop.TabIndex = 7;
            this.searchShop.Text = "Compras";
            this.searchShop.UseVisualStyleBackColor = true;
            this.searchShop.Click += new System.EventHandler(this.searchShop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Secuencial",
            "Parallel"});
            this.comboBox1.Location = new System.Drawing.Point(19, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Ejecución";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 309);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Consultas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "Mayor Compra";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "Buscar Compras";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 50);
            this.button6.TabIndex = 18;
            this.button6.Text = "Compras Sospechosas";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(206, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 461);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "< Remove ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Resultados Ejecución";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(222, 315);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(323, 130);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Resultados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Clientes a Consultar";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 285);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 160);
            this.listBox2.TabIndex = 23;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(71, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Add >";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Desde:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 121);
            this.listBox1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(222, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 181);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Configuración de Consulta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(774, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.file3);
            this.Controls.Add(this.searchShop);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.searchProfile);
            this.Controls.Add(this.file1Label);
            this.Controls.Add(this.searchClient);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.Label file1Label;
        private System.Windows.Forms.Label file2;
        private System.Windows.Forms.Button searchProfile;
        private System.Windows.Forms.Label file3;
        private System.Windows.Forms.Button searchShop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

