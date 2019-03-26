namespace Jornal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._chineseSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sunSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addbt = new System.Windows.Forms.Button();
            this.Removebt = new System.Windows.Forms.Button();
            this.Infobt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.Surname,
            this.Mail,
            this.Birthday,
            this.IsAdult,
            this.IsBirthday,
            this._chineseSign,
            this._sunSign});
            this.dataGridView1.Location = new System.Drawing.Point(13, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 70;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 70;
            // 
            // IsAdult
            // 
            this.IsAdult.HeaderText = "Is adult";
            this.IsAdult.Name = "IsAdult";
            this.IsAdult.ReadOnly = true;
            this.IsAdult.Width = 70;
            // 
            // IsBirthday
            // 
            this.IsBirthday.HeaderText = "Is birthday";
            this.IsBirthday.Name = "IsBirthday";
            this.IsBirthday.ReadOnly = true;
            this.IsBirthday.Width = 70;
            // 
            // _chineseSign
            // 
            this._chineseSign.HeaderText = "Chinese sign";
            this._chineseSign.Name = "_chineseSign";
            this._chineseSign.ReadOnly = true;
            // 
            // _sunSign
            // 
            this._sunSign.HeaderText = "Sun sign";
            this._sunSign.Name = "_sunSign";
            this._sunSign.ReadOnly = true;
            // 
            // Addbt
            // 
            this.Addbt.Location = new System.Drawing.Point(13, 302);
            this.Addbt.Name = "Addbt";
            this.Addbt.Size = new System.Drawing.Size(75, 23);
            this.Addbt.TabIndex = 1;
            this.Addbt.Text = "Add";
            this.Addbt.UseVisualStyleBackColor = true;
            this.Addbt.Click += new System.EventHandler(this.Addbt_Click);
            // 
            // Removebt
            // 
            this.Removebt.Location = new System.Drawing.Point(168, 302);
            this.Removebt.Name = "Removebt";
            this.Removebt.Size = new System.Drawing.Size(75, 23);
            this.Removebt.TabIndex = 2;
            this.Removebt.Text = "Remove";
            this.Removebt.UseVisualStyleBackColor = true;
            this.Removebt.Click += new System.EventHandler(this.Removebt_Click);
            // 
            // Infobt
            // 
            this.Infobt.Location = new System.Drawing.Point(328, 302);
            this.Infobt.Name = "Infobt";
            this.Infobt.Size = new System.Drawing.Size(75, 23);
            this.Infobt.TabIndex = 3;
            this.Infobt.Text = "Info";
            this.Infobt.UseVisualStyleBackColor = true;
            this.Infobt.Click += new System.EventHandler(this.Infobt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Infobt);
            this.Controls.Add(this.Removebt);
            this.Controls.Add(this.Addbt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbt;
        private System.Windows.Forms.Button Removebt;
        private System.Windows.Forms.Button Infobt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdult;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn _chineseSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sunSign;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

