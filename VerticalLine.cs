using System;
using System.Collections.Generic;

namespace Snake {
  class VerticalLine : Figure {
    public VerticalLine(int startY, int endY, int x, char sym) {
      pList = new List<Point>();

      for (int y = startY; y <= endY; y += 1) {
        Point p = new Point(x, y, sym);
        pList.Add(p);
      }
    }
  }
}