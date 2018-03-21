namespace DataBz
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Год = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Автор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.История = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Картинка = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Улица = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radBtnCityUpd = new System.Windows.Forms.RadioButton();
            this.radBtnSighUpd = new System.Windows.Forms.RadioButton();
            this.radBtnStreUpd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxHisUp = new System.Windows.Forms.TextBox();
            this.txtBoxAutUp = new System.Windows.Forms.TextBox();
            this.txtBoxYearUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNmaeUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateIn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radBtnCitDel = new System.Windows.Forms.RadioButton();
            this.radBtnSighDel = new System.Windows.Forms.RadioButton();
            this.radBtnStreeDel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxIDDel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelet = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxPhoto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxStree = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxHis = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.txtBoxYer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radBtnCit = new System.Windows.Forms.RadioButton();
            this.radBtnSig = new System.Windows.Forms.RadioButton();
            this.radBtnStreet = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Год,
            this.Автор,
            this.История,
            this.Картинка,
            this.Улица});
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id Памятника";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название Памятника";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Год
            // 
            this.Год.HeaderText = "Год";
            this.Год.Name = "Год";
            this.Год.ReadOnly = true;
            // 
            // Автор
            // 
            this.Автор.HeaderText = "Автор";
            this.Автор.Name = "Автор";
            this.Автор.ReadOnly = true;
            // 
            // История
            // 
            this.История.HeaderText = "История";
            this.История.Name = "История";
            this.История.ReadOnly = true;
            // 
            // Картинка
            // 
            this.Картинка.HeaderText = "Фото";
            this.Картинка.Name = "Картинка";
            this.Картинка.ReadOnly = true;
            this.Картинка.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Улица
            // 
            this.Улица.HeaderText = "Улица";
            this.Улица.Name = "Улица";
            this.Улица.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataBase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btnUpdateIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radBtnCityUpd);
            this.groupBox5.Controls.Add(this.radBtnSighUpd);
            this.groupBox5.Controls.Add(this.radBtnStreUpd);
            this.groupBox5.Location = new System.Drawing.Point(28, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 56);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выберите Таблицу";
            // 
            // radBtnCityUpd
            // 
            this.radBtnCityUpd.AutoSize = true;
            this.radBtnCityUpd.Location = new System.Drawing.Point(132, 24);
            this.radBtnCityUpd.Name = "radBtnCityUpd";
            this.radBtnCityUpd.Size = new System.Drawing.Size(42, 17);
            this.radBtnCityUpd.TabIndex = 10;
            this.radBtnCityUpd.TabStop = true;
            this.radBtnCityUpd.Text = "City";
            this.radBtnCityUpd.UseVisualStyleBackColor = true;
            this.radBtnCityUpd.CheckedChanged += new System.EventHandler(this.radBtnCityUpd_CheckedChanged);
            // 
            // radBtnSighUpd
            // 
            this.radBtnSighUpd.AutoSize = true;
            this.radBtnSighUpd.Location = new System.Drawing.Point(10, 24);
            this.radBtnSighUpd.Name = "radBtnSighUpd";
            this.radBtnSighUpd.Size = new System.Drawing.Size(54, 17);
            this.radBtnSighUpd.TabIndex = 7;
            this.radBtnSighUpd.TabStop = true;
            this.radBtnSighUpd.Text = "Sights";
            this.radBtnSighUpd.UseVisualStyleBackColor = true;
            this.radBtnSighUpd.CheckedChanged += new System.EventHandler(this.radBtnSighUpd_CheckedChanged);
            // 
            // radBtnStreUpd
            // 
            this.radBtnStreUpd.AutoSize = true;
            this.radBtnStreUpd.Location = new System.Drawing.Point(73, 24);
            this.radBtnStreUpd.Name = "radBtnStreUpd";
            this.radBtnStreUpd.Size = new System.Drawing.Size(53, 17);
            this.radBtnStreUpd.TabIndex = 8;
            this.radBtnStreUpd.TabStop = true;
            this.radBtnStreUpd.Text = "Street";
            this.radBtnStreUpd.UseVisualStyleBackColor = true;
            this.radBtnStreUpd.CheckedChanged += new System.EventHandler(this.radBtnStreUpd_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxHisUp);
            this.groupBox2.Controls.Add(this.txtBoxAutUp);
            this.groupBox2.Controls.Add(this.txtBoxYearUp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxNmaeUp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 229);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обновление";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(256, 54);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(285, 20);
            this.txtBoxID.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Год:";
            // 
            // txtBoxHisUp
            // 
            this.txtBoxHisUp.Location = new System.Drawing.Point(256, 191);
            this.txtBoxHisUp.Name = "txtBoxHisUp";
            this.txtBoxHisUp.Size = new System.Drawing.Size(279, 20);
            this.txtBoxHisUp.TabIndex = 15;
            // 
            // txtBoxAutUp
            // 
            this.txtBoxAutUp.Location = new System.Drawing.Point(256, 158);
            this.txtBoxAutUp.Name = "txtBoxAutUp";
            this.txtBoxAutUp.Size = new System.Drawing.Size(279, 20);
            this.txtBoxAutUp.TabIndex = 14;
            // 
            // txtBoxYearUp
            // 
            this.txtBoxYearUp.Location = new System.Drawing.Point(256, 125);
            this.txtBoxYearUp.Name = "txtBoxYearUp";
            this.txtBoxYearUp.Size = new System.Drawing.Size(279, 20);
            this.txtBoxYearUp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Автор:";
            // 
            // txtBoxNmaeUp
            // 
            this.txtBoxNmaeUp.Location = new System.Drawing.Point(256, 88);
            this.txtBoxNmaeUp.Name = "txtBoxNmaeUp";
            this.txtBoxNmaeUp.Size = new System.Drawing.Size(279, 20);
            this.txtBoxNmaeUp.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "История:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Название Памятника:";
            // 
            // btnUpdateIn
            // 
            this.btnUpdateIn.Location = new System.Drawing.Point(477, 265);
            this.btnUpdateIn.Name = "btnUpdateIn";
            this.btnUpdateIn.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateIn.TabIndex = 17;
            this.btnUpdateIn.Text = "Обновить";
            this.btnUpdateIn.UseVisualStyleBackColor = true;
            this.btnUpdateIn.Click += new System.EventHandler(this.btnUpdateIn_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(757, 347);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radBtnCitDel);
            this.groupBox6.Controls.Add(this.radBtnSighDel);
            this.groupBox6.Controls.Add(this.radBtnStreeDel);
            this.groupBox6.Location = new System.Drawing.Point(38, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 56);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выберите Таблицу";
            // 
            // radBtnCitDel
            // 
            this.radBtnCitDel.AutoSize = true;
            this.radBtnCitDel.Location = new System.Drawing.Point(132, 24);
            this.radBtnCitDel.Name = "radBtnCitDel";
            this.radBtnCitDel.Size = new System.Drawing.Size(42, 17);
            this.radBtnCitDel.TabIndex = 10;
            this.radBtnCitDel.TabStop = true;
            this.radBtnCitDel.Text = "City";
            this.radBtnCitDel.UseVisualStyleBackColor = true;
            // 
            // radBtnSighDel
            // 
            this.radBtnSighDel.AutoSize = true;
            this.radBtnSighDel.Location = new System.Drawing.Point(10, 24);
            this.radBtnSighDel.Name = "radBtnSighDel";
            this.radBtnSighDel.Size = new System.Drawing.Size(54, 17);
            this.radBtnSighDel.TabIndex = 7;
            this.radBtnSighDel.TabStop = true;
            this.radBtnSighDel.Text = "Sights";
            this.radBtnSighDel.UseVisualStyleBackColor = true;
            // 
            // radBtnStreeDel
            // 
            this.radBtnStreeDel.AutoSize = true;
            this.radBtnStreeDel.Location = new System.Drawing.Point(73, 24);
            this.radBtnStreeDel.Name = "radBtnStreeDel";
            this.radBtnStreeDel.Size = new System.Drawing.Size(53, 17);
            this.radBtnStreeDel.TabIndex = 8;
            this.radBtnStreeDel.TabStop = true;
            this.radBtnStreeDel.Text = "Street";
            this.radBtnStreeDel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxIDDel);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnDelet);
            this.groupBox3.Location = new System.Drawing.Point(22, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 229);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление";
            // 
            // txtBoxIDDel
            // 
            this.txtBoxIDDel.Location = new System.Drawing.Point(82, 39);
            this.txtBoxIDDel.Name = "txtBoxIDDel";
            this.txtBoxIDDel.Size = new System.Drawing.Size(264, 20);
            this.txtBoxIDDel.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "ID:";
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(271, 81);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 23);
            this.btnDelet.TabIndex = 26;
            this.btnDelet.Text = "Удалить";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавть";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBoxPhoto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxStree);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxHis);
            this.groupBox1.Controls.Add(this.txtBoxAutor);
            this.groupBox1.Controls.Add(this.txtBoxYer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 223);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового элемента";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Фото";
            // 
            // txtBoxPhoto
            // 
            this.txtBoxPhoto.Location = new System.Drawing.Point(195, 189);
            this.txtBoxPhoto.Name = "txtBoxPhoto";
            this.txtBoxPhoto.Size = new System.Drawing.Size(279, 20);
            this.txtBoxPhoto.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "id Улицы";
            // 
            // txtBoxStree
            // 
            this.txtBoxStree.Location = new System.Drawing.Point(195, 156);
            this.txtBoxStree.Name = "txtBoxStree";
            this.txtBoxStree.Size = new System.Drawing.Size(279, 20);
            this.txtBoxStree.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(503, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // txtBoxHis
            // 
            this.txtBoxHis.Location = new System.Drawing.Point(195, 131);
            this.txtBoxHis.Name = "txtBoxHis";
            this.txtBoxHis.Size = new System.Drawing.Size(279, 20);
            this.txtBoxHis.TabIndex = 8;
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Location = new System.Drawing.Point(195, 98);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(279, 20);
            this.txtBoxAutor.TabIndex = 7;
            // 
            // txtBoxYer
            // 
            this.txtBoxYer.Location = new System.Drawing.Point(195, 65);
            this.txtBoxYer.Name = "txtBoxYer";
            this.txtBoxYer.Size = new System.Drawing.Size(279, 20);
            this.txtBoxYer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(195, 28);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(279, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "История:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название Памятника:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radBtnCit);
            this.groupBox4.Controls.Add(this.radBtnSig);
            this.groupBox4.Controls.Add(this.radBtnStreet);
            this.groupBox4.Location = new System.Drawing.Point(21, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 56);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите Таблицу";
            // 
            // radBtnCit
            // 
            this.radBtnCit.AutoSize = true;
            this.radBtnCit.Location = new System.Drawing.Point(132, 24);
            this.radBtnCit.Name = "radBtnCit";
            this.radBtnCit.Size = new System.Drawing.Size(42, 17);
            this.radBtnCit.TabIndex = 10;
            this.radBtnCit.TabStop = true;
            this.radBtnCit.Text = "City";
            this.radBtnCit.UseVisualStyleBackColor = true;
            this.radBtnCit.CheckedChanged += new System.EventHandler(this.radBtnCit_CheckedChanged);
            // 
            // radBtnSig
            // 
            this.radBtnSig.AutoSize = true;
            this.radBtnSig.Location = new System.Drawing.Point(10, 24);
            this.radBtnSig.Name = "radBtnSig";
            this.radBtnSig.Size = new System.Drawing.Size(54, 17);
            this.radBtnSig.TabIndex = 7;
            this.radBtnSig.TabStop = true;
            this.radBtnSig.Text = "Sights";
            this.radBtnSig.UseVisualStyleBackColor = true;
            this.radBtnSig.CheckedChanged += new System.EventHandler(this.radBtnSig_CheckedChanged);
            // 
            // radBtnStreet
            // 
            this.radBtnStreet.AutoSize = true;
            this.radBtnStreet.Location = new System.Drawing.Point(73, 24);
            this.radBtnStreet.Name = "radBtnStreet";
            this.radBtnStreet.Size = new System.Drawing.Size(53, 17);
            this.radBtnStreet.TabIndex = 8;
            this.radBtnStreet.TabStop = true;
            this.radBtnStreet.Text = "Street";
            this.radBtnStreet.UseVisualStyleBackColor = true;
            this.radBtnStreet.CheckedChanged += new System.EventHandler(this.radBtnStreet_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыБазыДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыБазыДанныхToolStripMenuItem
            // 
            this.таблицыБазыДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sightsToolStripMenuItem,
            this.streetToolStripMenuItem,
            this.cityToolStripMenuItem});
            this.таблицыБазыДанныхToolStripMenuItem.Name = "таблицыБазыДанныхToolStripMenuItem";
            this.таблицыБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.таблицыБазыДанныхToolStripMenuItem.Text = "Таблицы базы данных";
            // 
            // sightsToolStripMenuItem
            // 
            this.sightsToolStripMenuItem.Name = "sightsToolStripMenuItem";
            this.sightsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sightsToolStripMenuItem.Text = "Sights";
            this.sightsToolStripMenuItem.Click += new System.EventHandler(this.sightsToolStripMenuItem_Click);
            // 
            // streetToolStripMenuItem
            // 
            this.streetToolStripMenuItem.Name = "streetToolStripMenuItem";
            this.streetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streetToolStripMenuItem.Text = "Street";
            this.streetToolStripMenuItem.Click += new System.EventHandler(this.streetToolStripMenuItem_Click_1);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 373);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxHis;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxYer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdateIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxHisUp;
        private System.Windows.Forms.TextBox txtBoxAutUp;
        private System.Windows.Forms.TextBox txtBoxYearUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNmaeUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxIDDel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.RadioButton radBtnStreet;
        private System.Windows.Forms.RadioButton radBtnSig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radBtnCit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radBtnCityUpd;
        private System.Windows.Forms.RadioButton radBtnSighUpd;
        private System.Windows.Forms.RadioButton radBtnStreUpd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radBtnCitDel;
        private System.Windows.Forms.RadioButton radBtnSighDel;
        private System.Windows.Forms.RadioButton radBtnStreeDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxStree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год;
        private System.Windows.Forms.DataGridViewTextBoxColumn Автор;
        private System.Windows.Forms.DataGridViewTextBoxColumn История;
        private System.Windows.Forms.DataGridViewButtonColumn Картинка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Улица;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
    }
}

