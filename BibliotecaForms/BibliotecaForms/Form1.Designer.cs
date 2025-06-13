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
            LibrosRegistradosTab = new TabPage();
            BibliotecaGrid = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            label1 = new Label();
            btnActualizarGrid = new Button();
            tabControl1.SuspendLayout();
            RegistrarTab.SuspendLayout();
            LibrosRegistradosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BibliotecaGrid).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(138, 142);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(37, 15);
            Titulo.TabIndex = 0;
            Titulo.Text = "Titulo";
            // 
            // inputTitulo
            // 
            inputTitulo.Location = new Point(198, 134);
            inputTitulo.Name = "inputTitulo";
            inputTitulo.Size = new Size(118, 23);
            inputTitulo.TabIndex = 1;
            // 
            // inputAutor
            // 
            inputAutor.Location = new Point(198, 164);
            inputAutor.Name = "inputAutor";
            inputAutor.Size = new Size(118, 23);
            inputAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 172);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // inputAño
            // 
            inputAño.Location = new Point(198, 193);
            inputAño.Name = "inputAño";
            inputAño.Size = new Size(118, 23);
            inputAño.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 201);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(198, 238);
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
            tabControl1.Controls.Add(LibrosRegistradosTab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(28, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 385);
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
            RegistrarTab.Size = new Size(530, 357);
            RegistrarTab.TabIndex = 0;
            RegistrarTab.Text = "Registrar";
            RegistrarTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(129, 46);
            label4.Name = "label4";
            label4.Size = new Size(232, 28);
            label4.TabIndex = 7;
            label4.Text = "Registro de nuevos libros";
            // 
            // LibrosRegistradosTab
            // 
            LibrosRegistradosTab.Controls.Add(btnActualizarGrid);
            LibrosRegistradosTab.Controls.Add(BibliotecaGrid);
            LibrosRegistradosTab.Location = new Point(4, 24);
            LibrosRegistradosTab.Name = "LibrosRegistradosTab";
            LibrosRegistradosTab.Padding = new Padding(3);
            LibrosRegistradosTab.Size = new Size(530, 357);
            LibrosRegistradosTab.TabIndex = 1;
            LibrosRegistradosTab.Text = "Libros Registrados";
            LibrosRegistradosTab.UseVisualStyleBackColor = true;
            // 
            // BibliotecaGrid
            // 
            BibliotecaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BibliotecaGrid.Location = new Point(130, 22);
            BibliotecaGrid.Name = "BibliotecaGrid";
            BibliotecaGrid.Size = new Size(268, 288);
            BibliotecaGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(530, 357);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(530, 357);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(530, 357);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(530, 357);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(530, 357);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(530, 357);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 8;
            label1.Text = "BIBLIOTECA";
            // 
            // btnActualizarGrid
            // 
            btnActualizarGrid.Location = new Point(20, 22);
            btnActualizarGrid.Name = "btnActualizarGrid";
            btnActualizarGrid.Size = new Size(75, 23);
            btnActualizarGrid.TabIndex = 1;
            btnActualizarGrid.Text = "Actualizar";
            btnActualizarGrid.UseVisualStyleBackColor = true;
            btnActualizarGrid.Click += btnActualizarGrid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            RegistrarTab.ResumeLayout(false);
            RegistrarTab.PerformLayout();
            LibrosRegistradosTab.ResumeLayout(false);
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
        private TabPage LibrosRegistradosTab;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private DataGridView BibliotecaGrid;
        private Label label1;
        private Label label4;
        private Button btnActualizarGrid;
    }
}
