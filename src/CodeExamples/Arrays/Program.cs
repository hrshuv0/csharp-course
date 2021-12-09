using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string name = "jalaluddin";

            string[] cityNames = new string[] { "Dhaka", "Chittagong", "Khulna" };

            cityNames[0] = "Dhaka";
            cityNames[1] = "Sylhet";

            string city1 = cityNames[0];

            Console.WriteLine(cityNames[0]);

            int[,] grid = new int[20, 10];

            int[] ages = new int[x];

            grid[0, 0] = 5;
            grid[0, 1] = 10;

            int[][] scores = new int[3][];
            scores[0] = new int[] { 0, 2, 3 };
            scores[1] = new int[3];
            scores[2] = new int[7];

            int[][] scores2 = new int[3][]
            {
                new int[]{ 2, 4, 5 },
                new int[] { },
                new int[] { } // Empty array
            };

            scores[0][1] = 5; // Assign a value
            scores[1][1] = 2;

            Console.WriteLine(scores.GetLength(0));



            // Taking input for a graph.

            /* This is line 1
             * This is line 2
             */

            string line = Console.ReadLine(); //5, 4
            string[] parts = line.Split(',');
            int nodes = int.Parse(parts[0]);
            int edges = int.Parse(parts[1].Trim());

            int[,] graph = new int[nodes + 1, nodes + 1];

            for(int i = 0; i < edges; i++)
            {
                string edge = Console.ReadLine();
                string[] edgeParts = edge.Split(',');
                int node1 = int.Parse(edgeParts[0]);
                int node2 = int.Parse(edgeParts[1].Trim());

                graph[node1, node2] = 1;
                graph[node2, node1] = 1;
            }

            for(int i = 0; i< nodes; i++)
            {
                for (int j = 0; j < nodes; j++)
                {
                    Console.Write(graph[i,j]);
                    Console.Write(' ');
                }

                Console.WriteLine();
            }
        }
            
    }
}
