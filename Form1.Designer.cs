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
            this.осіданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_osu = new System.Windows.Forms.TextBox();
            this.явищаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туманToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
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
            this.dataGridView_General.Size = new System.Drawing.Size(680, 344);
            this.dataGridView_General.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціToolStripMenuItem,
            this.аномаліїToolStripMenuItem,
            this.явищаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 28);
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
            this.тискToolStripMenuItem,
            this.осіданняToolStripMenuItem});
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
            this.textBox_temp.Size = new System.Drawing.Size(93, 22);
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
            this.textBox_volog.Size = new System.Drawing.Size(76, 22);
            this.textBox_volog.TabIndex = 6;
            this.textBox_volog.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Коефіцієнт\r\nТиску";
            // 
            // textBox_tusk
            // 
            this.textBox_tusk.Location = new System.Drawing.Point(235, 424);
            this.textBox_tusk.Name = "textBox_tusk";
            this.textBox_tusk.Size = new System.Drawing.Size(76, 22);
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
            // осіданняToolStripMenuItem
            // 
            this.осіданняToolStripMenuItem.Name = "осіданняToolStripMenuItem";
            this.осіданняToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.осіданняToolStripMenuItem.Text = "Осідання";
            this.осіданняToolStripMenuItem.Click += new System.EventHandler(this.осіданняToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Коефіцієнт\r\nОсідання";
            // 
            // textBox_osu
            // 
            this.textBox_osu.Location = new System.Drawing.Point(332, 424);
            this.textBox_osu.Name = "textBox_osu";
            this.textBox_osu.Size = new System.Drawing.Size(76, 22);
            this.textBox_osu.TabIndex = 10;
            this.textBox_osu.Text = "0.7";
            // 
            // явищаToolStripMenuItem
            // 
            this.явищаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дощToolStripMenuItem,
            this.туманToolStripMenuItem});
            this.явищаToolStripMenuItem.Name = "явищаToolStripMenuItem";
            this.явищаToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.явищаToolStripMenuItem.Text = "Явища";
            // 
            // дощToolStripMenuItem
            // 
            this.дощToolStripMenuItem.Name = "дощToolStripMenuItem";
            this.дощToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дощToolStripMenuItem.Text = "Дощ";
            this.дощToolStripMenuItem.Click += new System.EventHandler(this.дощToolStripMenuItem_Click);
            // 
            // туманToolStripMenuItem
            // 
            this.туманToolStripMenuItem.Name = "туманToolStripMenuItem";
            this.туманToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.туманToolStripMenuItem.Text = "Туман";
            this.туманToolStripMenuItem.Click += new System.EventHandler(this.туманToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(802, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Тепло";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(802, 146);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 20);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Нормально";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(802, 189);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 20);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "Нічого";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(802, 228);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 20);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Весна";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(877, 228);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(56, 20);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Літо";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(935, 228);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(68, 20);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "Осьнь";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Температура:";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(877, 63);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(85, 20);
            this.checkBox8.TabIndex = 19;
            this.checkBox8.Text = "Холодно";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(968, 63);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(73, 20);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "Жарко";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Тиск:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(802, 102);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 20);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Нормальний";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(919, 102);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(84, 20);
            this.checkBox10.TabIndex = 22;
            this.checkBox10.Text = "Високий";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(1009, 102);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(85, 20);
            this.checkBox11.TabIndex = 23;
            this.checkBox11.Text = "Низький";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Вологість:";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(911, 146);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(60, 20);
            this.checkBox12.TabIndex = 25;
            this.checkBox12.Text = "Сухо";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(977, 146);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(76, 20);
            this.checkBox13.TabIndex = 26;
            this.checkBox13.Text = "Волого";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Опади:";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(880, 189);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(55, 20);
            this.checkBox14.TabIndex = 28;
            this.checkBox14.Text = "Дощ";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(941, 186);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(71, 20);
            this.checkBox15.TabIndex = 29;
            this.checkBox15.Text = "Туман";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(1017, 186);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(55, 20);
            this.checkBox16.TabIndex = 30;
            this.checkBox16.Text = "Сніг";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(1078, 186);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(51, 20);
            this.checkBox17.TabIndex = 31;
            this.checkBox17.Text = "Іній";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Сезон:";
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(1009, 228);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(63, 20);
            this.checkBox18.TabIndex = 33;
            this.checkBox18.Text = "Зима";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_osu);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.ToolStripMenuItem осіданняToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_osu;
        private System.Windows.Forms.ToolStripMenuItem явищаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem туманToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox18;
    }
}

