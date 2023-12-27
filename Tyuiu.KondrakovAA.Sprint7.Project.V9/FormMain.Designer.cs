
namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    partial class FormMain_KAA
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
            this.openFileDialog_KAA = new System.Windows.Forms.OpenFileDialog();
            this.textBoxSearch_KAA = new System.Windows.Forms.TextBox();
            this.buttonSaveFile_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.buttonStats_KAA = new System.Windows.Forms.Button();
            this.labelSearch_KAA = new System.Windows.Forms.Label();
            this.buttonVideogames_KAA = new System.Windows.Forms.Button();
            this.buttonScience_KAA = new System.Windows.Forms.Button();
            this.buttonIT_KAA = new System.Windows.Forms.Button();
            this.buttonNature_KAA = new System.Windows.Forms.Button();
            this.buttonCuisine_KAA = new System.Windows.Forms.Button();
            this.buttonSports_KAA = new System.Windows.Forms.Button();
            this.listBoxVideos_KAA = new System.Windows.Forms.ListBox();
            this.panelButtons_KAA = new System.Windows.Forms.Panel();
            this.panelCategories_KAA = new System.Windows.Forms.Panel();
            this.buttonMusic_KAA = new System.Windows.Forms.Button();
            this.panelButtons_KAA.SuspendLayout();
            this.panelCategories_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch_KAA
            // 
            this.textBoxSearch_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch_KAA.Location = new System.Drawing.Point(11, 65);
            this.textBoxSearch_KAA.Name = "textBoxSearch_KAA";
            this.textBoxSearch_KAA.Size = new System.Drawing.Size(379, 20);
            this.textBoxSearch_KAA.TabIndex = 1;
            this.textBoxSearch_KAA.TextChanged += new System.EventHandler(this.searchListener);
            // 
            // buttonSaveFile_KAA
            // 
            this.buttonSaveFile_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile_KAA.BackgroundImage = global::Tyuiu.KondrakovAA.Sprint7.Project.V9.Properties.Resources.vhs;
            this.buttonSaveFile_KAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveFile_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_KAA.Location = new System.Drawing.Point(538, 44);
            this.buttonSaveFile_KAA.Name = "buttonSaveFile_KAA";
            this.buttonSaveFile_KAA.Size = new System.Drawing.Size(61, 47);
            this.buttonSaveFile_KAA.TabIndex = 4;
            this.buttonSaveFile_KAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KAA.Click += new System.EventHandler(this.buttonLoadListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout_KAA.Location = new System.Drawing.Point(493, 12);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(106, 29);
            this.buttonAbout_KAA.TabIndex = 4;
            this.buttonAbout_KAA.Text = "О программе";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.buttonAboutListener);
            // 
            // buttonStats_KAA
            // 
            this.buttonStats_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStats_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStats_KAA.Location = new System.Drawing.Point(394, 12);
            this.buttonStats_KAA.Name = "buttonStats_KAA";
            this.buttonStats_KAA.Size = new System.Drawing.Size(93, 29);
            this.buttonStats_KAA.TabIndex = 5;
            this.buttonStats_KAA.Text = "Статистика";
            this.buttonStats_KAA.UseVisualStyleBackColor = true;
            this.buttonStats_KAA.Click += new System.EventHandler(this.statsListener);
            // 
            // labelSearch_KAA
            // 
            this.labelSearch_KAA.AutoSize = true;
            this.labelSearch_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_KAA.Location = new System.Drawing.Point(11, 42);
            this.labelSearch_KAA.Name = "labelSearch_KAA";
            this.labelSearch_KAA.Size = new System.Drawing.Size(60, 20);
            this.labelSearch_KAA.TabIndex = 6;
            this.labelSearch_KAA.Text = "Поиск";
            // 
            // buttonVideogames_KAA
            // 
            this.buttonVideogames_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideogames_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVideogames_KAA.Location = new System.Drawing.Point(3, 249);
            this.buttonVideogames_KAA.Name = "buttonVideogames_KAA";
            this.buttonVideogames_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonVideogames_KAA.TabIndex = 3;
            this.buttonVideogames_KAA.Text = "Видеоигры";
            this.buttonVideogames_KAA.UseVisualStyleBackColor = true;
            this.buttonVideogames_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // buttonScience_KAA
            // 
            this.buttonScience_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScience_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScience_KAA.Location = new System.Drawing.Point(3, 170);
            this.buttonScience_KAA.Name = "buttonScience_KAA";
            this.buttonScience_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonScience_KAA.TabIndex = 1;
            this.buttonScience_KAA.Text = "Наука";
            this.buttonScience_KAA.UseVisualStyleBackColor = true;
            this.buttonScience_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // buttonIT_KAA
            // 
            this.buttonIT_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIT_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIT_KAA.Location = new System.Drawing.Point(3, 328);
            this.buttonIT_KAA.Name = "buttonIT_KAA";
            this.buttonIT_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonIT_KAA.TabIndex = 5;
            this.buttonIT_KAA.Text = "Технологии";
            this.buttonIT_KAA.UseVisualStyleBackColor = true;
            this.buttonIT_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // buttonNature_KAA
            // 
            this.buttonNature_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNature_KAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNature_KAA.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonNature_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNature_KAA.Location = new System.Drawing.Point(3, 12);
            this.buttonNature_KAA.Name = "buttonNature_KAA";
            this.buttonNature_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonNature_KAA.TabIndex = 0;
            this.buttonNature_KAA.Text = "Природа";
            this.buttonNature_KAA.UseVisualStyleBackColor = true;
            this.buttonNature_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // buttonCuisine_KAA
            // 
            this.buttonCuisine_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCuisine_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCuisine_KAA.Location = new System.Drawing.Point(3, 486);
            this.buttonCuisine_KAA.Name = "buttonCuisine_KAA";
            this.buttonCuisine_KAA.Size = new System.Drawing.Size(361, 75);
            this.buttonCuisine_KAA.TabIndex = 6;
            this.buttonCuisine_KAA.Text = "Кулинария";
            this.buttonCuisine_KAA.UseVisualStyleBackColor = true;
            this.buttonCuisine_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // buttonSports_KAA
            // 
            this.buttonSports_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSports_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSports_KAA.Location = new System.Drawing.Point(3, 407);
            this.buttonSports_KAA.Name = "buttonSports_KAA";
            this.buttonSports_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonSports_KAA.TabIndex = 2;
            this.buttonSports_KAA.Text = "Спорт";
            this.buttonSports_KAA.UseVisualStyleBackColor = true;
            this.buttonSports_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // listBoxVideos_KAA
            // 
            this.listBoxVideos_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVideos_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxVideos_KAA.FormattingEnabled = true;
            this.listBoxVideos_KAA.ItemHeight = 20;
            this.listBoxVideos_KAA.Location = new System.Drawing.Point(6, 97);
            this.listBoxVideos_KAA.Name = "listBoxVideos_KAA";
            this.listBoxVideos_KAA.Size = new System.Drawing.Size(600, 464);
            this.listBoxVideos_KAA.TabIndex = 0;
            this.listBoxVideos_KAA.SelectedIndexChanged += new System.EventHandler(this.listBoxVideosListener);
            // 
            // panelButtons_KAA
            // 
            this.panelButtons_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons_KAA.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons_KAA.Controls.Add(this.labelSearch_KAA);
            this.panelButtons_KAA.Controls.Add(this.buttonStats_KAA);
            this.panelButtons_KAA.Controls.Add(this.textBoxSearch_KAA);
            this.panelButtons_KAA.Controls.Add(this.buttonSaveFile_KAA);
            this.panelButtons_KAA.Controls.Add(this.buttonAbout_KAA);
            this.panelButtons_KAA.Location = new System.Drawing.Point(1, 0);
            this.panelButtons_KAA.Name = "panelButtons_KAA";
            this.panelButtons_KAA.Size = new System.Drawing.Size(605, 100);
            this.panelButtons_KAA.TabIndex = 4;
            // 
            // panelCategories_KAA
            // 
            this.panelCategories_KAA.BackColor = System.Drawing.Color.Transparent;
            this.panelCategories_KAA.Controls.Add(this.buttonSports_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonCuisine_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonNature_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonIT_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonMusic_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonScience_KAA);
            this.panelCategories_KAA.Controls.Add(this.buttonVideogames_KAA);
            this.panelCategories_KAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCategories_KAA.Location = new System.Drawing.Point(612, 0);
            this.panelCategories_KAA.Name = "panelCategories_KAA";
            this.panelCategories_KAA.Size = new System.Drawing.Size(376, 572);
            this.panelCategories_KAA.TabIndex = 9;
            // 
            // buttonMusic_KAA
            // 
            this.buttonMusic_KAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMusic_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMusic_KAA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMusic_KAA.Location = new System.Drawing.Point(3, 91);
            this.buttonMusic_KAA.Name = "buttonMusic_KAA";
            this.buttonMusic_KAA.Size = new System.Drawing.Size(361, 73);
            this.buttonMusic_KAA.TabIndex = 4;
            this.buttonMusic_KAA.Text = "Музыка";
            this.buttonMusic_KAA.UseVisualStyleBackColor = true;
            this.buttonMusic_KAA.Click += new System.EventHandler(this.setTheme);
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 572);
            this.Controls.Add(this.listBoxVideos_KAA);
            this.Controls.Add(this.panelButtons_KAA);
            this.Controls.Add(this.panelCategories_KAA);
            this.MinimumSize = new System.Drawing.Size(1003, 611);
            this.Name = "FormMain_KAA";
            this.Text = "Hotline Tunes";
            this.panelButtons_KAA.ResumeLayout(false);
            this.panelButtons_KAA.PerformLayout();
            this.panelCategories_KAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog_KAA;
        private System.Windows.Forms.TextBox textBoxSearch_KAA;
        private System.Windows.Forms.Button buttonSaveFile_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.Button buttonStats_KAA;
        private System.Windows.Forms.Label labelSearch_KAA;
        private System.Windows.Forms.Button buttonVideogames_KAA;
        private System.Windows.Forms.Button buttonScience_KAA;
        private System.Windows.Forms.Button buttonMusic_KAA;
        private System.Windows.Forms.Button buttonIT_KAA;
        private System.Windows.Forms.Button buttonNature_KAA;
        private System.Windows.Forms.Button buttonCuisine_KAA;
        private System.Windows.Forms.Button buttonSports_KAA;
        private System.Windows.Forms.ListBox listBoxVideos_KAA;
        private System.Windows.Forms.Panel panelButtons_KAA;
        private System.Windows.Forms.Panel panelCategories_KAA;
    }
}

