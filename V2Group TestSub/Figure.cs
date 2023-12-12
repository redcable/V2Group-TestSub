using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2Group_TestSub
{
    internal class Figure
    {
        private List<Point> points = new List<Point>();

        public delegate void CahngesHandler();
        public event CahngesHandler FigureChanged;

        public class Point
        {
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public Point()
            {
                this.x = 0d;
                this.y = 0d;
            }

            public double x { get; set; }
            public double y { get; set; }
        }

        public void AddPoint(Point point) 
        {
            points.Add(point);

            FigureChanged?.Invoke();
        }

        public void AddPoint(double x, double y) 
        {
            points.Add(new Point(x, y));

            FigureChanged?.Invoke();
        }

        public void InsertPoint (int id, Point point) 
        {
            if (ValidateID(id += 1))
            {
                points.Insert(id, point);
            }

            FigureChanged?.Invoke();
        }

        public void InsertPoint(int id, double x, double y) 
        {
            if (ValidateID(id += 1))
            {
                points.Insert(id, new Point(x, y));
            }

            FigureChanged?.Invoke();
        }

        public void RemovePoint(int id) 
        {
            if (ValidateID(id))
            {
                points.RemoveAt(id);
            }

            FigureChanged?.Invoke();
        }

        public void ClearPoints()
        {
            points.Clear();

            FigureChanged?.Invoke();
        }

        public void UpdatePoint(int id, Point point) 
        {
            if (ValidateID(id))
            {
                points[id] = point;
            }

            FigureChanged?.Invoke();
        }

        public void UpdatePoint(int id, double x, double y) 
        {
            if (ValidateID(id))
            {
                points[id].x = x;
                points[id].y = y;
            }

            FigureChanged?.Invoke();
        }

        public void MovePointUp(int id)
        {
            if (ValidateID(id) && id < points.Count - 1)
            {
                Point buf = points[id];

                points.RemoveAt(id);

                points.Insert(id + 1, buf);
            }

            FigureChanged?.Invoke();
        }

        public void MovePointDown(int id)
        {
            if (ValidateID(id) && id != 0)
            {
                Point buf = points[id];

                points.RemoveAt(id);

                points.Insert(id - 1, buf);
            }

            FigureChanged?.Invoke();
        }

        public Point GetPoint(int id) 
        { 

            if(ValidateID(id))
            {
                return points[id];
            }

            return null;
        }

        public List<Point> GetPoints() 
        { 
            return points;
        }


        protected bool ValidateID (int id)
        {
            if (id >= 0 && id < points.Count)
            {
                return true;
            }

            return false;
        }


        //TODO do somthing with points count
        public bool PointInFigureCheck(Point beamStart)
        {
            //Check if figure have at least 3 points
            if (points.Count < 3)
            {
                return false;
            }

            //Windings counter
            int counter = 0;

            //Start and end points of figure edge
            Point edgeStart;
            Point edgeEnd;

            //End pooint of beam
            Point beamEnd = new Point(beamStart.x + 1, beamStart.y);

            //Сycle through all edges of the figure
            for (int i = 0; i < points.Count; i++)
            {
                //Getting start coordiantes of figure edge
                edgeStart = points[i];

                //Getting end coordiantes of figure edge
                if (i == points.Count - 1)
                {
                    edgeEnd = points[0];
                }
                else
                {
                    edgeEnd = points[i + 1];
                }

                //Check if all points of edge are higher or lower than beam 
                if ( !(edgeStart.y > beamStart.y && edgeEnd.y > beamStart.y) && 
                     !(edgeStart.y < beamStart.y && edgeEnd.y < beamStart.y))
                {

                    //intermediate calculations
                    double v = beamEnd.x - beamStart.x;
                    double w = beamEnd.y - beamStart.y;

                    double a = edgeEnd.y - edgeStart.y;
                    double b = edgeStart.x - edgeEnd.x;
                    double c = -edgeStart.x * edgeEnd.y + edgeStart.y * edgeEnd.x;

                    double t = (-a * beamStart.x - b * beamStart.y - c) / (a * v + b * w);

                    //Edge is crossed when t >= 0
                    if (t >= 0)
                    { 
                        if (edgeStart.y >= beamStart.y)
                        {
                            counter++;
                        }
                        else
                        {
                            counter--;
                        }
                    }
                }
            }  
            
            if (counter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string SerializeToJson()
        {
            string output = JsonSerializer.Serialize(points);
            return output;
        }

        public void DeserializeFromJson(string text)
        {
            List<Point> points = JsonSerializer.Deserialize<List<Point>>(text);

            this.points = points;

            FigureChanged?.Invoke();
        }


        public void LoadSquerePreset()
        {
            List<Point> buf = new List<Point>();

            buf.Add(new Point(1, 1));
            buf.Add(new Point(1, 2));
            buf.Add(new Point(2, 2));
            buf.Add(new Point(2, 1));

            points = buf;

            FigureChanged?.Invoke();
        }

        public void LoadTringlePreset()
        {
            List<Point> buf = new List<Point>();

            buf.Add(new Point(1, 1));
            buf.Add(new Point(2, 2));
            buf.Add(new Point(3, 1));

            points = buf;

            FigureChanged?.Invoke();
        }

        public void LoadHourglassPreset()
        {
            List<Point> buf = new List<Point>();

            buf.Add(new Point(1, 1));
            buf.Add(new Point(2, 1));
            buf.Add(new Point(1, 2));
            buf.Add(new Point(2, 2));

            points = buf;

            FigureChanged?.Invoke();
        }
    }
}
