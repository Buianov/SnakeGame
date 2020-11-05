using System;
using System.Collections.Generic;

namespace Snake {
  class HorizontalLine : Figure  {
      public HorizontalLine(int startX, int endX, int y, char sym) {
      pList = new List<Point>();

      for (int x = startX; x <= endX; x += 1) {
        Point p = new Point(x, y, sym);
        pList.Add(p);
      }
    }
  }
}