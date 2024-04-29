namespace GDKlaba3WordSearcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.text_SearchTerm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CurrentFile = new System.Windows.Forms.Label();
            this.list_SearchResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(123, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_SearchTerm
            // 
            this.text_SearchTerm.Location = new System.Drawing.Point(13, 88);
            this.text_SearchTerm.Name = "text_SearchTerm";
            this.text_SearchTerm.Size = new System.Drawing.Size(186, 20);
            this.text_SearchTerm.TabIndex = 4;
            this.text_SearchTerm.Text = "Заданное слово";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Импортировать файл";
            // 
            // label_CurrentFile
            // 
            this.label_CurrentFile.AutoSize = true;
            this.label_CurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CurrentFile.Location = new System.Drawing.Point(8, 46);
            this.label_CurrentFile.Name = "label_CurrentFile";
            this.label_CurrentFile.Size = new System.Drawing.Size(84, 13);
            this.label_CurrentFile.TabIndex = 14;
            this.label_CurrentFile.Text = "Текущий файл:";
            this.label_CurrentFile.Click += new System.EventHandler(this.label3_Click);
            // 
            // list_SearchResults
            // 
            this.list_SearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.lvi});
            this.list_SearchResults.HideSelection = false;
            this.list_SearchResults.Location = new System.Drawing.Point(13, 123);
            this.list_SearchResults.Name = "list_SearchResults";
            this.list_SearchResults.Size = new System.Drawing.Size(401, 139);
            this.list_SearchResults.TabIndex = 15;
            this.list_SearchResults.UseCompatibleStateImageBehavior = false;
            this.list_SearchResults.View = System.Windows.Forms.View.Details;
            this.list_SearchResults.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Строка";
            this.columnHeader1.Width = 280;
            // 
            // lvi
            // 
            this.lvi.Text = "№ строки";
            this.lvi.Width = 80;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 268);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 187);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.list_SearchResults);
            this.Controls.Add(this.label_CurrentFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_SearchTerm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Поисковик слов Зенцов Данил ПИ-22Б";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_SearchTerm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CurrentFile;
        private System.Windows.Forms.ListView list_SearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader lvi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

