using System;
using System.Collections.Generic;

namespace Snake {
  class HorizontalLine {
    private List<Point> pList;

    public HorizontalLine(int startX, int endX, int y, char sym) {
      pList = new List<Point>();

      for (int x = startX; x <= endX; x += 1) {
        Point p = new Point(x, y, sym);
        pList.Add(p);
      }
    }

    public void Draw() {
      foreach (Point p in pList) {
        p.Draw();
      }
    }
  }
}