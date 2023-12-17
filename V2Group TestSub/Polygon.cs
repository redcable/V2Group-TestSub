using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text.Json;

namespace V2Group_TestSub
{
    internal class Polygon
    {
        // List of polygon nodes
        private List<Node> nodes = new List<Node>();

        // Id of selected node
        private int currentNode = 0;
        public int CurrentNode
        {
            get
            {
                return currentNode;
            }

            set
            {
                if (ValidateID(value))
                {
                    currentNode = value;

                    CurrentNodeChanged?.Invoke();
                }
            }
        }
       

        // Event called when polygon changed somehow
        public delegate void PolygonCahngesHandler();
        public event PolygonCahngesHandler PolygonChanged;

        // Event called when current node id changed from outside
        public delegate void CurrNodeCahngesHandler();
        public event CurrNodeCahngesHandler CurrentNodeChanged;


        // Object that store coordinates of polygone node
        public class Node
        {
            public Node(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Node()
            {
                x = 0;
                y = 0;
            }

            public int x { get; set; }
            public int y { get; set; }

            public Point Convert()
            {
                return new Point(x, y);
            }
        }


        // Everything in there just for this method
        // Checks if inputed point is in figure or not
        public bool PointEntryCheck(Node chPnt)
        {
            //Check if figure have at least 3 points
            if (nodes.Count < 3)
            {
                return false;
            }

            double radSum = 0;

            Node vectorA;
            Node vectorB;

            for (int i = 0; i < nodes.Count; i++)
            {
                // Convert segmens into vectors
                if (i == 0)
                {
                    vectorA = new Node(nodes[nodes.Count - 1].x - chPnt.x, nodes[nodes.Count - 1].y - chPnt.y);
                    vectorB = new Node(nodes[i].x - chPnt.x, nodes[i].y - chPnt.y);
                }
                else
                {
                    vectorA = new Node(nodes[i - 1].x - chPnt.x, nodes[i - 1].y - chPnt.y);
                    vectorB = new Node(nodes[i].x - chPnt.x, nodes[i].y - chPnt.y);
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
        public void AddNode(Node node) 
        {
            if (currentNode == nodes.Count - 1)
            {
                 nodes.Add(node);

                 currentNode = nodes.Count - 1;
            }
            else
            {
                nodes.Insert(currentNode, node);

                currentNode += 1;
            }
            
            PolygonChanged?.Invoke();
        }

        public void AddNode(int x, int y) 
        {
            Node node = new Node(x, y);

            if (currentNode == nodes.Count - 1)
            {
                nodes.Add(node);

                currentNode = nodes.Count - 1;
            }
            else
            {
                currentNode += 1;

                nodes.Insert(currentNode, node);
            }

            PolygonChanged?.Invoke();
        }

        public void InsertNode (Node node) 
        {
            if (ValidateID(currentNode += 1))
            {
                nodes.Insert(currentNode, node);
            }

            PolygonChanged?.Invoke();
        }

        public void InsertNode(int id, int x, int y) 
        {
            if (ValidateID(id))
            {
                nodes.Insert(id, new Node(x, y));

                currentNode = id;

                PolygonChanged?.Invoke();
            }
        }

        public void RemoveNode()
        {
            nodes.RemoveAt(currentNode);

            if (currentNode >= nodes.Count)
            {
                currentNode = nodes.Count - 1;
            }


            PolygonChanged?.Invoke();
        }

        public void ClearNodes()
        {
            nodes.Clear();

            currentNode = 0;

            PolygonChanged?.Invoke();
        }

        public void UpdateNode(Node node) 
        {
            PolygonChanged?.Invoke();
        }

        public void UpdateNode(int x, int y) 
        {
            if (ValidateID(currentNode))
            {
                nodes[currentNode].x = x;
                nodes[currentNode].y = y;

                PolygonChanged?.Invoke();
            }
        }

        public void MoveNodeUp()
        {
            if (currentNode < nodes.Count - 1)
            {
                Node buf = nodes[currentNode];

                nodes.RemoveAt(currentNode);

                nodes.Insert(currentNode + 1, buf);

                PolygonChanged?.Invoke();
            }
        }

        public void MoveNodeDown()
        {
            if (currentNode != 0)
            {
                Node buf = nodes[currentNode];

                nodes.RemoveAt(currentNode);

                nodes.Insert(currentNode - 1, buf);

                PolygonChanged?.Invoke();
            }
        }


        // Typhical output methods
        public int GetCount()
        {
            return nodes.Count;
        }

        public Node GetNode(int id) 
        { 

            if(ValidateID(id))
            {
                return nodes[id];
            }

            return null;
        }

        public List<Node> GetNodes() 
        { 
            return nodes;
        }

        //Converts points list into array of Drawing.Point 
        public Point[] Convert()
        {
            // Looks like a mess, but better this than redo the entire class 
            // using Drawing.Point class instead
            // (I tried)

            Point[] output = new Point[nodes.Count];

            for (int i = 0; i < nodes.Count; i++)
            {
                output[i] = nodes[i].Convert();
            }

            return output;
        }


        // Check id input 
        protected bool ValidateID (int id)
        {
            if (id >= 0 && id < nodes.Count)
            {
                return true;
            }

            return false;
        }


        public void NextNode ()
        {
            if (currentNode == nodes.Count - 1)
            {
                currentNode = 0;
            }
            else
            {
                currentNode += 1;
            }
        }

        public void PrevNode ()
        {
            if (currentNode == 0)
            {
                currentNode = nodes.Count - 1;
            }
            else
            {
                currentNode -= 1;
            }
        }

        public void ScalePolygon (double xScale, double yScale)
        {
            foreach (Node node in nodes)
            {
                node.y = (int)(node.y * yScale);
                node.x = (int)(node.x * xScale);
            }

            PolygonChanged?.Invoke();
        }

        
        // Json serializing
        public string SerializeToJson()
        {
            string output = JsonSerializer.Serialize(nodes);
            return output;
        }

        public void DeserializeFromJson(string text)
        {
            List<Node> points = JsonSerializer.Deserialize<List<Node>>(text);

            this.nodes = points;

            PolygonChanged?.Invoke();
        }


        // Presets
        public void LoadSquerePreset()
        {
            List<Node> buf = new List<Node>
            {
                new Node(100, 100),
                new Node(100, 200),
                new Node(200, 200),
                new Node(200, 100)
            };

            nodes = buf;

            PolygonChanged?.Invoke();
        }

        public void LoadTringlePreset()
        {
            List<Node> buf = new List<Node>
            {
                new Node(100, 100),
                new Node(200, 200),
                new Node(300, 100)
            };

            nodes = buf;

            PolygonChanged?.Invoke();
        }

        public void LoadHourglassPreset()
        {
            List<Node> buf = new List<Node>
            {
                new Node(100, 100),
                new Node(200, 100),
                new Node(100, 200),
                new Node(200, 200)
            };

            nodes = buf;

            PolygonChanged?.Invoke();
        }

    }
}
