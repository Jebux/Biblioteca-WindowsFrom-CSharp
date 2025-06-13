namespace BibliotecaForms
{
    partial class Form1
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
            Titulo = new Label();
            inputTitulo = new TextBox();
            inputAutor = new TextBox();
            label2 = new Label();
            inputAño = new TextBox();
            label3 = new Label();
            btnRegistrar = new Button();
            tabControl1 = new TabControl();
            RegistrarTab = new TabPage();
            label4 = new Label();
            PrestarLibroTab = new TabPage();
            AntiguedadTab = new TabPage();
            CalAntiguedadTab = new TabPage();
            ModificarTab = new TabPage();
            DevolverTab = new TabPage();
            CompararTab = new TabPage();
            BibliotecaGrid = new DataGridView();
            label1 = new Label();
            label5 = new Label();
            btnPrestar = new Button();
            label6 = new Label();
            inputPrestar = new TextBox();
            label7 = new Label();
            btnDevolver = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox5 = new TextBox();
            tabControl1.SuspendLayout();
            RegistrarTab.SuspendLayout();
            PrestarLibroTab.SuspendLayout();
            ModificarTab.SuspendLayout();
            DevolverTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BibliotecaGrid).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(42, 65);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(37, 15);
            Titulo.TabIndex = 0;
            Titulo.Text = "Titulo";
            // 
            // inputTitulo
            // 
            inputTitulo.Location = new Point(85, 62);
            inputTitulo.Name = "inputTitulo";
            inputTitulo.Size = new Size(318, 23);
            inputTitulo.TabIndex = 1;
            // 
            // inputAutor
            // 
            inputAutor.Location = new Point(85, 91);
            inputAutor.Name = "inputAutor";
            inputAutor.Size = new Size(318, 23);
            inputAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 94);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // inputAño
            // 
            inputAño.Location = new Point(85, 123);
            inputAño.Name = "inputAño";
            inputAño.Size = new Size(118, 23);
            inputAño.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 123);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(285, 165);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistro_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RegistrarTab);
            tabControl1.Controls.Add(ModificarTab);
            tabControl1.Controls.Add(PrestarLibroTab);
            tabControl1.Controls.Add(DevolverTab);
            tabControl1.Controls.Add(AntiguedadTab);
            tabControl1.Controls.Add(CalAntiguedadTab);
            tabControl1.Controls.Add(CompararTab);
            tabControl1.Location = new Point(22, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(453, 244);
            tabControl1.TabIndex = 7;
            // 
            // RegistrarTab
            // 
            RegistrarTab.Controls.Add(label4);
            RegistrarTab.Controls.Add(inputAutor);
            RegistrarTab.Controls.Add(btnRegistrar);
            RegistrarTab.Controls.Add(Titulo);
            RegistrarTab.Controls.Add(inputAño);
            RegistrarTab.Controls.Add(inputTitulo);
            RegistrarTab.Controls.Add(label3);
            RegistrarTab.Controls.Add(label2);
            RegistrarTab.Location = new Point(4, 24);
            RegistrarTab.Name = "RegistrarTab";
            RegistrarTab.Padding = new Padding(3);
            RegistrarTab.Size = new Size(445, 216);
            RegistrarTab.TabIndex = 0;
            RegistrarTab.Text = "Registrar";
            RegistrarTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(115, 15);
            label4.Name = "label4";
            label4.Size = new Size(232, 28);
            label4.TabIndex = 7;
            label4.Text = "Registro de nuevos libros";
            label4.Click += label4_Click;
            // 
            // PrestarLibroTab
            // 
            PrestarLibroTab.Controls.Add(label5);
            PrestarLibroTab.Controls.Add(btnPrestar);
            PrestarLibroTab.Controls.Add(label6);
            PrestarLibroTab.Controls.Add(inputPrestar);
            PrestarLibroTab.Location = new Point(4, 24);
            PrestarLibroTab.Name = "PrestarLibroTab";
            PrestarLibroTab.Padding = new Padding(3);
            PrestarLibroTab.Size = new Size(445, 216);
            PrestarLibroTab.TabIndex = 1;
            PrestarLibroTab.Text = "Prestar";
            PrestarLibroTab.UseVisualStyleBackColor = true;
            // 
            // AntiguedadTab
            // 
            AntiguedadTab.Location = new Point(4, 24);
            AntiguedadTab.Name = "AntiguedadTab";
            AntiguedadTab.Padding = new Padding(3);
            AntiguedadTab.Size = new Size(445, 216);
            AntiguedadTab.TabIndex = 2;
            AntiguedadTab.Text = "Antiguo";
            AntiguedadTab.UseVisualStyleBackColor = true;
            // 
            // CalAntiguedadTab
            // 
            CalAntiguedadTab.Location = new Point(4, 24);
            CalAntiguedadTab.Name = "CalAntiguedadTab";
            CalAntiguedadTab.Padding = new Padding(3);
            CalAntiguedadTab.Size = new Size(445, 216);
            CalAntiguedadTab.TabIndex = 3;
            CalAntiguedadTab.Text = "CalcAnt";
            CalAntiguedadTab.UseVisualStyleBackColor = true;
            // 
            // ModificarTab
            // 
            ModificarTab.Controls.Add(label13);
            ModificarTab.Controls.Add(textBox5);
            ModificarTab.Controls.Add(label9);
            ModificarTab.Controls.Add(textBox2);
            ModificarTab.Controls.Add(button1);
            ModificarTab.Controls.Add(label10);
            ModificarTab.Controls.Add(textBox3);
            ModificarTab.Controls.Add(textBox4);
            ModificarTab.Controls.Add(label11);
            ModificarTab.Controls.Add(label12);
            ModificarTab.Location = new Point(4, 24);
            ModificarTab.Name = "ModificarTab";
            ModificarTab.Padding = new Padding(3);
            ModificarTab.Size = new Size(445, 216);
            ModificarTab.TabIndex = 4;
            ModificarTab.Text = "Modificar";
            ModificarTab.UseVisualStyleBackColor = true;
            // 
            // DevolverTab
            // 
            DevolverTab.Controls.Add(label7);
            DevolverTab.Controls.Add(btnDevolver);
            DevolverTab.Controls.Add(label8);
            DevolverTab.Controls.Add(textBox1);
            DevolverTab.Location = new Point(4, 24);
            DevolverTab.Name = "DevolverTab";
            DevolverTab.Padding = new Padding(3);
            DevolverTab.Size = new Size(445, 216);
            DevolverTab.TabIndex = 5;
            DevolverTab.Text = "Devolver";
            DevolverTab.UseVisualStyleBackColor = true;
            // 
            // CompararTab
            // 
            CompararTab.Location = new Point(4, 24);
            CompararTab.Name = "CompararTab";
            CompararTab.Padding = new Padding(3);
            CompararTab.Size = new Size(445, 216);
            CompararTab.TabIndex = 6;
            CompararTab.Text = "Comparar";
            CompararTab.UseVisualStyleBackColor = true;
            // 
            // BibliotecaGrid
            // 
            BibliotecaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BibliotecaGrid.Location = new Point(493, 49);
            BibliotecaGrid.Name = "BibliotecaGrid";
            BibliotecaGrid.Size = new Size(268, 371);
            BibliotecaGrid.TabIndex = 0;
            BibliotecaGrid.CellContentClick += BibliotecaGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 8;
            label1.Text = "BIBLIOTECA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(154, 17);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 11;
            label5.Text = "Prestar libros";
            // 
            // btnPrestar
            // 
            btnPrestar.Location = new Point(270, 113);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(118, 23);
            btnPrestar.TabIndex = 10;
            btnPrestar.Text = "Prestar";
            btnPrestar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 70);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 8;
            label6.Text = "Titulo a prestar";
            // 
            // inputPrestar
            // 
            inputPrestar.Location = new Point(118, 67);
            inputPrestar.Name = "inputPrestar";
            inputPrestar.Size = new Size(270, 23);
            inputPrestar.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(144, 27);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 15;
            label7.Text = "Devolver libros";
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(285, 125);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(118, 23);
            btnDevolver.TabIndex = 14;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 83);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 12;
            label8.Text = "Titulo a devolver";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(100, 9);
            label9.Name = "label9";
            label9.Size = new Size(260, 28);
            label9.TabIndex = 15;
            label9.Text = "Modificar Información libros";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(285, 178);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 14;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 82);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 8;
            label10.Text = "Nuevo Titulo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 140);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 12;
            label11.Text = "Nuevo Año";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 111);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 10;
            label12.Text = "Nuevo Autor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 53);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 16;
            label13.Text = "Titulo a modificar";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 50);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 23);
            textBox5.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 445);
            Controls.Add(label1);
            Controls.Add(BibliotecaGrid);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            RegistrarTab.ResumeLayout(false);
            RegistrarTab.PerformLayout();
            PrestarLibroTab.ResumeLayout(false);
            PrestarLibroTab.PerformLayout();
            ModificarTab.ResumeLayout(false);
            ModificarTab.PerformLayout();
            DevolverTab.ResumeLayout(false);
            DevolverTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BibliotecaGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox inputTitulo;
        private TextBox inputAutor;
        private Label label2;
        private TextBox inputAño;
        private Label label3;
        private Button btnRegistrar;
        private TabControl tabControl1;
        private TabPage RegistrarTab;
        private TabPage PrestarLibroTab;
        private TabPage AntiguedadTab;
        private TabPage CalAntiguedadTab;
        private TabPage ModificarTab;
        private TabPage DevolverTab;
        private TabPage CompararTab;
        private DataGridView BibliotecaGrid;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnPrestar;
        private Label label6;
        private TextBox inputPrestar;
        private Label label13;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox2;
        private Button button1;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label11;
        private Label label12;
        private Label label7;
        private Button btnDevolver;
        private Label label8;
        private TextBox textBox1;
    }
}
