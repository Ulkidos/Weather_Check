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
            this.таблицяЗаКритеріямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аномаліїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.температураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вологістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осіданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.явищаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туманToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_volog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tusk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_osu = new System.Windows.Forms.TextBox();
            this.checkBox_temp_norm = new System.Windows.Forms.CheckBox();
            this.checkBox_volog_norm = new System.Windows.Forms.CheckBox();
            this.checkBox_osu_nothing = new System.Windows.Forms.CheckBox();
            this.checkBox_sezon_spring = new System.Windows.Forms.CheckBox();
            this.checkBox_sezon_summer = new System.Windows.Forms.CheckBox();
            this.checkBox_sezon_autumn = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_temp_cold = new System.Windows.Forms.CheckBox();
            this.checkBox_temp_hot = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_tusk_norm = new System.Windows.Forms.CheckBox();
            this.checkBox_tusk_high = new System.Windows.Forms.CheckBox();
            this.checkBox_tusk_low = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_volog_dry = new System.Windows.Forms.CheckBox();
            this.checkBox_volog_wet = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_osu_rain = new System.Windows.Forms.CheckBox();
            this.checkBox_osu_fog = new System.Windows.Forms.CheckBox();
            this.checkBox_osu_snow = new System.Windows.Forms.CheckBox();
            this.checkBox_osu_frost = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_sezon_winter = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.основнаТаблицяToolStripMenuItem,
            this.таблицяЗаКритеріямиToolStripMenuItem});
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            // 
            // основнаТаблицяToolStripMenuItem
            // 
            this.основнаТаблицяToolStripMenuItem.Name = "основнаТаблицяToolStripMenuItem";
            this.основнаТаблицяToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.основнаТаблицяToolStripMenuItem.Text = "Основна таблиця";
            this.основнаТаблицяToolStripMenuItem.Click += new System.EventHandler(this.основнаТаблицяToolStripMenuItem_Click);
            // 
            // таблицяЗаКритеріямиToolStripMenuItem
            // 
            this.таблицяЗаКритеріямиToolStripMenuItem.Name = "таблицяЗаКритеріямиToolStripMenuItem";
            this.таблицяЗаКритеріямиToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.таблицяЗаКритеріямиToolStripMenuItem.Text = "Таблиця за критеріями";
            this.таблицяЗаКритеріямиToolStripMenuItem.Click += new System.EventHandler(this.таблицяЗаКритеріямиToolStripMenuItem_Click);
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
            this.температураToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.температураToolStripMenuItem.Text = "Температура";
            this.температураToolStripMenuItem.Click += new System.EventHandler(this.температураToolStripMenuItem_Click);
            // 
            // вологістьToolStripMenuItem
            // 
            this.вологістьToolStripMenuItem.Name = "вологістьToolStripMenuItem";
            this.вологістьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.вологістьToolStripMenuItem.Text = "Вологість";
            this.вологістьToolStripMenuItem.Click += new System.EventHandler(this.вологістьToolStripMenuItem_Click);
            // 
            // тискToolStripMenuItem
            // 
            this.тискToolStripMenuItem.Name = "тискToolStripMenuItem";
            this.тискToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.тискToolStripMenuItem.Text = "Тиск";
            this.тискToolStripMenuItem.Click += new System.EventHandler(this.тискToolStripMenuItem_Click);
            // 
            // осіданняToolStripMenuItem
            // 
            this.осіданняToolStripMenuItem.Name = "осіданняToolStripMenuItem";
            this.осіданняToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.осіданняToolStripMenuItem.Text = "Осідання";
            this.осіданняToolStripMenuItem.Click += new System.EventHandler(this.осіданняToolStripMenuItem_Click);
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
            this.дощToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.дощToolStripMenuItem.Text = "Дощ";
            this.дощToolStripMenuItem.Click += new System.EventHandler(this.дощToolStripMenuItem_Click);
            // 
            // туманToolStripMenuItem
            // 
            this.туманToolStripMenuItem.Name = "туманToolStripMenuItem";
            this.туманToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.туманToolStripMenuItem.Text = "Туман";
            this.туманToolStripMenuItem.Click += new System.EventHandler(this.туманToolStripMenuItem_Click);
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
            // checkBox_temp_norm
            // 
            this.checkBox_temp_norm.AutoSize = true;
            this.checkBox_temp_norm.Checked = true;
            this.checkBox_temp_norm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_temp_norm.Location = new System.Drawing.Point(832, 123);
            this.checkBox_temp_norm.Name = "checkBox_temp_norm";
            this.checkBox_temp_norm.Size = new System.Drawing.Size(83, 20);
            this.checkBox_temp_norm.TabIndex = 11;
            this.checkBox_temp_norm.Text = "Помірна";
            this.checkBox_temp_norm.UseVisualStyleBackColor = true;
            // 
            // checkBox_volog_norm
            // 
            this.checkBox_volog_norm.AutoSize = true;
            this.checkBox_volog_norm.Checked = true;
            this.checkBox_volog_norm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_volog_norm.Location = new System.Drawing.Point(832, 206);
            this.checkBox_volog_norm.Name = "checkBox_volog_norm";
            this.checkBox_volog_norm.Size = new System.Drawing.Size(103, 20);
            this.checkBox_volog_norm.TabIndex = 13;
            this.checkBox_volog_norm.Text = "Нормально";
            this.checkBox_volog_norm.UseVisualStyleBackColor = true;
            // 
            // checkBox_osu_nothing
            // 
            this.checkBox_osu_nothing.AutoSize = true;
            this.checkBox_osu_nothing.Checked = true;
            this.checkBox_osu_nothing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_osu_nothing.Location = new System.Drawing.Point(832, 249);
            this.checkBox_osu_nothing.Name = "checkBox_osu_nothing";
            this.checkBox_osu_nothing.Size = new System.Drawing.Size(72, 20);
            this.checkBox_osu_nothing.TabIndex = 14;
            this.checkBox_osu_nothing.Text = "Нічого";
            this.checkBox_osu_nothing.UseVisualStyleBackColor = true;
            // 
            // checkBox_sezon_spring
            // 
            this.checkBox_sezon_spring.AutoSize = true;
            this.checkBox_sezon_spring.Location = new System.Drawing.Point(832, 284);
            this.checkBox_sezon_spring.Name = "checkBox_sezon_spring";
            this.checkBox_sezon_spring.Size = new System.Drawing.Size(69, 20);
            this.checkBox_sezon_spring.TabIndex = 15;
            this.checkBox_sezon_spring.Text = "Весна";
            this.checkBox_sezon_spring.UseVisualStyleBackColor = true;
            // 
            // checkBox_sezon_summer
            // 
            this.checkBox_sezon_summer.AutoSize = true;
            this.checkBox_sezon_summer.Location = new System.Drawing.Point(907, 284);
            this.checkBox_sezon_summer.Name = "checkBox_sezon_summer";
            this.checkBox_sezon_summer.Size = new System.Drawing.Size(56, 20);
            this.checkBox_sezon_summer.TabIndex = 16;
            this.checkBox_sezon_summer.Text = "Літо";
            this.checkBox_sezon_summer.UseVisualStyleBackColor = true;
            // 
            // checkBox_sezon_autumn
            // 
            this.checkBox_sezon_autumn.AutoSize = true;
            this.checkBox_sezon_autumn.Checked = true;
            this.checkBox_sezon_autumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sezon_autumn.Location = new System.Drawing.Point(965, 284);
            this.checkBox_sezon_autumn.Name = "checkBox_sezon_autumn";
            this.checkBox_sezon_autumn.Size = new System.Drawing.Size(64, 20);
            this.checkBox_sezon_autumn.TabIndex = 17;
            this.checkBox_sezon_autumn.Text = "Осінь";
            this.checkBox_sezon_autumn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Температура:";
            // 
            // checkBox_temp_cold
            // 
            this.checkBox_temp_cold.AutoSize = true;
            this.checkBox_temp_cold.Location = new System.Drawing.Point(921, 123);
            this.checkBox_temp_cold.Name = "checkBox_temp_cold";
            this.checkBox_temp_cold.Size = new System.Drawing.Size(85, 20);
            this.checkBox_temp_cold.TabIndex = 19;
            this.checkBox_temp_cold.Text = "Холодно";
            this.checkBox_temp_cold.UseVisualStyleBackColor = true;
            // 
            // checkBox_temp_hot
            // 
            this.checkBox_temp_hot.AutoSize = true;
            this.checkBox_temp_hot.Location = new System.Drawing.Point(1012, 123);
            this.checkBox_temp_hot.Name = "checkBox_temp_hot";
            this.checkBox_temp_hot.Size = new System.Drawing.Size(73, 20);
            this.checkBox_temp_hot.TabIndex = 20;
            this.checkBox_temp_hot.Text = "Жарко";
            this.checkBox_temp_hot.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Тиск:";
            // 
            // checkBox_tusk_norm
            // 
            this.checkBox_tusk_norm.AutoSize = true;
            this.checkBox_tusk_norm.Checked = true;
            this.checkBox_tusk_norm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_tusk_norm.Location = new System.Drawing.Point(832, 162);
            this.checkBox_tusk_norm.Name = "checkBox_tusk_norm";
            this.checkBox_tusk_norm.Size = new System.Drawing.Size(111, 20);
            this.checkBox_tusk_norm.TabIndex = 12;
            this.checkBox_tusk_norm.Text = "Нормальний";
            this.checkBox_tusk_norm.UseVisualStyleBackColor = true;
            // 
            // checkBox_tusk_high
            // 
            this.checkBox_tusk_high.AutoSize = true;
            this.checkBox_tusk_high.Location = new System.Drawing.Point(949, 162);
            this.checkBox_tusk_high.Name = "checkBox_tusk_high";
            this.checkBox_tusk_high.Size = new System.Drawing.Size(84, 20);
            this.checkBox_tusk_high.TabIndex = 22;
            this.checkBox_tusk_high.Text = "Високий";
            this.checkBox_tusk_high.UseVisualStyleBackColor = true;
            // 
            // checkBox_tusk_low
            // 
            this.checkBox_tusk_low.AutoSize = true;
            this.checkBox_tusk_low.Location = new System.Drawing.Point(1039, 162);
            this.checkBox_tusk_low.Name = "checkBox_tusk_low";
            this.checkBox_tusk_low.Size = new System.Drawing.Size(85, 20);
            this.checkBox_tusk_low.TabIndex = 23;
            this.checkBox_tusk_low.Text = "Низький";
            this.checkBox_tusk_low.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Вологість:";
            // 
            // checkBox_volog_dry
            // 
            this.checkBox_volog_dry.AutoSize = true;
            this.checkBox_volog_dry.Location = new System.Drawing.Point(941, 206);
            this.checkBox_volog_dry.Name = "checkBox_volog_dry";
            this.checkBox_volog_dry.Size = new System.Drawing.Size(60, 20);
            this.checkBox_volog_dry.TabIndex = 25;
            this.checkBox_volog_dry.Text = "Сухо";
            this.checkBox_volog_dry.UseVisualStyleBackColor = true;
            // 
            // checkBox_volog_wet
            // 
            this.checkBox_volog_wet.AutoSize = true;
            this.checkBox_volog_wet.Location = new System.Drawing.Point(1007, 206);
            this.checkBox_volog_wet.Name = "checkBox_volog_wet";
            this.checkBox_volog_wet.Size = new System.Drawing.Size(76, 20);
            this.checkBox_volog_wet.TabIndex = 26;
            this.checkBox_volog_wet.Text = "Волого";
            this.checkBox_volog_wet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(728, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Опади:";
            // 
            // checkBox_osu_rain
            // 
            this.checkBox_osu_rain.AutoSize = true;
            this.checkBox_osu_rain.Location = new System.Drawing.Point(910, 249);
            this.checkBox_osu_rain.Name = "checkBox_osu_rain";
            this.checkBox_osu_rain.Size = new System.Drawing.Size(55, 20);
            this.checkBox_osu_rain.TabIndex = 28;
            this.checkBox_osu_rain.Text = "Дощ";
            this.checkBox_osu_rain.UseVisualStyleBackColor = true;
            // 
            // checkBox_osu_fog
            // 
            this.checkBox_osu_fog.AutoSize = true;
            this.checkBox_osu_fog.Location = new System.Drawing.Point(971, 246);
            this.checkBox_osu_fog.Name = "checkBox_osu_fog";
            this.checkBox_osu_fog.Size = new System.Drawing.Size(71, 20);
            this.checkBox_osu_fog.TabIndex = 29;
            this.checkBox_osu_fog.Text = "Туман";
            this.checkBox_osu_fog.UseVisualStyleBackColor = true;
            // 
            // checkBox_osu_snow
            // 
            this.checkBox_osu_snow.AutoSize = true;
            this.checkBox_osu_snow.Location = new System.Drawing.Point(1119, 246);
            this.checkBox_osu_snow.Name = "checkBox_osu_snow";
            this.checkBox_osu_snow.Size = new System.Drawing.Size(55, 20);
            this.checkBox_osu_snow.TabIndex = 30;
            this.checkBox_osu_snow.Text = "Сніг";
            this.checkBox_osu_snow.UseVisualStyleBackColor = true;
            this.checkBox_osu_snow.Click += new System.EventHandler(this.osu_something);
            // 
            // checkBox_osu_frost
            // 
            this.checkBox_osu_frost.AutoSize = true;
            this.checkBox_osu_frost.Location = new System.Drawing.Point(1180, 246);
            this.checkBox_osu_frost.Name = "checkBox_osu_frost";
            this.checkBox_osu_frost.Size = new System.Drawing.Size(51, 20);
            this.checkBox_osu_frost.TabIndex = 31;
            this.checkBox_osu_frost.Text = "Іній";
            this.checkBox_osu_frost.UseVisualStyleBackColor = true;
            this.checkBox_osu_frost.Click += new System.EventHandler(this.osu_something);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(728, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Сезон:";
            // 
            // checkBox_sezon_winter
            // 
            this.checkBox_sezon_winter.AutoSize = true;
            this.checkBox_sezon_winter.Location = new System.Drawing.Point(1039, 284);
            this.checkBox_sezon_winter.Name = "checkBox_sezon_winter";
            this.checkBox_sezon_winter.Size = new System.Drawing.Size(63, 20);
            this.checkBox_sezon_winter.TabIndex = 33;
            this.checkBox_sezon_winter.Text = "Зима";
            this.checkBox_sezon_winter.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(855, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Критерії";
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
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox_sezon_winter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox_osu_frost);
            this.Controls.Add(this.checkBox_osu_snow);
            this.Controls.Add(this.checkBox_osu_fog);
            this.Controls.Add(this.checkBox_osu_rain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_volog_wet);
            this.Controls.Add(this.checkBox_volog_dry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_tusk_low);
            this.Controls.Add(this.checkBox_tusk_high);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_temp_hot);
            this.Controls.Add(this.checkBox_temp_cold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_sezon_autumn);
            this.Controls.Add(this.checkBox_sezon_summer);
            this.Controls.Add(this.checkBox_sezon_spring);
            this.Controls.Add(this.checkBox_osu_nothing);
            this.Controls.Add(this.checkBox_volog_norm);
            this.Controls.Add(this.checkBox_tusk_norm);
            this.Controls.Add(this.checkBox_temp_norm);
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
        private System.Windows.Forms.CheckBox checkBox_temp_norm;
        private System.Windows.Forms.CheckBox checkBox_volog_norm;
        private System.Windows.Forms.CheckBox checkBox_osu_nothing;
        private System.Windows.Forms.CheckBox checkBox_sezon_spring;
        private System.Windows.Forms.CheckBox checkBox_sezon_summer;
        private System.Windows.Forms.CheckBox checkBox_sezon_autumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_temp_cold;
        private System.Windows.Forms.CheckBox checkBox_temp_hot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_tusk_norm;
        private System.Windows.Forms.CheckBox checkBox_tusk_high;
        private System.Windows.Forms.CheckBox checkBox_tusk_low;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_volog_dry;
        private System.Windows.Forms.CheckBox checkBox_volog_wet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_osu_rain;
        private System.Windows.Forms.CheckBox checkBox_osu_fog;
        private System.Windows.Forms.CheckBox checkBox_osu_snow;
        private System.Windows.Forms.CheckBox checkBox_osu_frost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_sezon_winter;
        private System.Windows.Forms.ToolStripMenuItem таблицяЗаКритеріямиToolStripMenuItem;
        private System.Windows.Forms.Label label10;
    }
}

