using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake {
  class Snake : Figure {

    Direction dir;

    public Snake(Point tail, int length, Direction _dir) {
      pList = new List<Point>();
      dir = _dir;

      for (int i = 0; i <= length; i += 1) {
        Point p = new Point(tail);
        p.Move(i, _dir);
        pList.Add(p);
      }
    }

    public void Move() {
      // clear last point
      Point tail = pList.First();
      pList.Remove(tail);
      tail.Clear();

      // add new point
      Point head = pList.Last();
      Point newHead = GetNextPoint(head, dir);
      pList.Add(newHead);
      newHead.Draw();

    }

    private Point GetNextPoint(Point head, Direction dir) {
      Point newP = new Point(head);
      newP.Move(1, dir);
      return newP;
    }

    public void HandleKey(ConsoleKey key) {
      switch(key) {
        case ConsoleKey.LeftArrow:
          dir = Direction.LEFT;
          break;
        case ConsoleKey.RightArrow:
          dir = Direction.RIGHT;
          break;
        case ConsoleKey.DownArrow:
          dir = Direction.DOWN;
          break;
        case ConsoleKey.UpArrow:
          dir = Direction.UP;
          break;
      }
    }
  }
}