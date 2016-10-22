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
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonBC = new System.Windows.Forms.Button();
            this.buttonCS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listTClientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
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
            this.file2.Location = new System.Drawing.Point(12, 374);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(90, 13);
            this.file2.TabIndex = 6;
            this.file2.Text = "Busca un archivo";
            // 
            // searchProfile
            // 
            this.searchProfile.Location = new System.Drawing.Point(15, 331);
            this.searchProfile.Name = "searchProfile";
            this.searchProfile.Size = new System.Drawing.Size(185, 40);
            this.searchProfile.TabIndex = 4;
            this.searchProfile.Text = "Perfiles";
            this.searchProfile.UseVisualStyleBackColor = true;
            this.searchProfile.Click += new System.EventHandler(this.searchProfile_Click);
            // 
            // file3
            // 
            this.file3.AutoSize = true;
            this.file3.Location = new System.Drawing.Point(12, 285);
            this.file3.Name = "file3";
            this.file3.Size = new System.Drawing.Size(90, 13);
            this.file3.TabIndex = 9;
            this.file3.Text = "Busca un archivo";
            // 
            // searchShop
            // 
            this.searchShop.Location = new System.Drawing.Point(15, 242);
            this.searchShop.Name = "searchShop";
            this.searchShop.Size = new System.Drawing.Size(185, 40);
            this.searchShop.TabIndex = 7;
            this.searchShop.Text = "Compras";
            this.searchShop.UseVisualStyleBackColor = true;
            this.searchShop.Click += new System.EventHandler(this.searchShop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Secuencial",
            "Parallel"});
            this.comboBox1.Location = new System.Drawing.Point(320, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Ejecución";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonMC);
            this.panel1.Controls.Add(this.buttonBC);
            this.panel1.Controls.Add(this.buttonCS);
            this.panel1.Location = new System.Drawing.Point(222, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 108);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Consultas";
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(19, 42);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(70, 50);
            this.buttonMC.TabIndex = 16;
            this.buttonMC.Text = "Mayor Compra";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonBC
            // 
            this.buttonBC.Location = new System.Drawing.Point(98, 42);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Size = new System.Drawing.Size(79, 50);
            this.buttonBC.TabIndex = 17;
            this.buttonBC.Text = "Buscar Compras";
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.buttonBC_Click);
            // 
            // buttonCS
            // 
            this.buttonCS.Location = new System.Drawing.Point(183, 42);
            this.buttonCS.Name = "buttonCS";
            this.buttonCS.Size = new System.Drawing.Size(89, 50);
            this.buttonCS.TabIndex = 18;
            this.buttonCS.Text = "Compras Sospechosas";
            this.buttonCS.UseVisualStyleBackColor = true;
            this.buttonCS.Click += new System.EventHandler(this.buttonCS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listClientes);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(206, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 509);
            this.panel2.TabIndex = 22;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(16, 66);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(76, 23);
            this.buttonRemove.TabIndex = 31;
            this.buttonRemove.Text = "< Remove ";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 43);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add >";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Resultados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Clientes a Consultar";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(16, 106);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(200, 108);
            this.listClientes.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Desde:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(266, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(490, 241);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Configuración de Consulta";
            // 
            // listTClientes
            // 
            this.listTClientes.FormattingEnabled = true;
            this.listTClientes.Location = new System.Drawing.Point(11, 58);
            this.listTClientes.Name = "listTClientes";
            this.listTClientes.Size = new System.Drawing.Size(189, 173);
            this.listTClientes.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "v1.0 KatKankin 2016";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 302);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Archivo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(15, 397);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ver Archivo";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(728, 518);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.file3);
            this.Controls.Add(this.searchShop);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.searchProfile);
            this.Controls.Add(this.file1Label);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.listTClientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button buttonBC;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonCS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listTClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

