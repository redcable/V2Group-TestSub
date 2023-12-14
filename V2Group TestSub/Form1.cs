using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static V2Group_TestSub.Figure;

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
        Figure figure = new Figure();

        //Place to store point coordinates, that user wants to check
        Figure.Point checkingPoint = new Figure.Point();

        //var saves point id that should be selected after some actions
        int selectedPoint = 0;

        public MainForm()
        {
            InitializeComponent();

            //Update datagrid and chart on changes in figure object
            figure.FigureChanged += DataGridUpdate;
            figure.FigureChanged += DrawPanel.Invalidate;

            //Update chart on changes checking point coordinates
            PointChanged += DrawPanel.Invalidate;
            PointChanged += PointInputupdate;

            //update chart when selected row changes
            CurrentPointChanged += DrawPanel.Invalidate;
        }


        private void DataGridUpdate()
        {
            var points = figure.GetPoints();

            PointsGridView.CancelEdit();
            PointsGridView.Rows.Clear();

            foreach (var point in points)
            {
                PointsGridView.Rows.Add(point.x, point.y);
            }

            PointsGridView.ClearSelection();

            if (selectedPoint < PointsGridView.Rows.Count)
            {
                PointsGridView.Rows[selectedPoint].Selected = true;
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
            var points = figure.GetDrawingPoints();

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

                    if (i == selectedPoint)
                    {
                        g.FillEllipse(selectedBrush, new Rectangle(point, selectedDotSize));
                    }
                    else
                    {
                        g.FillEllipse(dotBrush, new Rectangle(point, dotSize));
                    }
                }


                //Drow checking point
                bool result = figure.PointInFigureCheck(checkingPoint);

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

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            // Check if there is no row selected
            if (PointsGridView.CurrentRow != null)
            {
                int currentRow = PointsGridView.SelectedCells[0].RowIndex;

                // Check if selected row is the last
                if (currentRow == PointsGridView.Rows.Count - 1)
                {
                    selectedPoint = PointsGridView.Rows.Count;

                    figure.AddPoint(new Figure.Point());
                }
                else
                {
                    selectedPoint = currentRow + 1;

                    figure.InsertPoint(currentRow, new Figure.Point());
                }

            }
            // Adding new Point to the end of list if no row selected
            else
            {
                selectedPoint = PointsGridView.Rows.Count;

                figure.AddPoint(new Figure.Point());
            }
        }

        private void PointsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (PointsGridView.CurrentRow != null)
            {
                var currentRow = PointsGridView.CurrentRow;

                int.TryParse(currentRow.Cells[0].Value.ToString(), out int x);
                int.TryParse(currentRow.Cells[1].Value.ToString(), out int y);


                figure.UpdatePoint(currentRow.Index, x, y);
            }
        }

        private void RemRowBtn_Click(object sender, EventArgs e)
        {
            // Check if there is no row selected
            if (PointsGridView.CurrentRow != null)
            {
                int currentRow = PointsGridView.CurrentRow.Index;

                figure.RemovePoint(currentRow);
            }
        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            if (PointsGridView.CurrentRow != null &&
                PointsGridView.CurrentRow.Index > 0)
            {
                int currentRow = PointsGridView.CurrentRow.Index;

                selectedPoint = currentRow - 1;

                figure.MovePointDown(currentRow);
            }
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            if (PointsGridView.CurrentRow != null &&
                PointsGridView.CurrentRow.Index < PointsGridView.Rows.Count - 1)
            {
                int currentRow = PointsGridView.CurrentRow.Index;

                selectedPoint = currentRow + 1;

                figure.MovePointUp(currentRow);
            }
        }

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
                    figure.DeserializeFromJson(text);
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке многоугольника");
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            figure.ClearPoints();
        }

        public void ShowSaveDialog()
        {
            var result = MessageBox.Show(
                "Хотите сохранить многоугольник?",
                "Сохранение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string saveString = figure.SerializeToJson();

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
                selectedPoint = PointsGridView.SelectedCells[0].RowIndex;

                CurrentPointChanged?.Invoke();
            }
        }

        private void SquarePresertLoadbtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            figure.LoadSquerePreset();
        }

        private void TringlePresetLoadBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            figure.LoadTringlePreset();
        }

        private void HourglassPresetLoadBtn_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();

            figure.LoadHourglassPreset();
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (Control.ModifierKeys)
            {
                case Keys.Shift:

                    figure.AddPoint(new Figure.Point(e.X, e.Y));

                    break;

                case Keys.Control:


                    break;

                case Keys.None:

                    checkingPoint = new Figure.Point(e.X, e.Y);

                    selectedPoint += 1;

                    CurrentPointChanged?.Invoke();
                    PointChanged?.Invoke();
                    break;
            }
        }

        private void KeyPressHandler(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    if (selectedPoint == 0)
                    {
                        selectedPoint = figure.GetCount() - 1;
                    }
                    else
                    {
                        selectedPoint -= 1;
                    }

                    CurrentPointChanged?.Invoke();

                    break;

                case Keys.Down:
                    
                    if (selectedPoint == figure.GetCount() - 1)
                    {
                        selectedPoint = 0;
                    }
                    else
                    {
                        selectedPoint += 1;
                    }

                    CurrentPointChanged?.Invoke();

                    break;

                case Keys.Delete:
                    figure.RemovePoint(selectedPoint);
                    break;
            }

        }
    }
}