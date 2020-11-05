using System;
using System.Collections.Generic;

namespace Snake {
  class VerticalLine {
    private List<Point> vLine;

    public VerticalLine(int startY, int endY, int x, char sym) {
      vLine = new List<Point>();

      for (int y = startY; y <= endY; y += 1) {
        Point p = new Point(x, y, sym);
        vLine.Add(p);
      }
    }

    public void Draw() {
      foreach (Point p in vLine) {
        p.Draw();
      }
    }
  }
}