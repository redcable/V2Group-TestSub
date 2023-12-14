namespace V2Group_TestSub
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PointsGridView = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcordTxtBox = new System.Windows.Forms.TextBox();
            this.YcordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.MoveDownBtn = new System.Windows.Forms.Button();
            this.MoveUpBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фмгураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тутБудетЧтонибудьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обещаюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пресетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.песочныеЧасыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PointsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PointsGridView
            // 
            this.PointsGridView.AllowUserToAddRows = false;
            this.PointsGridView.AllowUserToDeleteRows = false;
            this.PointsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.PointsGridView.Location = new System.Drawing.Point(587, 122);
            this.PointsGridView.Name = "PointsGridView";
            this.PointsGridView.RowHeadersVisible = false;
            this.PointsGridView.Size = new System.Drawing.Size(166, 370);
            this.PointsGridView.TabIndex = 1;
            this.PointsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PointsGridView_CellValueChanged);
            this.PointsGridView.CurrentCellChanged += new System.EventHandler(this.PointsGridView_CurrentCellChanged);
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x.HeaderText = "X ";
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // y
            // 
            this.y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            this.y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // XcordTxtBox
            // 
            this.XcordTxtBox.Location = new System.Drawing.Point(27, 18);
            this.XcordTxtBox.Name = "XcordTxtBox";
            this.XcordTxtBox.ReadOnly = true;
            this.XcordTxtBox.Size = new System.Drawing.Size(75, 23);
            this.XcordTxtBox.TabIndex = 4;
            // 
            // YcordTxtBox
            // 
            this.YcordTxtBox.Location = new System.Drawing.Point(27, 44);
            this.YcordTxtBox.Name = "YcordTxtBox";
            this.YcordTxtBox.ReadOnly = true;
            this.YcordTxtBox.Size = new System.Drawing.Size(75, 23);
            this.YcordTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(657, 498);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(32, 32);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.RemRowBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownBtn.Image")));
            this.MoveDownBtn.Location = new System.Drawing.Point(619, 498);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(32, 32);
            this.MoveDownBtn.TabIndex = 7;
            this.MoveDownBtn.UseVisualStyleBackColor = true;
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpBtn.Image")));
            this.MoveUpBtn.Location = new System.Drawing.Point(695, 498);
            this.MoveUpBtn.Name = "MoveUpBtn";
            this.MoveUpBtn.Size = new System.Drawing.Size(32, 32);
            this.MoveUpBtn.TabIndex = 7;
            this.MoveUpBtn.UseVisualStyleBackColor = true;
            this.MoveUpBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фмгураToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.пресетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фмгураToolStripMenuItem
            // 
            this.фмгураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.фмгураToolStripMenuItem.Name = "фмгураToolStripMenuItem";
            this.фмгураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фмгураToolStripMenuItem.Text = "Фигура";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.новыйToolStripMenuItem.Text = "Очистить";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тутБудетЧтонибудьToolStripMenuItem,
            this.обещаюToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // тутБудетЧтонибудьToolStripMenuItem
            // 
            this.тутБудетЧтонибудьToolStripMenuItem.Name = "тутБудетЧтонибудьToolStripMenuItem";
            this.тутБудетЧтонибудьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.тутБудетЧтонибудьToolStripMenuItem.Text = "Тут будет что-нибудь";
            // 
            // обещаюToolStripMenuItem
            // 
            this.обещаюToolStripMenuItem.Name = "обещаюToolStripMenuItem";
            this.обещаюToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.обещаюToolStripMenuItem.Text = "Наверно";
            // 
            // пресетыToolStripMenuItem
            // 
            this.пресетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.треугольникToolStripMenuItem,
            this.песочныеЧасыToolStripMenuItem});
            this.пресетыToolStripMenuItem.Name = "пресетыToolStripMenuItem";
            this.пресетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.пресетыToolStripMenuItem.Text = "Пресеты";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.SquarePresertLoadbtn_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.TringlePresetLoadBtn_Click);
            // 
            // песочныеЧасыToolStripMenuItem
            // 
            this.песочныеЧасыToolStripMenuItem.Name = "песочныеЧасыToolStripMenuItem";
            this.песочныеЧасыToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.песочныеЧасыToolStripMenuItem.Text = "Песочные часы";
            this.песочныеЧасыToolStripMenuItem.Click += new System.EventHandler(this.HourglassPresetLoadBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.FileName = "Figure";
            this.saveFileDialog1.Filter = "Json files|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files|*.json";
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPanel.Location = new System.Drawing.Point(0, 27);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(581, 503);
            this.DrawPanel.TabIndex = 9;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.XcordTxtBox);
            this.groupBox1.Controls.Add(this.YcordTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(587, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты точки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(600, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вершины фигуры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.MoveUpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MoveDownBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PointsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Точка в многоугольнке";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressHandler);
            ((System.ComponentModel.ISupportInitialize)(this.PointsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PointsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox XcordTxtBox;
        private System.Windows.Forms.TextBox YcordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button MoveDownBtn;
        private System.Windows.Forms.Button MoveUpBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фмгураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пресетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem песочныеЧасыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тутБудетЧтонибудьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обещаюToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

