namespace KairosBot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel_my_inv = new System.Windows.Forms.Panel();
            this.TablePlayerItems = new System.Windows.Forms.DataGridView();
            this.panel_all_price = new System.Windows.Forms.Panel();
            this.TableAllPrice = new System.Windows.Forms.DataGridView();
            this.button_all_price_update = new System.Windows.Forms.Button();
            this.button_my_inv = new System.Windows.Forms.Button();
            this.button_site_inv = new System.Windows.Forms.Button();
            this.button_trading = new System.Windows.Forms.Button();
            this.TextBoxConsole = new System.Windows.Forms.TextBox();
            this.button_all_price = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_get_absolute = new System.Windows.Forms.Button();
            this.button_access = new System.Windows.Forms.Button();
            this.panel_site_inv = new System.Windows.Forms.Panel();
            this.button_update_site = new System.Windows.Forms.Button();
            this.listBox_sites = new System.Windows.Forms.ListBox();
            this.TableSitesItems = new System.Windows.Forms.DataGridView();
            this.button_sites_update_all = new System.Windows.Forms.Button();
            this.panel_access = new System.Windows.Forms.Panel();
            this.TableAccess = new System.Windows.Forms.DataGridView();
            this.panel_absolute = new System.Windows.Forms.Panel();
            this.groupBox_abs_to = new System.Windows.Forms.GroupBox();
            this.groupBox_abs_from = new System.Windows.Forms.GroupBox();
            this.textBox_abs_res = new System.Windows.Forms.TextBox();
            this.TableAbsolute = new System.Windows.Forms.DataGridView();
            this.button_abs_update = new System.Windows.Forms.Button();
            this.panel_my_inv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePlayerItems)).BeginInit();
            this.panel_all_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAllPrice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_site_inv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSitesItems)).BeginInit();
            this.panel_access.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAccess)).BeginInit();
            this.panel_absolute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAbsolute)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::KairosBot.Properties.Resources.Close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1309, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 45);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel_my_inv
            // 
            this.panel_my_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_my_inv.Controls.Add(this.TablePlayerItems);
            this.panel_my_inv.Controls.Add(this.button1);
            this.panel_my_inv.Location = new System.Drawing.Point(220, 80);
            this.panel_my_inv.Name = "panel_my_inv";
            this.panel_my_inv.Size = new System.Drawing.Size(1134, 510);
            this.panel_my_inv.TabIndex = 2;
            // 
            // TablePlayerItems
            // 
            this.TablePlayerItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablePlayerItems.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablePlayerItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablePlayerItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablePlayerItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablePlayerItems.Location = new System.Drawing.Point(19, 24);
            this.TablePlayerItems.Name = "TablePlayerItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablePlayerItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablePlayerItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TablePlayerItems.Size = new System.Drawing.Size(875, 420);
            this.TablePlayerItems.TabIndex = 1;
            // 
            // panel_all_price
            // 
            this.panel_all_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_all_price.Controls.Add(this.TableAllPrice);
            this.panel_all_price.Controls.Add(this.button_all_price_update);
            this.panel_all_price.Location = new System.Drawing.Point(220, 80);
            this.panel_all_price.Name = "panel_all_price";
            this.panel_all_price.Size = new System.Drawing.Size(1134, 510);
            this.panel_all_price.TabIndex = 3;
            // 
            // TableAllPrice
            // 
            this.TableAllPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.TableAllPrice.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAllPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TableAllPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableAllPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TableAllPrice.Location = new System.Drawing.Point(19, 24);
            this.TableAllPrice.Name = "TableAllPrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAllPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TableAllPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TableAllPrice.Size = new System.Drawing.Size(875, 420);
            this.TableAllPrice.TabIndex = 1;
            // 
            // button_all_price_update
            // 
            this.button_all_price_update.Location = new System.Drawing.Point(924, 24);
            this.button_all_price_update.Name = "button_all_price_update";
            this.button_all_price_update.Size = new System.Drawing.Size(194, 44);
            this.button_all_price_update.TabIndex = 0;
            this.button_all_price_update.Text = "Обновить";
            this.button_all_price_update.UseVisualStyleBackColor = true;
            this.button_all_price_update.Click += new System.EventHandler(this.button_all_price_update_Click);
            // 
            // button_my_inv
            // 
            this.button_my_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_my_inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_my_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_my_inv.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_my_inv.ForeColor = System.Drawing.Color.White;
            this.button_my_inv.Location = new System.Drawing.Point(9, 124);
            this.button_my_inv.Name = "button_my_inv";
            this.button_my_inv.Size = new System.Drawing.Size(180, 60);
            this.button_my_inv.TabIndex = 3;
            this.button_my_inv.Text = "Мій інвентар";
            this.button_my_inv.UseVisualStyleBackColor = false;
            this.button_my_inv.Click += new System.EventHandler(this.button_my_inv_Click);
            // 
            // button_site_inv
            // 
            this.button_site_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_site_inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_site_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_site_inv.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_site_inv.ForeColor = System.Drawing.Color.White;
            this.button_site_inv.Location = new System.Drawing.Point(9, 191);
            this.button_site_inv.Name = "button_site_inv";
            this.button_site_inv.Size = new System.Drawing.Size(180, 60);
            this.button_site_inv.TabIndex = 4;
            this.button_site_inv.Text = "Інвентар сайтів";
            this.button_site_inv.UseVisualStyleBackColor = false;
            this.button_site_inv.Click += new System.EventHandler(this.button_site_inv_Click);
            // 
            // button_trading
            // 
            this.button_trading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_trading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_trading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trading.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_trading.ForeColor = System.Drawing.Color.White;
            this.button_trading.Location = new System.Drawing.Point(9, 410);
            this.button_trading.Name = "button_trading";
            this.button_trading.Size = new System.Drawing.Size(180, 60);
            this.button_trading.TabIndex = 5;
            this.button_trading.Text = "Обміни";
            this.button_trading.UseVisualStyleBackColor = false;
            // 
            // TextBoxConsole
            // 
            this.TextBoxConsole.AcceptsReturn = true;
            this.TextBoxConsole.AcceptsTab = true;
            this.TextBoxConsole.BackColor = System.Drawing.Color.Black;
            this.TextBoxConsole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxConsole.ForeColor = System.Drawing.Color.White;
            this.TextBoxConsole.Location = new System.Drawing.Point(263, 615);
            this.TextBoxConsole.Multiline = true;
            this.TextBoxConsole.Name = "TextBoxConsole";
            this.TextBoxConsole.ReadOnly = true;
            this.TextBoxConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxConsole.Size = new System.Drawing.Size(840, 142);
            this.TextBoxConsole.TabIndex = 6;
            this.TextBoxConsole.Text = ">Kairos\r\nKeep calm and trade on";
            this.TextBoxConsole.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // button_all_price
            // 
            this.button_all_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_all_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_all_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_all_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_all_price.ForeColor = System.Drawing.Color.White;
            this.button_all_price.Location = new System.Drawing.Point(9, 256);
            this.button_all_price.Name = "button_all_price";
            this.button_all_price.Size = new System.Drawing.Size(180, 60);
            this.button_all_price.TabIndex = 7;
            this.button_all_price.Text = "Таблиця цін";
            this.button_all_price.UseVisualStyleBackColor = false;
            this.button_all_price.Click += new System.EventHandler(this.button_all_price_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kairos Display Std Highlight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kairos trade bot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_get_absolute);
            this.panel2.Controls.Add(this.button_access);
            this.panel2.Controls.Add(this.button_my_inv);
            this.panel2.Controls.Add(this.button_site_inv);
            this.panel2.Controls.Add(this.button_all_price);
            this.panel2.Controls.Add(this.button_trading);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(10, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 510);
            this.panel2.TabIndex = 9;
            // 
            // button_get_absolute
            // 
            this.button_get_absolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_get_absolute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_get_absolute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_get_absolute.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_get_absolute.ForeColor = System.Drawing.Color.White;
            this.button_get_absolute.Location = new System.Drawing.Point(9, 322);
            this.button_get_absolute.Name = "button_get_absolute";
            this.button_get_absolute.Size = new System.Drawing.Size(180, 60);
            this.button_get_absolute.TabIndex = 9;
            this.button_get_absolute.Text = "true предмети";
            this.button_get_absolute.UseVisualStyleBackColor = false;
            this.button_get_absolute.Click += new System.EventHandler(this.button_get_absolute_Click);
            // 
            // button_access
            // 
            this.button_access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_access.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_access.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_access.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_access.ForeColor = System.Drawing.Color.White;
            this.button_access.Location = new System.Drawing.Point(9, 11);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(180, 60);
            this.button_access.TabIndex = 8;
            this.button_access.Text = "Доступ";
            this.button_access.UseVisualStyleBackColor = false;
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // panel_site_inv
            // 
            this.panel_site_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_site_inv.Controls.Add(this.button_update_site);
            this.panel_site_inv.Controls.Add(this.listBox_sites);
            this.panel_site_inv.Controls.Add(this.TableSitesItems);
            this.panel_site_inv.Controls.Add(this.button_sites_update_all);
            this.panel_site_inv.Location = new System.Drawing.Point(220, 80);
            this.panel_site_inv.Name = "panel_site_inv";
            this.panel_site_inv.Size = new System.Drawing.Size(1134, 510);
            this.panel_site_inv.TabIndex = 3;
            // 
            // button_update_site
            // 
            this.button_update_site.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update_site.Location = new System.Drawing.Point(924, 125);
            this.button_update_site.Name = "button_update_site";
            this.button_update_site.Size = new System.Drawing.Size(194, 44);
            this.button_update_site.TabIndex = 4;
            this.button_update_site.Text = "Обновити";
            this.button_update_site.UseVisualStyleBackColor = true;
            this.button_update_site.Click += new System.EventHandler(this.button_update_site_Click);
            // 
            // listBox_sites
            // 
            this.listBox_sites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox_sites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_sites.DisplayMember = "1";
            this.listBox_sites.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_sites.ForeColor = System.Drawing.Color.Black;
            this.listBox_sites.FormattingEnabled = true;
            this.listBox_sites.ItemHeight = 20;
            this.listBox_sites.Location = new System.Drawing.Point(924, 175);
            this.listBox_sites.Name = "listBox_sites";
            this.listBox_sites.Size = new System.Drawing.Size(194, 322);
            this.listBox_sites.TabIndex = 3;
            this.listBox_sites.ValueMember = "1";
            this.listBox_sites.SelectedIndexChanged += new System.EventHandler(this.listBox_sites_SelectedIndexChanged);
            // 
            // TableSitesItems
            // 
            this.TableSitesItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableSitesItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSitesItems.Location = new System.Drawing.Point(19, 24);
            this.TableSitesItems.Name = "TableSitesItems";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableSitesItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TableSitesItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TableSitesItems.Size = new System.Drawing.Size(875, 473);
            this.TableSitesItems.TabIndex = 1;
            // 
            // button_sites_update_all
            // 
            this.button_sites_update_all.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sites_update_all.Location = new System.Drawing.Point(924, 24);
            this.button_sites_update_all.Name = "button_sites_update_all";
            this.button_sites_update_all.Size = new System.Drawing.Size(194, 44);
            this.button_sites_update_all.TabIndex = 0;
            this.button_sites_update_all.Text = "Обновити все";
            this.button_sites_update_all.UseVisualStyleBackColor = true;
            this.button_sites_update_all.Click += new System.EventHandler(this.button_sites_update_all_Click);
            // 
            // panel_access
            // 
            this.panel_access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_access.Controls.Add(this.TableAccess);
            this.panel_access.Location = new System.Drawing.Point(220, 80);
            this.panel_access.Name = "panel_access";
            this.panel_access.Size = new System.Drawing.Size(364, 510);
            this.panel_access.TabIndex = 5;
            // 
            // TableAccess
            // 
            this.TableAccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAccess.Location = new System.Drawing.Point(19, 24);
            this.TableAccess.Name = "TableAccess";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAccess.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TableAccess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TableAccess.Size = new System.Drawing.Size(326, 473);
            this.TableAccess.TabIndex = 1;
            this.TableAccess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel_absolute
            // 
            this.panel_absolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_absolute.Controls.Add(this.groupBox_abs_to);
            this.panel_absolute.Controls.Add(this.groupBox_abs_from);
            this.panel_absolute.Controls.Add(this.textBox_abs_res);
            this.panel_absolute.Controls.Add(this.TableAbsolute);
            this.panel_absolute.Controls.Add(this.button_abs_update);
            this.panel_absolute.Location = new System.Drawing.Point(220, 80);
            this.panel_absolute.Name = "panel_absolute";
            this.panel_absolute.Size = new System.Drawing.Size(1134, 510);
            this.panel_absolute.TabIndex = 4;
            // 
            // groupBox_abs_to
            // 
            this.groupBox_abs_to.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_abs_to.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_abs_to.Location = new System.Drawing.Point(910, 24);
            this.groupBox_abs_to.Name = "groupBox_abs_to";
            this.groupBox_abs_to.Size = new System.Drawing.Size(200, 334);
            this.groupBox_abs_to.TabIndex = 6;
            this.groupBox_abs_to.TabStop = false;
            this.groupBox_abs_to.Text = "To";
            // 
            // groupBox_abs_from
            // 
            this.groupBox_abs_from.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_abs_from.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_abs_from.Location = new System.Drawing.Point(683, 24);
            this.groupBox_abs_from.Name = "groupBox_abs_from";
            this.groupBox_abs_from.Size = new System.Drawing.Size(200, 334);
            this.groupBox_abs_from.TabIndex = 5;
            this.groupBox_abs_from.TabStop = false;
            this.groupBox_abs_from.Text = "From";
            // 
            // textBox_abs_res
            // 
            this.textBox_abs_res.Location = new System.Drawing.Point(910, 377);
            this.textBox_abs_res.Multiline = true;
            this.textBox_abs_res.Name = "textBox_abs_res";
            this.textBox_abs_res.Size = new System.Drawing.Size(194, 105);
            this.textBox_abs_res.TabIndex = 2;
            // 
            // TableAbsolute
            // 
            this.TableAbsolute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.TableAbsolute.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAbsolute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TableAbsolute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableAbsolute.DefaultCellStyle = dataGridViewCellStyle10;
            this.TableAbsolute.Location = new System.Drawing.Point(19, 24);
            this.TableAbsolute.Name = "TableAbsolute";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAbsolute.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.TableAbsolute.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TableAbsolute.Size = new System.Drawing.Size(635, 473);
            this.TableAbsolute.TabIndex = 1;
            // 
            // button_abs_update
            // 
            this.button_abs_update.Location = new System.Drawing.Point(689, 411);
            this.button_abs_update.Name = "button_abs_update";
            this.button_abs_update.Size = new System.Drawing.Size(194, 44);
            this.button_abs_update.TabIndex = 0;
            this.button_abs_update.Text = "Обновить";
            this.button_abs_update.UseVisualStyleBackColor = true;
            this.button_abs_update.Click += new System.EventHandler(this.button_abs_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KairosBot.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel_absolute);
            this.Controls.Add(this.panel_all_price);
            this.Controls.Add(this.panel_access);
            this.Controls.Add(this.panel_site_inv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxConsole);
            this.Controls.Add(this.panel_my_inv);
            this.Controls.Add(this.buttonExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_my_inv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePlayerItems)).EndInit();
            this.panel_all_price.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableAllPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_site_inv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableSitesItems)).EndInit();
            this.panel_access.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableAccess)).EndInit();
            this.panel_absolute.ResumeLayout(false);
            this.panel_absolute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAbsolute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel_my_inv;
        private System.Windows.Forms.DataGridView TablePlayerItems;
        private System.Windows.Forms.Button button_my_inv;
        private System.Windows.Forms.Button button_site_inv;
        private System.Windows.Forms.Button button_trading;
        private System.Windows.Forms.Button button_all_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TextBoxConsole;
        private System.Windows.Forms.Panel panel_all_price;
        private System.Windows.Forms.DataGridView TableAllPrice;
        private System.Windows.Forms.Button button_all_price_update;
        private System.Windows.Forms.Panel panel_site_inv;
        private System.Windows.Forms.Button button_sites_update_all;
        private System.Windows.Forms.DataGridView TableSitesItems;
        private System.Windows.Forms.ListBox listBox_sites;
        private System.Windows.Forms.Button button_update_site;
        private System.Windows.Forms.Button button_access;
        private System.Windows.Forms.Panel panel_access;
        private System.Windows.Forms.DataGridView TableAccess;
        private System.Windows.Forms.Button button_get_absolute;
        private System.Windows.Forms.Panel panel_absolute;
        private System.Windows.Forms.DataGridView TableAbsolute;
        private System.Windows.Forms.Button button_abs_update;
        private System.Windows.Forms.TextBox textBox_abs_res;
        private System.Windows.Forms.GroupBox groupBox_abs_from;
        private System.Windows.Forms.GroupBox groupBox_abs_to;
    }
}

