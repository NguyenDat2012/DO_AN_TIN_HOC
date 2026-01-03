using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MALLMAP_TANG2
{
    class MAP
    {
        private List<MAPNODE> mapnodes = new List<MAPNODE>();
        private double[,] Dist;
        private int[,] Next;
        public List<MAPNODE> Mapnodes
        {
            get { return mapnodes; }
            set { mapnodes = value; }
        }
        public MAP()
        {
            this.mapnodes = new List<MAPNODE>();
        }
        
        public MAP(int size)
        {
            Dist = new double[size, size];//ma trận khoảng cách
            Next = new int[size, size];//ma trận lưu đường đi
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    Dist[i, j] = (i == j) ? 0 : double.PositiveInfinity;//vô cực
                    Next[i, j] = -1;
                }
        }
        private int N
        {
            get { return mapnodes.Count; }
        }
        //Tạo node mới
        public void AddNode(MAPNODE node)
        {
            if (N < Dist.GetLength(0)) //GetLength(0) trả về số dòng trong mảng đã khởi tạo, GetLegth(1) trả về số cột đã khởi tạo
            {
                mapnodes.Add(node);
            }
        }
        //Tạo cạnh giữa 2 node (đồ vị vô hướng)
        public void AddEdge(int a, int b, double w)
        {
            Dist[a, b] = w;
            Dist[b, a] = w;
            Next[a, b] = b;
            Next[b, a] = a;
        }
        

        //Thuật toán floyd
        public void FloydWarshall()
        {
            for (int k = 0; k < N; k++)
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        if (Dist[i, k] + Dist[k, j] < Dist[i, j])
                        {
                            Dist[i, j] = Dist[i, k] + Dist[k, j];
                            Next[i, j] = Next[i, k];
                        }
        }

        // Lưu đường đi 
        public List<int> GetPath(int u, int v)
        {
            if (u < 0 || v < 0 || u >= N || v >= N) return null;
            if (Next[u, v] == -1) 
                return null;
            List<int> path = new List<int>();
            path.Add(u);
            while (u != v)
            {
                u = Next[u, v];
                if(u == -1) 
                    return null;
                path.Add(u);
            }
            return path;
        }

    }
}
