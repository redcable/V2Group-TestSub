using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using static V2Group_TestSub.Polygon;

namespace V2Group_TestSub
{
    public partial class MainForm : Form
    {
        //event called when checking point changed
        public delegate void PointChangesHandler();
        public event PointChangesHandler PointChanged;

        //event called when selected row chahged 
        public delegate void CurrentPointChangesHandler();
        public event CurrentPointChangesHandler CurrentPointChanged;

        // Figure model
        Polygon polygon = new Polygon();

        //Place to store point coordinates, that user wants to check
        Node checkingPoint = new Node();

        int prewXSize;
        int prewYSize;

        public MainForm()
        {
            InitializeComponent();

            prewXSize = Size.Width;
            prewYSize = Size.Height;

            //Update datagrid and chart on changes in figure object
            polygon.PolygonChanged += DataGridUpdate;
            polygon.PolygonChanged += DrawPanel.Invalidate;

            //Update chart on changes checking point coordinates
            PointChanged += DrawPanel.Invalidate;
            PointChanged += PointInputupdate;

            //update chart when selected row changes
            polygon.CurrentNodeChanged += DrawPanel.Invalidate;
        }


        private void DataGridUpdate()
        {
            var points = polygon.GetNodes();

            int currentNode = polygon.CurrentNode;

            PointsGridView.CancelEdit();
            PointsGridView.Rows.Clear();

            foreach (var point in points)
            {
                PointsGridView.Rows.Add(point.x, point.y);
            }

            PointsGridView.ClearSelection();

            if (currentNode < PointsGridView.Rows.Count)
            {
                PointsGridView.Rows[currentNode].Selected = true;
            }
        }

        private void PointInputupdate()
        {
            XcordTxtBox.Text = checkingPoint.x.ToString();
            YcordTxtBox.Text = checkingPoint.y.ToString();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            // Get fresh array of points
            var points = polygon.Convert();
            int currentNode = polygon.CurrentNode;

            if (points.Length > 0)
            {
                // Some stuff to draw thigs with
                Pen edgePen = new Pen(Color.Black);
                Brush dotBrush = new SolidBrush(Color.LightGray);
                Brush selectedBrush = new SolidBrush(Color.Orange);

                Size dotSize = new Size(7, 7);
                Size selectedDotSize = new Size(10, 10);

                Brush inDotBrush = new SolidBrush(Color.Green);
                Brush outDotBrush = new SolidBrush(Color.Red);

                var g = e.Graphics;


                // Clear prew paint
                g.Clear(Color.White);


                // Drow figure edges
                if (points.Length > 1)
                {
                    g.DrawPolygon(edgePen, points);
                }


                // Drow figure nodes
                for (int i = 0; i < points.Length; i++)
                {
                    var point = points[i];

                    point.X = point.X - dotSize.Width / 2;
                    point.Y = point.Y - dotSize.Height / 2;

                    if (i == currentNode)
                    {
                        g.FillEllipse(selectedBrush, new Rectangle(point, selectedDotSize));
                    }
                    else
                    {
                        g.FillEllipse(dotBrush, new Rectangle(point, dotSize));
                    }
                }


                //Drow checking point
                bool result = polygon.PointEntryCheck(checkingPoint);

                var p = checkingPoint.Convert();

                int x = p.X - dotSize.Width / 2;
                int y = p.Y - dotSize.Height / 2;

                var node = new Rectangle(new System.Drawing.Point(x, y), dotSize);

                if (result)
                {
                    g.FillEllipse(inDotBrush, node);
                }
                else
                {
                    g.FillEllipse(outDotBrush, node);
                }
            }
        }

        private void PointsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (PointsGridView.CurrentRow != null)
            {
                var currentRow = PointsGridView.CurrentRow;

                int.TryParse(currentRow.Cells[0].Value.ToString(), out int x);
                int.TryParse(currentRow.Cells[1].Value.ToString(), out int y);

                polygon.CurrentNode = currentRow.Index;

                polygon.UpdateNode(x, y);
            }
        }

        private void RemNodeBtn_Click(object sender, EventArgs e)
        {

            polygon.RemoveNode();

        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            polygon.MoveNodeDown();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            polygon.MoveNodeUp();            
        }

        // save and load buttons handlers
        private void SaveBtn_Click(Object sender, EventArgs e)
        {
            ShowSaveDialog();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog(this);

            if (dialogResult != DialogResult.Cancel)
            {
                string fileString = openFileDialog1.FileName;

                string text = File.ReadAllText(fileString);

                try
                {
                    polygon.DeserializeFromJson(text);
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке многоугольника");
                }
            }
        }


        // Clear button handler
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            polygon.ClearNodes();
        }

        // Shows saving question dialog
        public void ShowSaveDialog()
        {
            var result = MessageBox.Show(
                "Хотите сохранить многоугольник?",
                "Сохранение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string saveString = polygon.SerializeToJson();

                if (!string.IsNullOrEmpty(saveString))
                {
                    var dialogResult = saveFileDialog1.ShowDialog(this);

                    if (dialogResult != DialogResult.Cancel)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, saveString);
                    }
                }
            }
        }


        private void PointsGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (PointsGridView.SelectedCells.Count > 0)
            {
                polygon.CurrentNode = PointsGridView.SelectedCells[0].RowIndex;
            }
        }


        // Presets loading buttons handler
        private void SquarePresertLoadbtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            polygon.LoadSquerePreset();
        }

        private void TringlePresetLoadBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            polygon.LoadTringlePreset();
        }

        private void HourglassPresetLoadBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            polygon.LoadHourglassPreset();
        }



        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (Control.ModifierKeys)
            {
                case Keys.Shift:

                    checkingPoint = new Node(e.X, e.Y);

                    PointChanged?.Invoke();

                    break;

                case Keys.Control:

                    polygon.UpdateNode(e.X, e.Y);

                    break;

                case Keys.None:

                    polygon.AddNode(new Node(e.X, e.Y));

                    break;
            }
        }

        private void KeyPressHandler(object sender, KeyEventArgs e)
        {
            int currentNode = polygon.CurrentNode;

            switch (e.KeyCode)
            {
                case Keys.Up:

                    polygon.NextNode();

                    break;

                case Keys.Down:
                   
                    polygon.PrevNode();

                    break;

                case Keys.Delete:

                    polygon.RemoveNode();

                    break;
            }

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            double xScale = (double)Size.Width / prewXSize;
            double yScale = (double)Size.Height / prewYSize;

            checkingPoint.x = (int)(checkingPoint.x * xScale);
            checkingPoint.y = (int)(checkingPoint.y * yScale);

            prewXSize = Size.Width;
            prewYSize = Size.Height;

            polygon.ScalePolygon(xScale, yScale);
        }
    }
}