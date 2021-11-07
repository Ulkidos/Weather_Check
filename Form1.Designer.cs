namespace Weather_Check
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_General = new System.Windows.Forms.DataGridView();
            this.деньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.температураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вологістьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.осіданняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тискDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.погодаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherDataSet = new Weather_Check.WeatherDataSet();
            this.погодаTableAdapter = new Weather_Check.WeatherDataSetTableAdapters.ПогодаTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаТаблицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_General)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.погодаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_General
            // 
            this.dataGridView_General.AutoGenerateColumns = false;
            this.dataGridView_General.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_General.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.деньDataGridViewTextBoxColumn,
            this.температураDataGridViewTextBoxColumn,
            this.вологістьDataGridViewTextBoxColumn,
            this.осіданняDataGridViewTextBoxColumn,
            this.тискDataGridViewTextBoxColumn});
            this.dataGridView_General.DataSource = this.погодаBindingSource;
            this.dataGridView_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_General.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_General.Name = "dataGridView_General";
            this.dataGridView_General.RowHeadersWidth = 51;
            this.dataGridView_General.RowTemplate.Height = 24;
            this.dataGridView_General.Size = new System.Drawing.Size(800, 420);
            this.dataGridView_General.TabIndex = 1;
            // 
            // деньDataGridViewTextBoxColumn
            // 
            this.деньDataGridViewTextBoxColumn.DataPropertyName = "День";
            this.деньDataGridViewTextBoxColumn.HeaderText = "День";
            this.деньDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньDataGridViewTextBoxColumn.Name = "деньDataGridViewTextBoxColumn";
            this.деньDataGridViewTextBoxColumn.Width = 125;
            // 
            // температураDataGridViewTextBoxColumn
            // 
            this.температураDataGridViewTextBoxColumn.DataPropertyName = "Температура";
            this.температураDataGridViewTextBoxColumn.HeaderText = "Температура";
            this.температураDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.температураDataGridViewTextBoxColumn.Name = "температураDataGridViewTextBoxColumn";
            this.температураDataGridViewTextBoxColumn.Width = 125;
            // 
            // вологістьDataGridViewTextBoxColumn
            // 
            this.вологістьDataGridViewTextBoxColumn.DataPropertyName = "Вологість";
            this.вологістьDataGridViewTextBoxColumn.HeaderText = "Вологість";
            this.вологістьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вологістьDataGridViewTextBoxColumn.Name = "вологістьDataGridViewTextBoxColumn";
            this.вологістьDataGridViewTextBoxColumn.Width = 125;
            // 
            // осіданняDataGridViewTextBoxColumn
            // 
            this.осіданняDataGridViewTextBoxColumn.DataPropertyName = "Осідання";
            this.осіданняDataGridViewTextBoxColumn.HeaderText = "Осідання";
            this.осіданняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.осіданняDataGridViewTextBoxColumn.Name = "осіданняDataGridViewTextBoxColumn";
            this.осіданняDataGridViewTextBoxColumn.Width = 125;
            // 
            // тискDataGridViewTextBoxColumn
            // 
            this.тискDataGridViewTextBoxColumn.DataPropertyName = "Тиск";
            this.тискDataGridViewTextBoxColumn.HeaderText = "Тиск";
            this.тискDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тискDataGridViewTextBoxColumn.Name = "тискDataGridViewTextBoxColumn";
            this.тискDataGridViewTextBoxColumn.Width = 125;
            // 
            // погодаBindingSource
            // 
            this.погодаBindingSource.DataMember = "Погода";
            this.погодаBindingSource.DataSource = this.weatherDataSet;
            // 
            // weatherDataSet
            // 
            this.weatherDataSet.DataSetName = "WeatherDataSet";
            this.weatherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // погодаTableAdapter
            // 
            this.погодаTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаТаблицяToolStripMenuItem});
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            // 
            // основнаТаблицяToolStripMenuItem
            // 
            this.основнаТаблицяToolStripMenuItem.Name = "основнаТаблицяToolStripMenuItem";
            this.основнаТаблицяToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.основнаТаблицяToolStripMenuItem.Text = "Основна таблиця";
            this.основнаТаблицяToolStripMenuItem.Click += new System.EventHandler(this.основнаТаблицяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_General);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_General)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.погодаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_General;
        private WeatherDataSet weatherDataSet;
        private System.Windows.Forms.BindingSource погодаBindingSource;
        private WeatherDataSetTableAdapters.ПогодаTableAdapter погодаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn температураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вологістьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn осіданняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тискDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаТаблицяToolStripMenuItem;
    }
}

