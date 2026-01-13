using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int solution(int[,] maps)
    {
        int[,] nCosts = new int[maps.GetLength(0), maps.GetLength(1)];
        Queue<Map> que = new Queue<Map>();
        que.Enqueue(new Map(0, 0, 1));
        nCosts[0, 0] = 1;
        while (que.Count() > 0)
        {
            Map map = que.Dequeue();
            int x = map.X;
            int y = map.Y;

            // 상하좌우 살펴서
            if (y > 0 && maps[y - 1, x] == 1)   // 상
            {
                if (nCosts[y - 1, x] == 0 || nCosts[y - 1, x] > map.Cost + 1)
                {
                    nCosts[y - 1, x] = map.Cost + 1;
                    que.Enqueue(new Map(x, y - 1, map.Cost + 1));
                }
            }
            if (y < maps.GetLength(0) - 1 && maps[y + 1, x] == 1)  // 하
            {
                if (nCosts[y + 1, x] == 0 || nCosts[y + 1, x] > map.Cost + 1)
                {
                    nCosts[y + 1, x] = map.Cost + 1;
                    que.Enqueue(new Map(x, y + 1, map.Cost + 1));
                }
            }
            if (x > 0 && maps[y, x - 1] == 1)  // 좌
            {
                if (nCosts[y, x - 1] == 0 || nCosts[y, x - 1] > map.Cost + 1)
                {
                    nCosts[y, x - 1] = map.Cost + 1;
                    que.Enqueue(new Map(x - 1, y, map.Cost + 1));
                }
            }
            if (x < maps.GetLength(1) - 1 && maps[y, x + 1] == 1)  // 우
            {
                if (nCosts[y, x + 1] == 0 || nCosts[y, x + 1] > map.Cost + 1)
                {
                    nCosts[y, x + 1] = map.Cost + 1;
                    que.Enqueue(new Map(x + 1, y, map.Cost + 1));
                }
            }
        }
        return nCosts[maps.GetLength(0) - 1, maps.GetLength(1) - 1] == 0 ? -1 : nCosts[maps.GetLength(0) - 1, maps.GetLength(1) - 1];
    }
}

public class Map
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Cost { get; set; }
    public Map(int x, int y, int cost)
    {
        this.X = x;
        this.Y = y;
        this.Cost = cost;
    }
}