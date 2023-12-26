namespace Tyuiu.MescheryakovPV.Sprint7.V6
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu_MPV = new System.Windows.Forms.Panel();
            this.buttonFrequency_MPV = new System.Windows.Forms.Button();
            this.groupBoxFilter_MPV = new System.Windows.Forms.GroupBox();
            this.buttonReturnDefault_MPV = new System.Windows.Forms.Button();
            this.buttonFilter_MPV = new System.Windows.Forms.Button();
            this.textBoxFilter_MPV = new System.Windows.Forms.TextBox();
            this.groupBoxEnterData_MPV = new System.Windows.Forms.GroupBox();
            this.panelEnterData_MPV = new System.Windows.Forms.Panel();
            this.textBoxPhoneNumber_MPV = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber_MPV = new System.Windows.Forms.Label();
            this.textBoxDoctor_MPV = new System.Windows.Forms.TextBox();
            this.labelDoctor_MPV = new System.Windows.Forms.Label();
            this.textBoxDisease_MPV = new System.Windows.Forms.TextBox();
            this.labelDisease_MPV = new System.Windows.Forms.Label();
            this.textBoxAge_MPV = new System.Windows.Forms.TextBox();
            this.labelAge_MPV = new System.Windows.Forms.Label();
            this.textBoxMName_MPV = new System.Windows.Forms.TextBox();
            this.labelMName_MPV = new System.Windows.Forms.Label();
            this.labelLName_MPV = new System.Windows.Forms.Label();
            this.textBoxLName_MPV = new System.Windows.Forms.TextBox();
            this.labelFName_MPV = new System.Windows.Forms.Label();
            this.textBoxFName_MPV = new System.Windows.Forms.TextBox();
            this.buttonDelete_MPV = new System.Windows.Forms.Button();
            this.buttonAdd_MPV = new System.Windows.Forms.Button();
            this.panelInfo_MPV = new System.Windows.Forms.Panel();
            this.textBoxInfo_MPV = new System.Windows.Forms.TextBox();
            this.dataGridView_MPV = new System.Windows.Forms.DataGridView();
            this.openFileDialog_MPV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MPV = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChangePath_MPV = new System.Windows.Forms.Button();
            this.buttonChange_MPV = new System.Windows.Forms.Button();
            this.buttonInfo_MPV = new System.Windows.Forms.Button();
            this.panelMenu_MPV.SuspendLayout();
            this.groupBoxFilter_MPV.SuspendLayout();
            this.groupBoxEnterData_MPV.SuspendLayout();
            this.panelEnterData_MPV.SuspendLayout();
            this.panelInfo_MPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MPV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu_MPV
            // 
            this.panelMenu_MPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelMenu_MPV.Controls.Add(this.buttonChangePath_MPV);
            this.panelMenu_MPV.Controls.Add(this.buttonChange_MPV);
            this.panelMenu_MPV.Controls.Add(this.buttonInfo_MPV);
            this.panelMenu_MPV.Controls.Add(this.groupBoxFilter_MPV);
            this.panelMenu_MPV.Controls.Add(this.buttonAdd_MPV);
            this.panelMenu_MPV.Controls.Add(this.buttonFrequency_MPV);
            this.panelMenu_MPV.Controls.Add(this.buttonDelete_MPV);
            this.panelMenu_MPV.Controls.Add(this.groupBoxEnterData_MPV);
            this.panelMenu_MPV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_MPV.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu_MPV.Name = "panelMenu_MPV";
            this.panelMenu_MPV.Size = new System.Drawing.Size(484, 1079);
            this.panelMenu_MPV.TabIndex = 0;
            this.panelMenu_MPV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_MPV_Paint);
            // 
            // buttonFrequency_MPV
            // 
            this.buttonFrequency_MPV.Location = new System.Drawing.Point(17, 120);
            this.buttonFrequency_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFrequency_MPV.Name = "buttonFrequency_MPV";
            this.buttonFrequency_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonFrequency_MPV.TabIndex = 8;
            this.buttonFrequency_MPV.Text = "Статистика";
            this.toolTip_MPV.SetToolTip(this.buttonFrequency_MPV, "Выводит статистику данных\r\n");
            this.buttonFrequency_MPV.UseVisualStyleBackColor = true;
            this.buttonFrequency_MPV.Click += new System.EventHandler(this.buttonFrequency_MPV_Click);
            // 
            // groupBoxFilter_MPV
            // 
            this.groupBoxFilter_MPV.Controls.Add(this.buttonReturnDefault_MPV);
            this.groupBoxFilter_MPV.Controls.Add(this.buttonFilter_MPV);
            this.groupBoxFilter_MPV.Controls.Add(this.textBoxFilter_MPV);
            this.groupBoxFilter_MPV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFilter_MPV.Location = new System.Drawing.Point(0, 338);
            this.groupBoxFilter_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxFilter_MPV.Name = "groupBoxFilter_MPV";
            this.groupBoxFilter_MPV.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxFilter_MPV.Size = new System.Drawing.Size(484, 162);
            this.groupBoxFilter_MPV.TabIndex = 6;
            this.groupBoxFilter_MPV.TabStop = false;
            this.groupBoxFilter_MPV.Text = "Фильтрация";
            this.groupBoxFilter_MPV.Enter += new System.EventHandler(this.groupBoxFilter_MPV_Enter);
            // 
            // buttonReturnDefault_MPV
            // 
            this.buttonReturnDefault_MPV.Location = new System.Drawing.Point(168, 87);
            this.buttonReturnDefault_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReturnDefault_MPV.Name = "buttonReturnDefault_MPV";
            this.buttonReturnDefault_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonReturnDefault_MPV.TabIndex = 8;
            this.buttonReturnDefault_MPV.Text = "Вернуть";
            this.toolTip_MPV.SetToolTip(this.buttonReturnDefault_MPV, "Возвращает таблице исходный вид\r\n");
            this.buttonReturnDefault_MPV.UseVisualStyleBackColor = true;
            this.buttonReturnDefault_MPV.Click += new System.EventHandler(this.buttonReturnDefault_MPV_Click);
            // 
            // buttonFilter_MPV
            // 
            this.buttonFilter_MPV.Location = new System.Drawing.Point(6, 87);
            this.buttonFilter_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFilter_MPV.Name = "buttonFilter_MPV";
            this.buttonFilter_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonFilter_MPV.TabIndex = 7;
            this.buttonFilter_MPV.Text = "Применить\r\n";
            this.toolTip_MPV.SetToolTip(this.buttonFilter_MPV, "Применяет фильтрацию к выбранному столбцу\r\n\r\n");
            this.buttonFilter_MPV.UseVisualStyleBackColor = true;
            this.buttonFilter_MPV.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFilter_MPV
            // 
            this.textBoxFilter_MPV.Location = new System.Drawing.Point(12, 37);
            this.textBoxFilter_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFilter_MPV.Name = "textBoxFilter_MPV";
            this.textBoxFilter_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxFilter_MPV.TabIndex = 0;
            this.textBoxFilter_MPV.TextChanged += new System.EventHandler(this.textBoxFilter_MPV_TextChanged);
            // 
            // groupBoxEnterData_MPV
            // 
            this.groupBoxEnterData_MPV.Controls.Add(this.panelEnterData_MPV);
            this.groupBoxEnterData_MPV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxEnterData_MPV.Location = new System.Drawing.Point(0, 500);
            this.groupBoxEnterData_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxEnterData_MPV.Name = "groupBoxEnterData_MPV";
            this.groupBoxEnterData_MPV.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxEnterData_MPV.Size = new System.Drawing.Size(484, 579);
            this.groupBoxEnterData_MPV.TabIndex = 4;
            this.groupBoxEnterData_MPV.TabStop = false;
            this.groupBoxEnterData_MPV.Text = "Данные о пациенте";
            this.groupBoxEnterData_MPV.Enter += new System.EventHandler(this.groupBoxEnterData_MPV_Enter);
            // 
            // panelEnterData_MPV
            // 
            this.panelEnterData_MPV.AutoScroll = true;
            this.panelEnterData_MPV.Controls.Add(this.textBoxPhoneNumber_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelPhoneNumber_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxDoctor_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelDoctor_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxDisease_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelDisease_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxAge_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelAge_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxMName_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelMName_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelLName_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxLName_MPV);
            this.panelEnterData_MPV.Controls.Add(this.labelFName_MPV);
            this.panelEnterData_MPV.Controls.Add(this.textBoxFName_MPV);
            this.panelEnterData_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnterData_MPV.Location = new System.Drawing.Point(6, 30);
            this.panelEnterData_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.panelEnterData_MPV.Name = "panelEnterData_MPV";
            this.panelEnterData_MPV.Size = new System.Drawing.Size(472, 543);
            this.panelEnterData_MPV.TabIndex = 0;
            this.panelEnterData_MPV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEnterData_MPV_Paint);
            // 
            // textBoxPhoneNumber_MPV
            // 
            this.textBoxPhoneNumber_MPV.Location = new System.Drawing.Point(6, 488);
            this.textBoxPhoneNumber_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPhoneNumber_MPV.Name = "textBoxPhoneNumber_MPV";
            this.textBoxPhoneNumber_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxPhoneNumber_MPV.TabIndex = 13;
            this.textBoxPhoneNumber_MPV.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_MPV_TextChanged);
            // 
            // labelPhoneNumber_MPV
            // 
            this.labelPhoneNumber_MPV.AutoSize = true;
            this.labelPhoneNumber_MPV.Location = new System.Drawing.Point(6, 458);
            this.labelPhoneNumber_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhoneNumber_MPV.Name = "labelPhoneNumber_MPV";
            this.labelPhoneNumber_MPV.Size = new System.Drawing.Size(183, 25);
            this.labelPhoneNumber_MPV.TabIndex = 12;
            this.labelPhoneNumber_MPV.Text = "Номер телефона";
            this.labelPhoneNumber_MPV.Click += new System.EventHandler(this.labelPhoneNumber_MPV_Click);
            // 
            // textBoxDoctor_MPV
            // 
            this.textBoxDoctor_MPV.Location = new System.Drawing.Point(6, 413);
            this.textBoxDoctor_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDoctor_MPV.Name = "textBoxDoctor_MPV";
            this.textBoxDoctor_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxDoctor_MPV.TabIndex = 11;
            this.textBoxDoctor_MPV.TextChanged += new System.EventHandler(this.textBoxDoctor_MPV_TextChanged);
            // 
            // labelDoctor_MPV
            // 
            this.labelDoctor_MPV.AutoSize = true;
            this.labelDoctor_MPV.Location = new System.Drawing.Point(6, 383);
            this.labelDoctor_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDoctor_MPV.Name = "labelDoctor_MPV";
            this.labelDoctor_MPV.Size = new System.Drawing.Size(155, 25);
            this.labelDoctor_MPV.TabIndex = 10;
            this.labelDoctor_MPV.Text = "Лечащий врач";
            this.labelDoctor_MPV.Click += new System.EventHandler(this.labelDoctor_MPV_Click);
            // 
            // textBoxDisease_MPV
            // 
            this.textBoxDisease_MPV.Location = new System.Drawing.Point(6, 338);
            this.textBoxDisease_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDisease_MPV.Name = "textBoxDisease_MPV";
            this.textBoxDisease_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxDisease_MPV.TabIndex = 9;
            this.textBoxDisease_MPV.TextChanged += new System.EventHandler(this.textBoxDisease_MPV_TextChanged);
            // 
            // labelDisease_MPV
            // 
            this.labelDisease_MPV.AutoSize = true;
            this.labelDisease_MPV.Location = new System.Drawing.Point(6, 308);
            this.labelDisease_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDisease_MPV.Name = "labelDisease_MPV";
            this.labelDisease_MPV.Size = new System.Drawing.Size(95, 25);
            this.labelDisease_MPV.TabIndex = 8;
            this.labelDisease_MPV.Text = "Диагноз";
            this.labelDisease_MPV.Click += new System.EventHandler(this.labelDisease_MPV_Click);
            // 
            // textBoxAge_MPV
            // 
            this.textBoxAge_MPV.Location = new System.Drawing.Point(6, 263);
            this.textBoxAge_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAge_MPV.Name = "textBoxAge_MPV";
            this.textBoxAge_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxAge_MPV.TabIndex = 7;
            this.textBoxAge_MPV.TextChanged += new System.EventHandler(this.textBoxAge_MPV_TextChanged);
            // 
            // labelAge_MPV
            // 
            this.labelAge_MPV.AutoSize = true;
            this.labelAge_MPV.Location = new System.Drawing.Point(6, 233);
            this.labelAge_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAge_MPV.Name = "labelAge_MPV";
            this.labelAge_MPV.Size = new System.Drawing.Size(94, 25);
            this.labelAge_MPV.TabIndex = 6;
            this.labelAge_MPV.Text = "Возраст";
            this.labelAge_MPV.Click += new System.EventHandler(this.labelAge_MPV_Click);
            // 
            // textBoxMName_MPV
            // 
            this.textBoxMName_MPV.Location = new System.Drawing.Point(6, 188);
            this.textBoxMName_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxMName_MPV.Name = "textBoxMName_MPV";
            this.textBoxMName_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxMName_MPV.TabIndex = 5;
            this.textBoxMName_MPV.TextChanged += new System.EventHandler(this.textBoxMName_MPV_TextChanged);
            // 
            // labelMName_MPV
            // 
            this.labelMName_MPV.AutoSize = true;
            this.labelMName_MPV.Location = new System.Drawing.Point(6, 158);
            this.labelMName_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMName_MPV.Name = "labelMName_MPV";
            this.labelMName_MPV.Size = new System.Drawing.Size(105, 25);
            this.labelMName_MPV.TabIndex = 4;
            this.labelMName_MPV.Text = "Отчество";
            this.labelMName_MPV.Click += new System.EventHandler(this.labelMName_MPV_Click);
            // 
            // labelLName_MPV
            // 
            this.labelLName_MPV.AutoSize = true;
            this.labelLName_MPV.Location = new System.Drawing.Point(6, 83);
            this.labelLName_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLName_MPV.Name = "labelLName_MPV";
            this.labelLName_MPV.Size = new System.Drawing.Size(104, 25);
            this.labelLName_MPV.TabIndex = 3;
            this.labelLName_MPV.Text = "Фамилия";
            this.labelLName_MPV.Click += new System.EventHandler(this.labelLName_MPV_Click);
            // 
            // textBoxLName_MPV
            // 
            this.textBoxLName_MPV.Location = new System.Drawing.Point(6, 113);
            this.textBoxLName_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLName_MPV.Name = "textBoxLName_MPV";
            this.textBoxLName_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxLName_MPV.TabIndex = 2;
            this.textBoxLName_MPV.TextChanged += new System.EventHandler(this.textBoxLName_MPV_TextChanged);
            // 
            // labelFName_MPV
            // 
            this.labelFName_MPV.AutoSize = true;
            this.labelFName_MPV.Location = new System.Drawing.Point(6, 8);
            this.labelFName_MPV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFName_MPV.Name = "labelFName_MPV";
            this.labelFName_MPV.Size = new System.Drawing.Size(53, 25);
            this.labelFName_MPV.TabIndex = 1;
            this.labelFName_MPV.Text = "Имя";
            this.labelFName_MPV.Click += new System.EventHandler(this.labelFName_MPV_Click);
            // 
            // textBoxFName_MPV
            // 
            this.textBoxFName_MPV.Location = new System.Drawing.Point(6, 38);
            this.textBoxFName_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFName_MPV.Name = "textBoxFName_MPV";
            this.textBoxFName_MPV.Size = new System.Drawing.Size(456, 31);
            this.textBoxFName_MPV.TabIndex = 0;
            this.textBoxFName_MPV.TextChanged += new System.EventHandler(this.textBoxFName_MPV_TextChanged);
            // 
            // buttonDelete_MPV
            // 
            this.buttonDelete_MPV.Enabled = false;
            this.buttonDelete_MPV.Location = new System.Drawing.Point(318, 120);
            this.buttonDelete_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete_MPV.Name = "buttonDelete_MPV";
            this.buttonDelete_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonDelete_MPV.TabIndex = 1;
            this.buttonDelete_MPV.Text = "Удалить";
            this.toolTip_MPV.SetToolTip(this.buttonDelete_MPV, "Удаляет выбранную строку с пацентом\r\n");
            this.buttonDelete_MPV.UseVisualStyleBackColor = true;
            this.buttonDelete_MPV.Click += new System.EventHandler(this.buttonDelete_MPV_Click);
            // 
            // buttonAdd_MPV
            // 
            this.buttonAdd_MPV.Location = new System.Drawing.Point(17, 25);
            this.buttonAdd_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd_MPV.Name = "buttonAdd_MPV";
            this.buttonAdd_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonAdd_MPV.TabIndex = 0;
            this.buttonAdd_MPV.Text = "Добавить";
            this.toolTip_MPV.SetToolTip(this.buttonAdd_MPV, "Добавляет строку в CSV файл с данными пациента\r\n");
            this.buttonAdd_MPV.UseVisualStyleBackColor = true;
            this.buttonAdd_MPV.Click += new System.EventHandler(this.buttonAdd_MPV_Click);
            // 
            // panelInfo_MPV
            // 
            this.panelInfo_MPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelInfo_MPV.Controls.Add(this.textBoxInfo_MPV);
            this.panelInfo_MPV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_MPV.Location = new System.Drawing.Point(484, 0);
            this.panelInfo_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.panelInfo_MPV.Name = "panelInfo_MPV";
            this.panelInfo_MPV.Size = new System.Drawing.Size(1590, 77);
            this.panelInfo_MPV.TabIndex = 1;
            this.panelInfo_MPV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_MPV_Paint);
            // 
            // textBoxInfo_MPV
            // 
            this.textBoxInfo_MPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo_MPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo_MPV.Location = new System.Drawing.Point(12, 25);
            this.textBoxInfo_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxInfo_MPV.Name = "textBoxInfo_MPV";
            this.textBoxInfo_MPV.ReadOnly = true;
            this.textBoxInfo_MPV.Size = new System.Drawing.Size(1556, 37);
            this.textBoxInfo_MPV.TabIndex = 0;
            this.textBoxInfo_MPV.TextChanged += new System.EventHandler(this.textBoxInfo_MPV_TextChanged);
            // 
            // dataGridView_MPV
            // 
            this.dataGridView_MPV.AllowUserToAddRows = false;
            this.dataGridView_MPV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_MPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MPV.Location = new System.Drawing.Point(484, 77);
            this.dataGridView_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_MPV.Name = "dataGridView_MPV";
            this.dataGridView_MPV.ReadOnly = true;
            this.dataGridView_MPV.RowHeadersWidth = 82;
            this.dataGridView_MPV.Size = new System.Drawing.Size(1590, 1002);
            this.dataGridView_MPV.TabIndex = 2;
            this.dataGridView_MPV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MPV_CellContentClick);
            this.dataGridView_MPV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MPV_CellEnter);
            // 
            // openFileDialog_MPV
            // 
            this.openFileDialog_MPV.Filter = "Файлы CSV|*.csv";
            this.openFileDialog_MPV.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_MPV_FileOk);
            // 
            // toolTip_MPV
            // 
            this.toolTip_MPV.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_MPV_Popup);
            // 
            // buttonChangePath_MPV
            // 
            this.buttonChangePath_MPV.Location = new System.Drawing.Point(322, 25);
            this.buttonChangePath_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChangePath_MPV.Name = "buttonChangePath_MPV";
            this.buttonChangePath_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonChangePath_MPV.TabIndex = 5;
            this.buttonChangePath_MPV.Text = "Изменить путь";
            this.toolTip_MPV.SetToolTip(this.buttonChangePath_MPV, "Позволяет изменить путь к CSV файлу\r\n");
            this.buttonChangePath_MPV.UseVisualStyleBackColor = true;
            this.buttonChangePath_MPV.Click += new System.EventHandler(this.buttonChangePath_MPV_Click);
            // 
            // buttonChange_MPV
            // 
            this.buttonChange_MPV.Location = new System.Drawing.Point(168, 25);
            this.buttonChange_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChange_MPV.Name = "buttonChange_MPV";
            this.buttonChange_MPV.Size = new System.Drawing.Size(150, 71);
            this.buttonChange_MPV.TabIndex = 7;
            this.buttonChange_MPV.Text = "Изменить";
            this.toolTip_MPV.SetToolTip(this.buttonChange_MPV, "Позволяет изменить данные о пациенте\r\n");
            this.buttonChange_MPV.UseVisualStyleBackColor = true;
            this.buttonChange_MPV.Click += new System.EventHandler(this.buttonChange_MPV_Click);
            // 
            // buttonInfo_MPV
            // 
            this.buttonInfo_MPV.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_MPV.Image")));
            this.buttonInfo_MPV.Location = new System.Drawing.Point(17, 226);
            this.buttonInfo_MPV.Margin = new System.Windows.Forms.Padding(6);
            this.buttonInfo_MPV.Name = "buttonInfo_MPV";
            this.buttonInfo_MPV.Size = new System.Drawing.Size(104, 85);
            this.buttonInfo_MPV.TabIndex = 9;
            this.toolTip_MPV.SetToolTip(this.buttonInfo_MPV, "Информация о программе");
            this.buttonInfo_MPV.UseVisualStyleBackColor = true;
            this.buttonInfo_MPV.Click += new System.EventHandler(this.buttonInfo_MPV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2074, 1079);
            this.Controls.Add(this.dataGridView_MPV);
            this.Controls.Add(this.panelInfo_MPV);
            this.Controls.Add(this.panelMenu_MPV);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2100, 1150);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База Данных Поликлинники";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu_MPV.ResumeLayout(false);
            this.groupBoxFilter_MPV.ResumeLayout(false);
            this.groupBoxFilter_MPV.PerformLayout();
            this.groupBoxEnterData_MPV.ResumeLayout(false);
            this.panelEnterData_MPV.ResumeLayout(false);
            this.panelEnterData_MPV.PerformLayout();
            this.panelInfo_MPV.ResumeLayout(false);
            this.panelInfo_MPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MPV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu_MPV;
        private System.Windows.Forms.Button buttonDelete_MPV;
        private System.Windows.Forms.Button buttonAdd_MPV;
        private System.Windows.Forms.GroupBox groupBoxEnterData_MPV;
        private System.Windows.Forms.Panel panelEnterData_MPV;
        private System.Windows.Forms.TextBox textBoxDoctor_MPV;
        private System.Windows.Forms.Label labelDoctor_MPV;
        private System.Windows.Forms.TextBox textBoxDisease_MPV;
        private System.Windows.Forms.Label labelDisease_MPV;
        private System.Windows.Forms.TextBox textBoxAge_MPV;
        private System.Windows.Forms.Label labelAge_MPV;
        private System.Windows.Forms.TextBox textBoxMName_MPV;
        private System.Windows.Forms.Label labelMName_MPV;
        private System.Windows.Forms.Label labelLName_MPV;
        private System.Windows.Forms.TextBox textBoxLName_MPV;
        private System.Windows.Forms.Label labelFName_MPV;
        private System.Windows.Forms.TextBox textBoxFName_MPV;
        private System.Windows.Forms.TextBox textBoxPhoneNumber_MPV;
        private System.Windows.Forms.Label labelPhoneNumber_MPV;
        private System.Windows.Forms.Panel panelInfo_MPV;
        private System.Windows.Forms.DataGridView dataGridView_MPV;
        private System.Windows.Forms.TextBox textBoxInfo_MPV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MPV;
        private System.Windows.Forms.ToolTip toolTip_MPV;
        private System.Windows.Forms.GroupBox groupBoxFilter_MPV;
        private System.Windows.Forms.Button buttonFilter_MPV;
        private System.Windows.Forms.TextBox textBoxFilter_MPV;
        private System.Windows.Forms.Button buttonReturnDefault_MPV;
        private System.Windows.Forms.Button buttonFrequency_MPV;
        private System.Windows.Forms.Button buttonInfo_MPV;
        private System.Windows.Forms.Button buttonChangePath_MPV;
        private System.Windows.Forms.Button buttonChange_MPV;
    }
}
