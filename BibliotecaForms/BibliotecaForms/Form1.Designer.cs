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
            ModificarTab = new TabPage();
            label13 = new Label();
            inputModificarTitulo = new TextBox();
            label9 = new Label();
            inputNuevoAutor = new TextBox();
            button1 = new Button();
            label10 = new Label();
            inputNuevoAnio = new TextBox();
            inputNuevoTitulo = new TextBox();
            label11 = new Label();
            label12 = new Label();
            PrestarLibroTab = new TabPage();
            label5 = new Label();
            btnPrestar = new Button();
            label6 = new Label();
            inputPrestar = new TextBox();
            DevolverTab = new TabPage();
            label7 = new Label();
            btnDevolver = new Button();
            label8 = new Label();
            inputDevolver = new TextBox();
            AntiguedadTab = new TabPage();
            label14 = new Label();
            btnAntiguo = new Button();
            label15 = new Label();
            inputAntiguo = new TextBox();
            CalAntiguedadTab = new TabPage();
            label16 = new Label();
            btnCalcAntiguedad = new Button();
            label17 = new Label();
            inputCalcAnt = new TextBox();
            CompararTab = new TabPage();
            label21 = new Label();
            label20 = new Label();
            inputComparar2 = new TextBox();
            label18 = new Label();
            btnComparar = new Button();
            label19 = new Label();
            inputComparar1 = new TextBox();
            BibliotecaGrid = new DataGridView();
            label1 = new Label();
            tabControl1.SuspendLayout();
            RegistrarTab.SuspendLayout();
            ModificarTab.SuspendLayout();
            PrestarLibroTab.SuspendLayout();
            DevolverTab.SuspendLayout();
            AntiguedadTab.SuspendLayout();
            CalAntiguedadTab.SuspendLayout();
            CompararTab.SuspendLayout();
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
            btnRegistrar.Click += Event_Registro_Click;
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
            tabControl1.Location = new Point(9, 49);
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
            // 
            // ModificarTab
            // 
            ModificarTab.Controls.Add(label13);
            ModificarTab.Controls.Add(inputModificarTitulo);
            ModificarTab.Controls.Add(label9);
            ModificarTab.Controls.Add(inputNuevoAutor);
            ModificarTab.Controls.Add(button1);
            ModificarTab.Controls.Add(label10);
            ModificarTab.Controls.Add(inputNuevoAnio);
            ModificarTab.Controls.Add(inputNuevoTitulo);
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 53);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 16;
            label13.Text = "Titulo a modificar";
            // 
            // inputModificarTitulo
            // 
            inputModificarTitulo.Location = new Point(148, 50);
            inputModificarTitulo.Name = "inputModificarTitulo";
            inputModificarTitulo.Size = new Size(255, 23);
            inputModificarTitulo.TabIndex = 17;
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
            // inputNuevoAutor
            // 
            inputNuevoAutor.Location = new Point(148, 108);
            inputNuevoAutor.Name = "inputNuevoAutor";
            inputNuevoAutor.Size = new Size(255, 23);
            inputNuevoAutor.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(285, 178);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 14;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Event_ModificarInfo_Click;
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
            // inputNuevoAnio
            // 
            inputNuevoAnio.Location = new Point(148, 140);
            inputNuevoAnio.Name = "inputNuevoAnio";
            inputNuevoAnio.Size = new Size(95, 23);
            inputNuevoAnio.TabIndex = 13;
            // 
            // inputNuevoTitulo
            // 
            inputNuevoTitulo.Location = new Point(148, 79);
            inputNuevoTitulo.Name = "inputNuevoTitulo";
            inputNuevoTitulo.Size = new Size(255, 23);
            inputNuevoTitulo.TabIndex = 9;
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
            btnPrestar.Click += Event_Prestar_Click;
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
            // DevolverTab
            // 
            DevolverTab.Controls.Add(label7);
            DevolverTab.Controls.Add(btnDevolver);
            DevolverTab.Controls.Add(label8);
            DevolverTab.Controls.Add(inputDevolver);
            DevolverTab.Location = new Point(4, 24);
            DevolverTab.Name = "DevolverTab";
            DevolverTab.Padding = new Padding(3);
            DevolverTab.Size = new Size(445, 216);
            DevolverTab.TabIndex = 5;
            DevolverTab.Text = "Devolver";
            DevolverTab.UseVisualStyleBackColor = true;
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
            btnDevolver.Click += Event_Devolver_Click;
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
            // inputDevolver
            // 
            inputDevolver.Location = new Point(133, 79);
            inputDevolver.Name = "inputDevolver";
            inputDevolver.Size = new Size(270, 23);
            inputDevolver.TabIndex = 13;
            // 
            // AntiguedadTab
            // 
            AntiguedadTab.Controls.Add(label14);
            AntiguedadTab.Controls.Add(btnAntiguo);
            AntiguedadTab.Controls.Add(label15);
            AntiguedadTab.Controls.Add(inputAntiguo);
            AntiguedadTab.Location = new Point(4, 24);
            AntiguedadTab.Name = "AntiguedadTab";
            AntiguedadTab.Padding = new Padding(3);
            AntiguedadTab.Size = new Size(445, 216);
            AntiguedadTab.TabIndex = 2;
            AntiguedadTab.Text = "Antiguo";
            AntiguedadTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(116, 12);
            label14.Name = "label14";
            label14.Size = new Size(191, 28);
            label14.TabIndex = 19;
            label14.Text = "¿El Libro es antigüo?";
            // 
            // btnAntiguo
            // 
            btnAntiguo.Location = new Point(289, 112);
            btnAntiguo.Name = "btnAntiguo";
            btnAntiguo.Size = new Size(118, 23);
            btnAntiguo.TabIndex = 18;
            btnAntiguo.Text = "Consultar";
            btnAntiguo.UseVisualStyleBackColor = true;
            btnAntiguo.Click += Event_Antiguo_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(30, 69);
            label15.Name = "label15";
            label15.Size = new Size(101, 15);
            label15.TabIndex = 16;
            label15.Text = "Titulo a consultar:";
            // 
            // inputAntiguo
            // 
            inputAntiguo.Location = new Point(137, 66);
            inputAntiguo.Name = "inputAntiguo";
            inputAntiguo.Size = new Size(270, 23);
            inputAntiguo.TabIndex = 17;
            // 
            // CalAntiguedadTab
            // 
            CalAntiguedadTab.Controls.Add(label16);
            CalAntiguedadTab.Controls.Add(btnCalcAntiguedad);
            CalAntiguedadTab.Controls.Add(label17);
            CalAntiguedadTab.Controls.Add(inputCalcAnt);
            CalAntiguedadTab.Location = new Point(4, 24);
            CalAntiguedadTab.Name = "CalAntiguedadTab";
            CalAntiguedadTab.Padding = new Padding(3);
            CalAntiguedadTab.Size = new Size(445, 216);
            CalAntiguedadTab.TabIndex = 3;
            CalAntiguedadTab.Text = "CalcAnt";
            CalAntiguedadTab.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F);
            label16.Location = new Point(116, 12);
            label16.Name = "label16";
            label16.Size = new Size(186, 28);
            label16.TabIndex = 19;
            label16.Text = "Calcular antigüedad";
            // 
            // btnCalcAntiguedad
            // 
            btnCalcAntiguedad.Location = new Point(291, 114);
            btnCalcAntiguedad.Name = "btnCalcAntiguedad";
            btnCalcAntiguedad.Size = new Size(118, 23);
            btnCalcAntiguedad.TabIndex = 18;
            btnCalcAntiguedad.Text = "Calcular";
            btnCalcAntiguedad.UseVisualStyleBackColor = true;
            btnCalcAntiguedad.Click += Event_CalcAntiguedad_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(39, 72);
            label17.Name = "label17";
            label17.Size = new Size(98, 15);
            label17.TabIndex = 16;
            label17.Text = "Titulo a consultar";
            // 
            // inputCalcAnt
            // 
            inputCalcAnt.Location = new Point(139, 68);
            inputCalcAnt.Name = "inputCalcAnt";
            inputCalcAnt.Size = new Size(270, 23);
            inputCalcAnt.TabIndex = 17;
            // 
            // CompararTab
            // 
            CompararTab.Controls.Add(label21);
            CompararTab.Controls.Add(label20);
            CompararTab.Controls.Add(inputComparar2);
            CompararTab.Controls.Add(label18);
            CompararTab.Controls.Add(btnComparar);
            CompararTab.Controls.Add(label19);
            CompararTab.Controls.Add(inputComparar1);
            CompararTab.Location = new Point(4, 24);
            CompararTab.Name = "CompararTab";
            CompararTab.Padding = new Padding(3);
            CompararTab.Size = new Size(445, 216);
            CompararTab.TabIndex = 6;
            CompararTab.Text = "Comparar";
            CompararTab.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 9F);
            label21.Location = new Point(38, 46);
            label21.Name = "label21";
            label21.Size = new Size(368, 16);
            label21.TabIndex = 22;
            label21.Text = "Ingrese los titulos que desea averiguar si tienen el mismo autor";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(35, 120);
            label20.Name = "label20";
            label20.Size = new Size(46, 15);
            label20.TabIndex = 20;
            label20.Text = "Titulo 2";
            // 
            // inputComparar2
            // 
            inputComparar2.Location = new Point(105, 117);
            inputComparar2.Name = "inputComparar2";
            inputComparar2.Size = new Size(300, 23);
            inputComparar2.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F);
            label18.Location = new Point(146, 10);
            label18.Name = "label18";
            label18.Size = new Size(129, 28);
            label18.TabIndex = 19;
            label18.Text = "Comparación";
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(289, 159);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(118, 23);
            btnComparar.TabIndex = 18;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += Event_Comparar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(35, 82);
            label19.Name = "label19";
            label19.Size = new Size(46, 15);
            label19.TabIndex = 16;
            label19.Text = "Titulo 1";
            // 
            // inputComparar1
            // 
            inputComparar1.Location = new Point(105, 78);
            inputComparar1.Name = "inputComparar1";
            inputComparar1.Size = new Size(300, 23);
            inputComparar1.TabIndex = 17;
            // 
            // BibliotecaGrid
            // 
            BibliotecaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BibliotecaGrid.Location = new Point(468, 49);
            BibliotecaGrid.Name = "BibliotecaGrid";
            BibliotecaGrid.Size = new Size(403, 371);
            BibliotecaGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 8;
            label1.Text = "BIBLIOTECA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(883, 445);
            Controls.Add(label1);
            Controls.Add(BibliotecaGrid);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            RegistrarTab.ResumeLayout(false);
            RegistrarTab.PerformLayout();
            ModificarTab.ResumeLayout(false);
            ModificarTab.PerformLayout();
            PrestarLibroTab.ResumeLayout(false);
            PrestarLibroTab.PerformLayout();
            DevolverTab.ResumeLayout(false);
            DevolverTab.PerformLayout();
            AntiguedadTab.ResumeLayout(false);
            AntiguedadTab.PerformLayout();
            CalAntiguedadTab.ResumeLayout(false);
            CalAntiguedadTab.PerformLayout();
            CompararTab.ResumeLayout(false);
            CompararTab.PerformLayout();
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
        private TextBox inputModificarTitulo;
        private Label label9;
        private TextBox inputNuevoAutor;
        private Button button1;
        private Label label10;
        private TextBox inputNuevoAnio;
        private TextBox inputNuevoTitulo;
        private Label label11;
        private Label label12;
        private Label label7;
        private Button btnDevolver;
        private Label label8;
        private TextBox inputDevolver;
        private Label label14;
        private Button btnAntiguo;
        private Label label15;
        private TextBox inputAntiguo;
        private Label label16;
        private Button btnCalcAntiguedad;
        private Label label17;
        private TextBox inputCalcAnt;
        private Label label18;
        private Button btnComparar;
        private Label label19;
        private TextBox inputComparar1;
        private Label label21;
        private Label label20;
        private TextBox inputComparar2;
    }
}
