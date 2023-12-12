using System;
using System.IO;
using System.Windows.Forms;

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
            figure.FigureChanged += ChartUpdate;
            figure.FigureChanged += CalculateAnswer;

            //Update chart on changes checking point coordinates
            PointChanged += ChartUpdate;
            PointChanged += CalculateAnswer;

            //update chart when selected row changes
            CurrentPointChanged += ChartUpdate;
        }


        private void ChartUpdate()
        {
            //Clear points, lines and checking point from chart 
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            //Get new dots from model
            var points = figure.GetPoints();

            //Check if figure is empty
            if (points.Count > 0)
            {
                //Draw new points
                foreach (Figure.Point point in points)
                {
                    chart1.Series[0].Points.AddXY(point.x, point.y);
                }


                //Drow new lines
                foreach (Figure.Point point in points)
                {
                    chart1.Series[1].Points.AddXY(point.x, point.y);
                }
                //Close the line
                chart1.Series[1].Points.AddXY(points[0].x, points[0].y);
            }

            //Drow selected point
            if (selectedPoint >= 0)
            {
                var point = figure.GetPoint(selectedPoint);

                if (point != null)
                {
                    chart1.Series[3].Points.AddXY(point.x, point.y);
                }
            }

            //Draw a point to check
            if(checkingPoint != null)
            {
                chart1.Series[2].Points.AddXY(checkingPoint.x, checkingPoint.y);
            }            
        }

        private void DataGridUpdate() 
        {
            var points = figure.GetPoints();

            PointsGridView.CancelEdit();
            PointsGridView.Rows.Clear();

            foreach ( var point in points )
            {
                PointsGridView.Rows.Add( point.x, point.y );
            }
                
            PointsGridView.ClearSelection();

            if (selectedPoint < PointsGridView.Rows.Count)
            {
                PointsGridView.Rows[selectedPoint].Selected = true;
            }
        }

        private void CalculateAnswer()
        {
            if (figure.PointInFigureCheck(checkingPoint))
            {
                AnserLabel.Visible = false;
            }
            else
            {
                AnserLabel.Visible = true;
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

                double.TryParse(currentRow.Cells[0].Value.ToString(), out double x);
                double.TryParse(currentRow.Cells[1].Value.ToString(), out double y);


                figure.UpdatePoint(currentRow.Index, x , y );
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

        private void CheckingPointCords_TextChanged(object sender, EventArgs e)
        {
            //Check user input
            if (double.TryParse(XcordTxtBox.Text, out double x) &&
                double.TryParse(YcordTxtBox.Text, out double y))
            {
                //Update coordinates
                checkingPoint.x = x;
                checkingPoint.y = y;

                PointChanged?.Invoke();
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
                
            if(result == DialogResult.Yes)
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
    }
}
