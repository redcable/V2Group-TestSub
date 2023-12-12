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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PointsGridView = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcordTxtBox = new System.Windows.Forms.TextBox();
            this.YcordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnserLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX2.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(6, 9);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series21.Name = "Node";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.MarkerSize = 0;
            series22.Name = "Line";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series23.Name = "CheckingPoint";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series24.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series24.MarkerSize = 10;
            series24.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series24.Name = "SelectedPoint";
            series24.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(420, 379);
            this.chart1.TabIndex = 0;
            // 
            // PointsGridView
            // 
            this.PointsGridView.AllowUserToAddRows = false;
            this.PointsGridView.AllowUserToDeleteRows = false;
            this.PointsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.PointsGridView.Location = new System.Drawing.Point(0, 27);
            this.PointsGridView.Name = "PointsGridView";
            this.PointsGridView.RowHeadersVisible = false;
            this.PointsGridView.Size = new System.Drawing.Size(166, 377);
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
            this.XcordTxtBox.Location = new System.Drawing.Point(58, 390);
            this.XcordTxtBox.Name = "XcordTxtBox";
            this.XcordTxtBox.Size = new System.Drawing.Size(75, 20);
            this.XcordTxtBox.TabIndex = 4;
            this.XcordTxtBox.TextChanged += new System.EventHandler(this.CheckingPointCords_TextChanged);
            // 
            // YcordTxtBox
            // 
            this.YcordTxtBox.Location = new System.Drawing.Point(151, 390);
            this.YcordTxtBox.Name = "YcordTxtBox";
            this.YcordTxtBox.Size = new System.Drawing.Size(75, 20);
            this.YcordTxtBox.TabIndex = 4;
            this.YcordTxtBox.TextChanged += new System.EventHandler(this.CheckingPointCords_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Точка x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(129, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = ", y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(250, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "входит в многоугольник!";
            // 
            // AnserLabel
            // 
            this.AnserLabel.AutoSize = true;
            this.AnserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnserLabel.ForeColor = System.Drawing.Color.Red;
            this.AnserLabel.Location = new System.Drawing.Point(226, 393);
            this.AnserLabel.Name = "AnserLabel";
            this.AnserLabel.Size = new System.Drawing.Size(27, 17);
            this.AnserLabel.TabIndex = 5;
            this.AnserLabel.Text = "НЕ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YcordTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.XcordTxtBox);
            this.groupBox1.Controls.Add(this.AnserLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(172, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 416);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(0, 410);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(32, 32);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.RemRowBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(38, 410);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(32, 32);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownBtn.Image")));
            this.MoveDownBtn.Location = new System.Drawing.Point(96, 410);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(32, 32);
            this.MoveDownBtn.TabIndex = 7;
            this.MoveDownBtn.UseVisualStyleBackColor = true;
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpBtn.Image")));
            this.MoveUpBtn.Location = new System.Drawing.Point(134, 410);
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
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
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
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйToolStripMenuItem.Text = "Очистить";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.SquarePresertLoadbtn_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.TringlePresetLoadBtn_Click);
            // 
            // песочныеЧасыToolStripMenuItem
            // 
            this.песочныеЧасыToolStripMenuItem.Name = "песочныеЧасыToolStripMenuItem";
            this.песочныеЧасыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 444);
            this.Controls.Add(this.MoveUpBtn);
            this.Controls.Add(this.MoveDownBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PointsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Точка в многоугольнке";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView PointsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox XcordTxtBox;
        private System.Windows.Forms.TextBox YcordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AnserLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
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
    }
}

