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
            this.dataGridView_General = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаТаблицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аномаліїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.температураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вологістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_volog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tusk = new System.Windows.Forms.TextBox();
            this.деньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.температураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вологістьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.осіданняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тискDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.погодаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherDataSet = new Weather_Check.WeatherDataSet();
            this.погодаTableAdapter = new Weather_Check.WeatherDataSetTableAdapters.ПогодаTableAdapter();
            this.tableAdapterManager1 = new Weather_Check.WeatherDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_General)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.погодаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView_General.Location = new System.Drawing.Point(0, 31);
            this.dataGridView_General.Name = "dataGridView_General";
            this.dataGridView_General.RowHeadersWidth = 51;
            this.dataGridView_General.RowTemplate.Height = 24;
            this.dataGridView_General.Size = new System.Drawing.Size(800, 344);
            this.dataGridView_General.TabIndex = 1;
            this.dataGridView_General.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціToolStripMenuItem,
            this.аномаліїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаТаблицяToolStripMenuItem});
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            // 
            // основнаТаблицяToolStripMenuItem
            // 
            this.основнаТаблицяToolStripMenuItem.Name = "основнаТаблицяToolStripMenuItem";
            this.основнаТаблицяToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.основнаТаблицяToolStripMenuItem.Text = "Основна таблиця";
            this.основнаТаблицяToolStripMenuItem.Click += new System.EventHandler(this.основнаТаблицяToolStripMenuItem_Click);
            // 
            // аномаліїToolStripMenuItem
            // 
            this.аномаліїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.температураToolStripMenuItem,
            this.вологістьToolStripMenuItem,
            this.тискToolStripMenuItem});
            this.аномаліїToolStripMenuItem.Name = "аномаліїToolStripMenuItem";
            this.аномаліїToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.аномаліїToolStripMenuItem.Text = "Аномалії";
            // 
            // температураToolStripMenuItem
            // 
            this.температураToolStripMenuItem.Name = "температураToolStripMenuItem";
            this.температураToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.температураToolStripMenuItem.Text = "Температура";
            this.температураToolStripMenuItem.Click += new System.EventHandler(this.температураToolStripMenuItem_Click);
            // 
            // вологістьToolStripMenuItem
            // 
            this.вологістьToolStripMenuItem.Name = "вологістьToolStripMenuItem";
            this.вологістьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вологістьToolStripMenuItem.Text = "Вологість";
            this.вологістьToolStripMenuItem.Click += new System.EventHandler(this.вологістьToolStripMenuItem_Click);
            // 
            // тискToolStripMenuItem
            // 
            this.тискToolStripMenuItem.Name = "тискToolStripMenuItem";
            this.тискToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.тискToolStripMenuItem.Text = "Тиск";
            this.тискToolStripMenuItem.Click += new System.EventHandler(this.тискToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Коефіцієнт\r\nТемператури";
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(16, 424);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(100, 22);
            this.textBox_temp.TabIndex = 3;
            this.textBox_temp.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Коефіцієнт\r\nВологості";
            // 
            // textBox_volog
            // 
            this.textBox_volog.Location = new System.Drawing.Point(135, 424);
            this.textBox_volog.Name = "textBox_volog";
            this.textBox_volog.Size = new System.Drawing.Size(100, 22);
            this.textBox_volog.TabIndex = 6;
            this.textBox_volog.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Коефіцієнт\r\nТиску";
            // 
            // textBox_tusk
            // 
            this.textBox_tusk.Location = new System.Drawing.Point(263, 424);
            this.textBox_tusk.Name = "textBox_tusk";
            this.textBox_tusk.Size = new System.Drawing.Size(100, 22);
            this.textBox_tusk.TabIndex = 8;
            this.textBox_tusk.Text = "2";
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Weather_Check.WeatherDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ПогодаTableAdapter = this.погодаTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_General);
            this.Controls.Add(this.textBox_tusk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_volog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_General)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.погодаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_volog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tusk;
        private System.Windows.Forms.ToolStripMenuItem аномаліїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem температураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вологістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тискToolStripMenuItem;
        private WeatherDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

