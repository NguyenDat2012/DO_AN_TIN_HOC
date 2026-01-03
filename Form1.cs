using MALLMAP_TANG2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALLMAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MAP map = new MAP(50);
        List<int> currentPath = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thêm các node
            map.AddNode(new MAPNODE("H&M", 359, 204));
            map.AddNode(new MAPNODE("New Drops", 474, 184));
            map.AddNode(new MAPNODE("Skechers", 515, 182));
            map.AddNode(new MAPNODE("Flying Tiger", 545, 182));
            map.AddNode(new MAPNODE("Xtep", 638, 184));
            map.AddNode(new MAPNODE("Decathlon", 686, 186));
            map.AddNode(new MAPNODE("New Balance", 730, 184));
            map.AddNode(new MAPNODE("Crocs", 765, 203));
            map.AddNode(new MAPNODE("Swensen's", 759, 233));
            map.AddNode(new MAPNODE("Xing fu tang", 756, 254));
            map.AddNode(new MAPNODE("Aeon", 814, 251));
            map.AddNode(new MAPNODE("Onoff", 770, 295));
            map.AddNode(new MAPNODE("Sline fashion", 742, 300));
            map.AddNode(new MAPNODE("Mắt việt", 720, 293));
            map.AddNode(new MAPNODE("Pucini", 696, 295));
            map.AddNode(new MAPNODE("Marc", 648, 294));
            map.AddNode(new MAPNODE("Joven", 608, 292));
            map.AddNode(new MAPNODE("Olv", 570, 296));
            map.AddNode(new MAPNODE("Kume", 544, 271));
            map.AddNode(new MAPNODE("Couple tx", 523, 295));
            map.AddNode(new MAPNODE("Canifa", 476, 296));
            map.AddNode(new MAPNODE("Lemino", 431, 293));
            map.AddNode(new MAPNODE("Kohnam", 372, 277));
            map.AddNode(new MAPNODE("Dear Rosé", 604, 248));

            //Thêm cạnh
            AddEdgeByCoords(0, 1);
            AddEdgeByCoords(1, 2);
            AddEdgeByCoords(2, 3);
            AddEdgeByCoords(3, 4);
            AddEdgeByCoords(4, 5);
            AddEdgeByCoords(5, 6);
            AddEdgeByCoords(6, 7);
            AddEdgeByCoords(7, 8);
            AddEdgeByCoords(7, 10);
            AddEdgeByCoords(8, 9);
            AddEdgeByCoords(8, 10);
            AddEdgeByCoords(9, 10);
            AddEdgeByCoords(9, 11);
            AddEdgeByCoords(10, 11);
            AddEdgeByCoords(11, 12);
            AddEdgeByCoords(12, 13);
            AddEdgeByCoords(13, 14);
            AddEdgeByCoords(14, 15);
            AddEdgeByCoords(15, 16);
            AddEdgeByCoords(16, 17);
            AddEdgeByCoords(17, 18);
            AddEdgeByCoords(17, 19);
            AddEdgeByCoords(18, 19);
            AddEdgeByCoords(19, 20);
            AddEdgeByCoords(20, 21);
            AddEdgeByCoords(21, 22);
            AddEdgeByCoords(22, 0);
            AddEdgeByCoords(3, 23);
            AddEdgeByCoords(4, 23);
            AddEdgeByCoords(16, 23);
            AddEdgeByCoords(17, 23);
            AddEdgeByCoords(18, 23);


            //Chạy thuật toán Floyd-Warshall để tính toán tất cả các đường đi ngắn nhất
            map.FloydWarshall();

            //Thêm các node vào combobox
            foreach(MAPNODE node in map.Mapnodes)
            {
                cboStart.Items.Add(node);
                cboEnd.Items.Add(node);
            }
        }

        // Tính khoảng cách giữa 2 điểm dựa trên tọa độ với công thức khoảng cách Euclid = sqrt((x2 - x1)^2 + (y2 - y1)^2)
        private void AddEdgeByCoords(int a, int b)
        {
            MAPNODE na = map.Mapnodes[a];
            MAPNODE nb = map.Mapnodes[b];
            double dx = nb.X - na.X;
            double dy = nb.Y - na.Y;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            map.AddEdge(a, b, dist);
        }

        //Nút tìm đường đi ngắn nhất
        private void btnFind_Click(object sender, EventArgs e)
        {
            int s = cboStart.SelectedIndex;
            int t = cboEnd.SelectedIndex;
            if (s < 0 || t < 0) return;

            currentPath = map.GetPath(s, t);
            if (currentPath == null)
            {
                MessageBox.Show("Không tìm thấy đường đi giữa 2 địa điểm");
            }
            ptbTANG2.Invalidate();
        }


        //vẽ node và vẽ đường đi cần tìm
        private void ptbTANG2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//Tạo cho node tròn mịn hơn


            foreach (MAPNODE n in map.Mapnodes)
            {
                g.FillEllipse(Brushes.Orange, n.X - 6, n.Y - 6, 12, 12);
                
            }
            if (currentPath != null && currentPath.Count >= 2)
            {
                using (Pen p = new Pen(Color.Red, 4))
                {
                    for (int i = 0; i < currentPath.Count - 1; i++)
                    {
                        MAPNODE a = map.Mapnodes[currentPath[i]];
                        MAPNODE b = map.Mapnodes[currentPath[i + 1]];
                        g.DrawLine(p, a.X, a.Y, b.X, b.Y);
                    }
                }
            }
        }
        
    }
}
