namespace Lab7
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
            components = new System.ComponentModel.Container();
            dataGridViewFilms = new DataGridView();
            filmBindingSource = new BindingSource(components);
            txtBoxTitle = new TextBox();
            txtBoxDirector = new TextBox();
            txtBoxWriter = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxYear = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            lblDirector = new Label();
            lblWriter = new Label();
            lblGenre = new Label();
            lblYear = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            writerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFilms
            // 
            dataGridViewFilms.AutoGenerateColumns = false;
            dataGridViewFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilms.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, directorDataGridViewTextBoxColumn, writerDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewFilms.DataSource = filmBindingSource;
            dataGridViewFilms.Location = new Point(246, 14);
            dataGridViewFilms.Margin = new Padding(4, 3, 4, 3);
            dataGridViewFilms.Name = "dataGridViewFilms";
            dataGridViewFilms.Size = new Size(545, 173);
            dataGridViewFilms.TabIndex = 0;
            dataGridViewFilms.CellContentClick += dataGridViewFilms_CellContentClick;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Entity.Film);
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(74, 14);
            txtBoxTitle.Margin = new Padding(4, 3, 4, 3);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(116, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxDirector
            // 
            txtBoxDirector.Location = new Point(74, 44);
            txtBoxDirector.Margin = new Padding(4, 3, 4, 3);
            txtBoxDirector.Name = "txtBoxDirector";
            txtBoxDirector.Size = new Size(116, 23);
            txtBoxDirector.TabIndex = 2;
            // 
            // txtBoxWriter
            // 
            txtBoxWriter.Location = new Point(74, 74);
            txtBoxWriter.Margin = new Padding(4, 3, 4, 3);
            txtBoxWriter.Name = "txtBoxWriter";
            txtBoxWriter.Size = new Size(116, 23);
            txtBoxWriter.TabIndex = 3;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Location = new Point(74, 104);
            txtBoxGenre.Margin = new Padding(4, 3, 4, 3);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.Size = new Size(116, 23);
            txtBoxGenre.TabIndex = 4;
            // 
            // txtBoxYear
            // 
            txtBoxYear.Location = new Point(74, 134);
            txtBoxYear.Margin = new Padding(4, 3, 4, 3);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(116, 23);
            txtBoxYear.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 189);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(100, 189);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(26, 17);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(39, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Назва";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(15, 47);
            lblDirector.Margin = new Padding(4, 0, 4, 0);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(55, 15);
            lblDirector.TabIndex = 10;
            lblDirector.Text = "Режисер";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Location = new Point(4, 77);
            lblWriter.Margin = new Padding(4, 0, 4, 0);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(66, 15);
            lblWriter.TabIndex = 11;
            lblWriter.Text = "Сценарист";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(26, 107);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 12;
            lblGenre.Text = "Жанр";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(26, 137);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(23, 15);
            lblYear.TabIndex = 13;
            lblYear.Text = "Рік";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Назва";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            directorDataGridViewTextBoxColumn.HeaderText = "Режисер";
            directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // writerDataGridViewTextBoxColumn
            // 
            writerDataGridViewTextBoxColumn.DataPropertyName = "Writer";
            writerDataGridViewTextBoxColumn.HeaderText = "Сценарист";
            writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Рік";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 519);
            Controls.Add(lblYear);
            Controls.Add(lblGenre);
            Controls.Add(lblWriter);
            Controls.Add(lblDirector);
            Controls.Add(lblTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxYear);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxWriter);
            Controls.Add(txtBoxDirector);
            Controls.Add(txtBoxTitle);
            Controls.Add(dataGridViewFilms);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilms).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxDirector;
        private System.Windows.Forms.TextBox txtBoxWriter;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private BindingSource filmBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}
