using System;
using System.Collections.Generic;

namespace Snake {
  class Snake : Figure {
    public Snake(Point tail, int length, Direction dir) {
      pList = new List<Point>();

      for (int i = 0; i <= length; i += 1) {
        Point p = new Point(tail);
        p.Move(i, dir);
        pList.Add(p);
      }
    }
  }
}