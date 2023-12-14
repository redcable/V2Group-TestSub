using System;
using System.Drawing;
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
        // Place to store all figure corners
        private List<Point> points = new List<Point>();

       

        // Event called when figure changed somehow
        public delegate void CahngesHandler();
        public event CahngesHandler FigureChanged;

        // class to store coordinates
        public class Point
        {
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Point()
            {
                x = 0;
                y = 0;
            }

            public int x { get; set; }
            public int y { get; set; }

            public System.Drawing.Point Convert()
            {
                return new System.Drawing.Point(x, y);
            }
        }


        // Everything in there just for this method
        // Checks if inputed point is in figure or not
        public bool PointInFigureCheck(Point chPnt)
        {
            //Check if figure have at least 3 points
            if (points.Count < 3)
            {
                return false;
            }

            double radSum = 0;

            Point vectorA;
            Point vectorB;

            for (int i = 0; i < points.Count; i++)
            {
                // Convert segmens into vectors
                if (i == 0)
                {
                    vectorA = new Point(points[points.Count - 1].x - chPnt.x, points[points.Count - 1].y - chPnt.y);
                    vectorB = new Point(points[i].x - chPnt.x, points[i].y - chPnt.y);
                }
                else
                {
                    vectorA = new Point(points[i - 1].x - chPnt.x, points[i - 1].y - chPnt.y);
                    vectorB = new Point(points[i].x - chPnt.x, points[i].y - chPnt.y);
                }


                //             |   v0p * v1p   |       |    |vectorA||
                // angle = acos|---------------| * sign| det|       ||
                //             |absv0p * absv1p|       |    |vectorB||

                double sqrt1 = Math.Sqrt(vectorA.x * vectorA.x + vectorA.y * vectorA.y);
                double sqrt2 = Math.Sqrt(vectorB.x * vectorB.x + vectorB.y * vectorB.y);

                int sign = Math.Sign((vectorA.x * vectorB.y) - (vectorA.y * vectorB.x));

                double nominator = vectorA.x * vectorB.x + vectorA.y * vectorB.y;
                double denominator = sqrt1 * sqrt2;

                double angle = Math.Acos(nominator / denominator) * sign;

                radSum += angle ;
            }

            radSum /= (Math.PI * 2);

            int result = (int)(radSum * 1000);

            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // Typical input methods 
        public void AddPoint(Point point) 
        {
            points.Add(point);

            FigureChanged?.Invoke();
        }

        public void AddPoint(int x, int y) 
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

        public void InsertPoint(int id, int x, int y) 
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

        public void UpdatePoint(int id, int x, int y) 
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


        // Typhical output methods
        public int GetCount()
        {
            return points.Count;
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

        //Converts points list into array of Drawing.Point 
        public System.Drawing.Point[] GetDrawingPoints()
        {
            // Looks like a mess, but better this than redo the entire class 
            // using Drawing.Point class instead
            // (I tried)

            System.Drawing.Point[] output = new System.Drawing.Point[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                output[i] = points[i].Convert();
            }

            return output;
        }


        // Check id input 
        protected bool ValidateID (int id)
        {
            if (id >= 0 && id < points.Count)
            {
                return true;
            }

            return false;
        }

        
        // Json serializing
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


        // Presets
        public void LoadSquerePreset()
        {
            List<Point> buf = new List<Point>
            {
                new Point(100, 100),
                new Point(100, 200),
                new Point(200, 200),
                new Point(200, 100)
            };

            points = buf;

            FigureChanged?.Invoke();
        }

        public void LoadTringlePreset()
        {
            List<Point> buf = new List<Point>
            {
                new Point(1, 1),
                new Point(2, 2),
                new Point(3, 1)
            };

            points = buf;

            FigureChanged?.Invoke();
        }

        public void LoadHourglassPreset()
        {
            List<Point> buf = new List<Point>
            {
                new Point(1, 1),
                new Point(2, 1),
                new Point(1, 2),
                new Point(2, 2)
            };

            points = buf;

            FigureChanged?.Invoke();
        }

    }
}
