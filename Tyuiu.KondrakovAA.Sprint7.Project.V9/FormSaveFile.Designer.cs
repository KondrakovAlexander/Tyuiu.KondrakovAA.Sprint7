
namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    partial class FormSaveFile_KAA
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
            this.buttonPickTheFile_KAA = new System.Windows.Forms.Button();
            this.labelData_KAA = new System.Windows.Forms.Label();
            this.labelDuration_KAA = new System.Windows.Forms.Label();
            this.labelTheme_KAA = new System.Windows.Forms.Label();
            this.textBoxDateTime_KAA = new System.Windows.Forms.TextBox();
            this.textBoxDuration_KAA = new System.Windows.Forms.TextBox();
            this.textBoxName_KAA = new System.Windows.Forms.TextBox();
            this.labelName_KAA = new System.Windows.Forms.Label();
            this.openFileDialog_KAA = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxTheme_KAA = new System.Windows.Forms.ComboBox();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPickTheFile_KAA
            // 
            this.buttonPickTheFile_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPickTheFile_KAA.Location = new System.Drawing.Point(12, 157);
            this.buttonPickTheFile_KAA.Name = "buttonPickTheFile_KAA";
            this.buttonPickTheFile_KAA.Size = new System.Drawing.Size(152, 37);
            this.buttonPickTheFile_KAA.TabIndex = 0;
            this.buttonPickTheFile_KAA.Text = "Выбрать файл";
            this.buttonPickTheFile_KAA.UseVisualStyleBackColor = true;
            this.buttonPickTheFile_KAA.Click += new System.EventHandler(this.buttonLoadListener);
            // 
            // labelData_KAA
            // 
            this.labelData_KAA.AutoSize = true;
            this.labelData_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData_KAA.Location = new System.Drawing.Point(9, 13);
            this.labelData_KAA.Name = "labelData_KAA";
            this.labelData_KAA.Size = new System.Drawing.Size(83, 13);
            this.labelData_KAA.TabIndex = 2;
            this.labelData_KAA.Text = "Дата записи";
            // 
            // labelDuration_KAA
            // 
            this.labelDuration_KAA.AutoSize = true;
            this.labelDuration_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDuration_KAA.Location = new System.Drawing.Point(9, 36);
            this.labelDuration_KAA.Name = "labelDuration_KAA";
            this.labelDuration_KAA.Size = new System.Drawing.Size(92, 13);
            this.labelDuration_KAA.TabIndex = 3;
            this.labelDuration_KAA.Text = "Длительность";
            // 
            // labelTheme_KAA
            // 
            this.labelTheme_KAA.AutoSize = true;
            this.labelTheme_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheme_KAA.Location = new System.Drawing.Point(248, 13);
            this.labelTheme_KAA.Name = "labelTheme_KAA";
            this.labelTheme_KAA.Size = new System.Drawing.Size(38, 13);
            this.labelTheme_KAA.TabIndex = 4;
            this.labelTheme_KAA.Text = "Тема";
            // 
            // textBoxDateTime_KAA
            // 
            this.textBoxDateTime_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.textBoxDateTime_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateTime_KAA.Location = new System.Drawing.Point(95, 10);
            this.textBoxDateTime_KAA.Name = "textBoxDateTime_KAA";
            this.textBoxDateTime_KAA.ReadOnly = true;
            this.textBoxDateTime_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateTime_KAA.TabIndex = 6;
            this.textBoxDateTime_KAA.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // textBoxDuration_KAA
            // 
            this.textBoxDuration_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.textBoxDuration_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDuration_KAA.Location = new System.Drawing.Point(107, 33);
            this.textBoxDuration_KAA.Name = "textBoxDuration_KAA";
            this.textBoxDuration_KAA.ReadOnly = true;
            this.textBoxDuration_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration_KAA.TabIndex = 7;
            this.textBoxDuration_KAA.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // textBoxName_KAA
            // 
            this.textBoxName_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.textBoxName_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_KAA.Location = new System.Drawing.Point(313, 33);
            this.textBoxName_KAA.Name = "textBoxName_KAA";
            this.textBoxName_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxName_KAA.TabIndex = 8;
            this.textBoxName_KAA.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // labelName_KAA
            // 
            this.labelName_KAA.AutoSize = true;
            this.labelName_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KAA.Location = new System.Drawing.Point(248, 36);
            this.labelName_KAA.Name = "labelName_KAA";
            this.labelName_KAA.Size = new System.Drawing.Size(65, 13);
            this.labelName_KAA.TabIndex = 10;
            this.labelName_KAA.Text = "Название";
            // 
            // comboBoxTheme_KAA
            // 
            this.comboBoxTheme_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.comboBoxTheme_KAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTheme_KAA.FormattingEnabled = true;
            this.comboBoxTheme_KAA.Items.AddRange(new object[] {
            "Природа",
            "Спорт",
            "Наука",
            "Видеоигры",
            "Музыка",
            "Технологии",
            "Кулинария"});
            this.comboBoxTheme_KAA.Location = new System.Drawing.Point(292, 9);
            this.comboBoxTheme_KAA.Name = "comboBoxTheme_KAA";
            this.comboBoxTheme_KAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTheme_KAA.TabIndex = 11;
            this.comboBoxTheme_KAA.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Enabled = false;
            this.buttonEnter_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter_KAA.Location = new System.Drawing.Point(171, 157);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(140, 37);
            this.buttonEnter_KAA.TabIndex = 12;
            this.buttonEnter_KAA.Text = "Подтвердить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonEnterListener);
            // 
            // FormSaveFile_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 206);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Controls.Add(this.comboBoxTheme_KAA);
            this.Controls.Add(this.labelName_KAA);
            this.Controls.Add(this.textBoxName_KAA);
            this.Controls.Add(this.textBoxDuration_KAA);
            this.Controls.Add(this.textBoxDateTime_KAA);
            this.Controls.Add(this.labelTheme_KAA);
            this.Controls.Add(this.labelDuration_KAA);
            this.Controls.Add(this.labelData_KAA);
            this.Controls.Add(this.buttonPickTheFile_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSaveFile_KAA";
            this.Text = "Добавление файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPickTheFile_KAA;
        private System.Windows.Forms.Label labelData_KAA;
        private System.Windows.Forms.Label labelDuration_KAA;
        private System.Windows.Forms.Label labelTheme_KAA;
        private System.Windows.Forms.TextBox textBoxDateTime_KAA;
        private System.Windows.Forms.TextBox textBoxDuration_KAA;
        private System.Windows.Forms.TextBox textBoxName_KAA;
        private System.Windows.Forms.Label labelName_KAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KAA;
        private System.Windows.Forms.ComboBox comboBoxTheme_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
    }
}